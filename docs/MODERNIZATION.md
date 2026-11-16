# Modernización de MdgMvcSpat

Hoja de ruta y estándares de código para llevar el cliente MVC desde `netcoreapp3.1` a **.NET 10**, con buenas prácticas actuales.
Este documento es la fuente de verdad: cada paso se marca al terminarse y se commitea por separado.

## Estado actual

Última actualización: 2026-11-16.

- **Hecho:** redacción de `CLAUDE.md` y de este documento (sin commitear todavía).
- **Añadido el 2026-11-16:** auditoría de paquetes NuGet, estándares de seguridad web y sección de riesgos de migración. Lo marcado como *(a verificar)* depende de comprobar el código o la API antes de ejecutarlo.
- **Pendiente del mantenedor, antes de seguir:**
  1. Revisar `CLAUDE.md` y `docs/MODERNIZATION.md` (incluidas las secciones nuevas) y ajustar lo que haga falta.
  2. Commitear ambos archivos (mensaje sugerido: `docs: add project conventions and modernization roadmap`).
- **Siguiente paso:** Fase 0, `global.json` (SDK 10) y `Directory.Build.props`, y build de línea base en `netcoreapp3.1` (el runtime 3.1.32 está instalado).
- **Decisiones ya tomadas:** .NET 10, autenticación por cookie con `DelegatingHandler`, `HttpClient` tipado con `System.Text.Json`, y tests, CI, eliminación de `static` y logging dentro del alcance. El ajuste visual de Bootstrap queda fuera por ahora.

## Estándares de código

### Plataforma
- Destino `net10.0` en todos los proyectos; SDK fijado con `global.json`.
- `Nullable` e `ImplicitUsings` activos (configurados en `Directory.Build.props`).
- *File-scoped namespaces* en todo archivo `.cs`.
- Minimal hosting: todo el arranque en `Program.cs`, sin `Startup.cs`.
- Gestión central de paquetes (`Directory.Packages.props`): las versiones viven solo ahí.
- `.editorconfig` y analizadores: `AnalysisLevel=latest-recommended` y `EnforceCodeStyleInBuild`. `TreatWarningsAsErrors` se activa de forma gradual (primero solo para `nullable`) cuando el código esté limpio.
- Solo se referencian paquetes que **no** vengan ya en `Microsoft.AspNetCore.App`. Prohibidos los paquetes `Microsoft.AspNetCore.*` 2.x.
- `DATA` no depende de EF Core ni de ASP.NET Identity: el cliente no accede a la base de datos.
- Sin `Razor.RuntimeCompilation`; se usa Hot Reload (`dotnet watch`).
- Archivos estáticos con `MapStaticAssets()` y `.WithStaticAssets()` en las rutas MVC (sustituye a `UseStaticFiles`/`UseDefaultFiles`).
- Áreas con `[Area("...")]` en cada controlador y una única ruta `{area:exists}/{controller}/{action}/{id?}`, en lugar de un `MapAreaControllerRoute` por área.
- Endpoint `/health` con *health checks*, incluida la disponibilidad de la API.
- Localización con `UseRequestLocalization` y la cultura del despliegue (p. ej. `es-BO`, *a verificar*), para fechas y números en vistas y Excel.
- Estilo C# moderno donde aporte: *primary constructors* para la DI, `record` y `required` en DTOs y *view models* de solo lectura, *collection expressions*, `TimeProvider` en lugar de `DateTime.Now` para lo testeable.

### Configuración y secretos
- La configuración se enlaza a clases tipadas con `IOptions<T>` y se valida al arrancar (`ValidateOnStart`).
- Ninguna URL ni clave en código. `appsettings.json` **nunca** se versiona; la plantilla es `appsettings.example.json`.
- En local se pueden usar *user-secrets* para valores sensibles.

### Acceso a la API
- Prohibido el cliente HTTP estático o compartido que se muta por petición.
- Un cliente tipado por área (`IMascotaApi`, `IAdopcionApi`, ...) registrado con `AddHttpClient<>` e `IHttpClientFactory`.
- El token del usuario lo agrega un `DelegatingHandler` por petición; los controladores no tocan cabeceras de autenticación.
- Serialización con `System.Text.Json` y opciones compartidas (`JsonSerializerDefaults.Web`, `ReferenceHandler.IgnoreCycles` si hace falta). Sin RestSharp ni Newtonsoft. Los atributos `[JsonProperty]` pasan a `[JsonPropertyName]`.
- Resiliencia con `AddStandardResilienceHandler()` (paquete `Microsoft.Extensions.Http.Resilience`, que **no** viene en el framework): reintentos, timeouts, circuit breaker. Los reintentos se desactivan para métodos no idempotentes (`DisableForUnsafeHttpMethods()`), para no duplicar denuncias, adopciones ni seguimientos.
- Las respuestas se modelan con `ApiResult<T>`: éxito, datos o `ApiError` con el mensaje de la API. Sin flujo de control por excepciones.

### Autenticación
- Inicio de sesión con cookie `HttpOnly`, `Secure`, `SameSite=Lax`. El JWT de la API vive dentro de la cookie de autenticación, no en sesión.
- Roles e identidad salen de los *claims*; nunca de campos estáticos.
- El cliente no valida la firma del JWT: eso lo hace la API. Para construir los *claims* se lee el JWT sin validarlo (`JsonWebTokenHandler.ReadJsonWebToken`, paquete `Microsoft.IdentityModel.JsonWebTokens`) o, si la respuesta del login ya trae los datos del usuario, se usan esos y no hace falta el paquete *(a verificar)*.
- La vida de la cookie se alinea con el `exp` del JWT. Un `401` de la API cierra la sesión (`SignOutAsync`) y redirige al login; lo gestiona el `DelegatingHandler`.

### Seguridad web
- **Antiforgery global:** `AutoValidateAntiforgeryTokenAttribute` como filtro global. Con cookies el navegador adjunta la credencial solo, así que el CSRF pasa a ser un riesgo real. Hay `[HttpPost]` sin `[ValidateAntiForgeryToken]` (p. ej. `MascotaController`); revisar también las llamadas AJAX, que deben enviar el token.
- **Data Protection:** el JWT va dentro de la cookie, cifrada con las llaves de Data Protection. En producción las llaves se persisten (carpeta, almacenamiento compartido) o cada reinicio invalida todas las sesiones.
- **Tamaño de la cookie:** un JWT grande puede superar los 4 KB (ASP.NET Core la fragmenta). Si pasa, guardar solo lo necesario o usar `ITicketStore`.
- `UseHsts` en producción y cabeceras de seguridad (`Content-Security-Policy`, `X-Content-Type-Options`, `Referrer-Policy`). La CSP depende de las dependencias de CDN actuales, por lo que se ajusta cuando se traten (ver "Fuera de alcance").
- *Rate limiting* (`AddRateLimiter`) en el inicio de sesión.
- Nada de CORS abierto: el cliente MVC no lo necesita.

### Controladores y vistas
- Cero estado `static` en controladores. Paginación y filtros viajan como parámetros o *view models*.
- Inyección de dependencias por constructor; `async/await` de extremo a extremo, con `CancellationToken` donde aporte.
- Las vistas parciales se renderizan con un servicio inyectable (`IViewRenderService`) que hace `await` de `RenderAsync`.
- Generación de reportes (Excel) en servicios inyectables, no en métodos estáticos.
- Validación con `ModelState` y mensajes de error para el usuario; nada de `throw new Exception()` vacío.

### Errores y observabilidad
- `ILogger<T>` con registro estructurado. Nunca registrar tokens, contraseñas ni datos personales.
- Páginas de error centralizadas (`UseExceptionHandler` + `UseStatusCodePagesWithReExecute`).

### Calidad
- Pruebas con xUnit (v3); integración con `WebApplicationFactory` y una API simulada (un `HttpMessageHandler` propio o WireMock.Net).
- Librerías de apoyo: NSubstitute para dobles; Shouldly o AwesomeAssertions para aserciones. Se evitan FluentAssertions (licencia comercial desde la v8) y Moq.
- Test de contrato de serialización: JSON real de la API deserializado con las opciones compartidas, antes de migrar de Newtonsoft.
- Test de los reportes Excel: generar el archivo y reabrirlo con ClosedXML.
- CI en GitHub Actions: restore, build, test, `dotnet format --verify-no-changes` y auditoría de paquetes (`dotnet list package --vulnerable --include-transitive` y `--deprecated`).
- Dependabot para NuGet y GitHub Actions.
- Cada cambio mantiene el build verde.

### Commits
- Conventional Commits en inglés (`feat:`, `fix:`, `refactor:`, `chore:`, `docs:`, `test:`, `ci:`), uno por paso del checklist.
- Los cambios los revisa y commitea el mantenedor.

## Hoja de ruta

### Fase 0: documentos y base
- [x] Documentación del proyecto (`CLAUDE.md`, este archivo)
- [ ] `global.json` (SDK 10) y `Directory.Build.props`
- [ ] `Directory.Packages.props` (gestión central de paquetes) y `.editorconfig` con analizadores
- [ ] Línea base: build en `netcoreapp3.1` antes de migrar
- [ ] Inventario de paquetes: `dotnet list package --outdated`, `--deprecated` y `--vulnerable --include-transitive`; guardar el resultado como referencia
- [ ] *(a verificar)* Confirmar si `DATA` se comparte con la API como proyecto o es una copia propia del cliente; de eso depende el destino de `DATA` (`net10.0` o multi-target)

### Fase 1: plataforma y paquetes
La limpieza de paquetes va **antes** del salto de framework, para reducir la superficie de migración. Cada paso deja el build verde en `netcoreapp3.1`.
- [ ] Retirar de `ModalidadGradoSpat.csproj` los paquetes ya incluidos en el framework o solo de scaffolding: `Microsoft.AspNetCore.Http`, `Microsoft.AspNetCore.Diagnostics`, `Microsoft.CodeAnalysis.Razor`, `Microsoft.EntityFrameworkCore.Design`, `Microsoft.VisualStudio.Web.CodeGeneration.Design`, `Microsoft.Extensions.Logging.Debug`
- [ ] Retirar `Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation` y `AddRazorRuntimeCompilation()`
- [ ] *(a verificar)* Retirar `Microsoft.jQuery.Unobtrusive.Ajax` si ninguna vista ni script usa `jquery.unobtrusive-ajax` (no hay `data-ajax` ni `Ajax.BeginForm` en las vistas)
- [ ] `DATA`: sustituir `IdentityUserRole<int>` (`UserRole`) e `IdentityRole` (`Role`) por POCOs con las mismas propiedades y retirar `Microsoft.EntityFrameworkCore.SqlServer`, `Microsoft.AspNetCore.Identity.EntityFrameworkCore` y `Microsoft.AspNetCore.Http`; comprobar que la deserialización del JSON de la API no cambia
- [ ] `DATA` y cliente a `net10.0`; alinear temporalmente `JwtBearer` y `System.IdentityModel.Tokens.Jwt` a 10.x/8.x hasta la Fase 2
- [ ] Actualizar ClosedXML con el test de reportes Excel como red de seguridad; probar en el sistema operativo de despliegue (el cálculo de fuentes en `AdjustToContents` puede variar)
- [ ] Minimal hosting (`Program.cs`, eliminar `Startup.cs`); `MapStaticAssets()` y ruta única de áreas con `[Area]`
- [ ] File-scoped namespaces con `dotnet format` (commit mecánico)
- [ ] Activar `Nullable` y corregir advertencias (`DATA`, luego cliente); ver el riesgo del `[Required]` implícito

### Fase 2: configuración y autenticación
- [ ] `ApiOptions` (`Api:BaseUrl`) validada al arrancar; actualizar `appsettings.example.json`
- [ ] Autenticación por cookie; retirar `JwtBearer`, middleware de sesión (incluido el que copia el token de sesión al header `Authorization`) y `AppSettings:Token` del cliente
- [ ] Decidir cómo se obtienen los *claims*: leer el JWT sin validar o usar los datos de la respuesta del login; retirar `System.IdentityModel.Tokens.Jwt` si ya no se usa
- [ ] `LoginPath`/`AccessDeniedPath` y `LogOut` con `SignOutAsync`; vida de la cookie alineada con el `exp` del JWT
- [ ] Antiforgery global (`AutoValidateAntiforgeryTokenAttribute`) y revisión de las llamadas AJAX; Data Protection con llaves persistentes
- [ ] `UseHsts`, cabeceras de seguridad y *rate limiting* en el login
- [ ] Retirar CORS abierto

### Fase 3: capa de acceso a la API
- [ ] Opciones compartidas de `System.Text.Json` y test de contrato con JSON real de la API, antes de migrar los controladores
- [ ] Clientes tipados por área con `IHttpClientFactory` y resiliencia (`Microsoft.Extensions.Http.Resilience`, sin reintentos en métodos no idempotentes)
- [ ] `BearerTokenHandler` (`DelegatingHandler`), con manejo de `401` (cierre de sesión y redirección al login)
- [ ] `ApiResult<T>`, `ApiError` y `PagedResult<T>` (cabecera `Pagination`)
- [ ] Migrar controladores (un commit cada uno): `LoginAccount`, `Adopciones`, `Dashboard`, `Perfil`, `Cuenta`, `Graficas`, `Denuncia`, `ReporteTratamiento`, `Mascota`, `Seguimiento`, `SeguimientoAsignado`, `ReporteSeguimiento`, `Adopcion`
- [ ] Eliminar `APIConnection.cs`, RestSharp y Newtonsoft

### Fase 4: estado compartido y vistas
- [ ] Eliminar todo `static` en controladores (paginación, filtros, listas, entidades en edición)
- [ ] `IViewRenderService` y revisión de `NoDirectAccess`
- [ ] Reportes como servicios inyectables; controladores con DI por constructor

### Fase 5: errores y logging
- [ ] `ILogger<T>` y log estructurado de fallos de la API
- [ ] Manejo central de errores; reemplazar los `throw new Exception()`
- [ ] Endpoint `/health` con comprobación de la API y `UseRequestLocalization`

### Fase 6: tests, CI y documentación
- [ ] Proyecto de tests (handler, cliente, integración, reportes Excel, regresión de estado compartido)
- [ ] Workflow de CI en GitHub Actions (con auditoría de paquetes) y Dependabot
- [ ] Activar `TreatWarningsAsErrors` de forma gradual (primero `nullable`)
- [ ] README con arquitectura, configuración y decisiones técnicas

## Riesgos y notas de migración
1. **`Nullable` vuelve obligatorias las propiedades no anulables.** MVC trata las propiedades de referencia no anulables (`string`) como `[Required]` implícito, lo que puede romper formularios que hoy funcionan. Marcar `string?` donde corresponda, o fijar `SuppressImplicitRequiredAttributeForNonNullableReferenceTypes` solo mientras dure la migración.
2. **Newtonsoft → `System.Text.Json` cambia el comportamiento.** Hay referencias a Newtonsoft, `JsonProperty` o RestSharp en 14 archivos (42 apariciones). Vigilar mayúsculas y minúsculas, enums, formato de fechas, ciclos de referencia y propiedades sin *setter* público. El test de contrato lo cubre.
3. **`DATA` y la API.** Si la API referencia este mismo proyecto `DATA`, pasarlo a `net10.0` la rompe. Si es compartido, multi-targetear (`net10.0;netstandard2.1`); si es una copia, documentarlo. Cambiar la API está fuera de alcance.
4. **Salto directo de 3.1 a 10.** Son siete versiones mayores sin pasos intermedios. De ahí que cada paso exija build verde y que la limpieza de paquetes se haga antes del retarget.
5. **CSRF y sesiones al pasar a cookies.** Sin antiforgery global y sin Data Protection persistente, la migración introduce un riesgo de seguridad y cierres de sesión en cada despliegue.
6. **Reintentos y duplicados.** Reintentar un `POST` puede duplicar registros; los reintentos solo aplican a métodos idempotentes.
7. **ClosedXML.** El salto desde 0.95 trae cambios de API y de fuentes; sin test de los reportes el riesgo no se ve hasta producción.

## Fuera de alcance por ahora
- Ajuste visual de Bootstrap y cambio de framework de frontend.
- Cambios en la API.
- Reemplazar las dependencias de CDN por archivos locales y actualizar jQuery/DataTables (ciclo posterior). Es también el momento de ajustar una CSP estricta y de valorar LibMan.
- Contenedores (`dotnet publish -t:PublishContainer`), OpenTelemetry y el formato de solución `.slnx`: evaluar después de la Fase 6.
