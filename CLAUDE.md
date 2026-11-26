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
dotnet test --solution ModalidadGradoSpat.sln   # runner Microsoft.Testing.Platform (global.json)
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

## Flujo de ramas
- La Fase 0 está en `main`. **Desde la Fase 1, cada fase vive en su propia rama** (`phase-<n>-<tema>`, p. ej. `phase-1-platform`) y se integra en `main` con un PR que abre y fusiona el mantenedor.
- El mantenedor crea la rama antes de empezar cada fase. El asistente comprueba con `git branch --show-current` que no está en `main` antes de modificar archivos y, si lo está, avisa y se detiene.
- Se mantiene un commit por paso del checklist dentro de la rama. El PR se fusiona con *merge commit* o *rebase*, **no con squash**, para conservar esos commits.
- **Excepción:** los cambios en archivos `.md` y cualquier cambio sin relación con la fase en curso se commitean directamente en `main`, no en la rama de la fase. Si el asistente modifica un `.md` estando en una rama de fase, lo avisa para que el mantenedor lo lleve a `main` (por ejemplo con `git stash` y `git switch main`) y no se mezcle con los commits de la fase.
- El PR no incluye secretos ni el inventario de vulnerabilidades; se aplica la misma revisión de la sección "Seguridad".
- El asistente no crea ramas, PRs ni hace push. Al terminar un paso sugiere el mensaje de commit; al terminar la fase, sugiere el título y la descripción del PR.

## Seguridad
- No versionar secretos: claves JWT, cadenas de conexión, `appsettings.json`, `*.user`, `bin/`, `obj/`, `.vs/`.
- No registrar tokens, contraseñas ni datos personales en logs ni en mensajes de error.
- Antes de cada commit, revisar con `git status` y `git diff --staged` que no se cuele ningún secreto o key.
- Los metadatos de commits usan la identidad pública de GitHub del mantenedor; no incluir nombres reales ni correos institucionales, solo los configurados para Git.

## Convenciones de código
Ver "Estándares de código" en `docs/MODERNIZATION.md`.
Resumen: .NET 10, `Nullable`, *file-scoped namespaces*, minimal hosting, DI por constructor, clientes HTTP tipados con `IHttpClientFactory`, `System.Text.Json`, cero estado `static` en controladores, `ILogger<T>`, gestión central de paquetes (`Directory.Packages.props`) y antiforgery global al pasar a cookies.
