# MdgMvcSpat

Cliente web ASP.NET Core MVC de la aplicación para SPAT (gestión de mascotas, denuncias, adopciones y seguimientos a mascotas adoptadas).
No tiene comunicación directa con la base de datos: consume la **ModalidadWebAPI** por HTTP y renderiza las vistas con la data proporcionada.ç
Está en proceso de modernización a .NET 10.

@docs/MODERNIZATION.md

## Estructura
- `ModalidadGradoSpat/`: aplicación MVC.
  - `Controllers/`: públicos (inicio de adopciones, login, errores).
  - `Areas/Administracion*/`: paneles por área (Mascotas, Adopciones, Cuentas, Datos, Seguimientos), con sus controladores y vistas.
  - `Reports/`: generación de Excel con ClosedXML.
  - `wwwroot/`: estáticos (CSS, JS, plugins).
- `DATA/`: modelos y DTOs compartidos con la API.
- `docs/MODERNIZATION.md`: estándares de código y checklist de la modernización.

## Comandos
```bash
dotnet restore ModalidadGradoSpat.sln
dotnet build ModalidadGradoSpat.sln
dotnet test                       # cuando exista el proyecto de tests
dotnet run --project ModalidadGradoSpat
```

## Configuración local
- Copiar `ModalidadGradoSpat/appsettings.example.json` a `appsettings.json` y rellenar los valores.
- `appsettings.json` está en `.gitignore`. **Nunca** se versiona ni se imprime su contenido.
- La clave de firma del JWT debe coincidir con la de la API (mínimo 64 caracteres ASCII).

## Reglas de trabajo
- Responder y documentar en español; identificadores de código y términos técnicos en su forma original.
- Los commits son **Conventional Commits en inglés**, uno por paso del checklist de `docs/MODERNIZATION.md`.
- **Los cambios los revisa y commitea el mantenedor.** El asistente modifica archivos, deja el árbol listo y sugiere el mensaje de commit; no ejecuta `git add`, `git commit` ni `git push`, y no añade trailers de co-autoría.
- Cada paso debe dejar `dotnet build` en verde.
- Al terminar un paso, marcar su casilla en `docs/MODERNIZATION.md`.

## Seguridad
- No versionar secretos: claves JWT, cadenas de conexión, `appsettings.json`, `*.user`, `bin/`, `obj/`, `.vs/`.
- No registrar tokens, contraseñas ni datos personales en logs ni en mensajes de error.
- Antes de cada commit, revisar con `git status` y `git diff --staged` que no se cuele ningún secreto o key.
- Los metadatos de commits usan la identidad pública de GitHub del mantenedor; no incluir nombres reales ni correos institucionales, solo los configurados para Git.

## Convenciones de código
Ver "Estándares de código" en `docs/MODERNIZATION.md`.
Resumen: .NET 10, `Nullable`, *file-scoped namespaces*, minimal hosting, DI por constructor, clientes HTTP tipados con `IHttpClientFactory`, `System.Text.Json`, cero estado `static` en controladores, `ILogger<T>`, gestión central de paquetes (`Directory.Packages.props`) y antiforgery global al pasar a cookies.
