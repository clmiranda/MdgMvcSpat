using ClosedXML.Excel;
using DATA.Models;
using ModalidadGradoSpat.Reports;

namespace ModalidadGradoSpat.Tests.Reports;

/// <summary>
/// Red de seguridad para la actualización de ClosedXML: cada reporte se genera, se reabre
/// desde los bytes y se comprueban hoja, cabeceras y valores. Solo se usa API que existe tanto
/// en ClosedXML 0.95 como en 0.10x (<c>GetString</c>, <c>GetValue</c>, <c>GetDateTime</c>), para que
/// los mismos tests valgan antes y después del salto.
/// </summary>
public class ReportsTests
{
    private static readonly DateTime Inicio = new(2026, 3, 1);
    private static readonly DateTime Fin = new(2026, 3, 31);

    private static XLWorkbook Open(byte[] content) => new(new MemoryStream(content));

    private static string[] Headers(IXLWorksheet sheet, int columns) =>
        [.. Enumerable.Range(1, columns).Select(c => sheet.Cell(1, c).GetString())];

    private static Mascota NuevaMascota(int id = 1, Denuncia? denuncia = null) => new()
    {
        Id = id,
        Nombre = "Firulais",
        Sexo = "Macho",
        Especie = "Perro",
        Caracteristicas = "Pelaje café",
        RasgosParticulares = "Mancha blanca",
        Tamano = "Mediano",
        Edad = "2 años",
        Estado = "Disponible",
        FechaCreacion = Inicio,
        Denuncia = denuncia,
    };

    [Fact]
    public void ExcelMascotas_con_y_sin_denuncia()
    {
        var conDenuncia = NuevaMascota(1, new Denuncia { Id = 7, Titulo = "Perro abandonado" });
        var sinDenuncia = NuevaMascota(2);

        using var workbook = Open(ReportMascota.ExcelMascotas([conDenuncia, sinDenuncia]));
        var sheet = workbook.Worksheet(1);

        Assert.Equal("Mascotas", sheet.Name);
        Assert.Equal(3, sheet.LastRowUsed()!.RowNumber());
        Assert.Equal(
            ["Id", "Nombre", "Sexo", "Especie", "Caracteristicas", "Rasgos Particulares", "Tamaño", "Edad", "Estado", "Fecha de Registro", "Id Denuncia", "Titulo Denuncia"],
            Headers(sheet, 12));

        Assert.Equal(1, sheet.Cell(2, 1).GetValue<int>());
        Assert.Equal("Firulais", sheet.Cell(2, 2).GetString());
        Assert.Equal("Mediano", sheet.Cell(2, 7).GetString());
        Assert.Equal(Inicio, sheet.Cell(2, 10).GetDateTime().Date);
        Assert.Equal(7, sheet.Cell(2, 11).GetValue<int>());
        Assert.Equal("Perro abandonado", sheet.Cell(2, 12).GetString());

        Assert.Equal("No tiene denuncia creada.", sheet.Cell(3, 11).GetString());
        Assert.Equal("No tiene denuncia creada.", sheet.Cell(3, 12).GetString());
    }

    [Fact]
    public void ExcelDenuncias_con_y_sin_mascota()
    {
        var denuncias = new[]
        {
            new Denuncia { Id = 1, Titulo = "Maltrato", Descripcion = "Descripción larga", Mascota = new Mascota { Nombre = "Luna" } },
            new Denuncia { Id = 2, Titulo = "Abandono", Descripcion = "Otra descripción" },
        };

        using var workbook = Open(ReportDenuncia.ExcelDenuncias(denuncias));
        var sheet = workbook.Worksheet(1);

        Assert.Equal("Denuncias", sheet.Name);
        Assert.Equal(3, sheet.LastRowUsed()!.RowNumber());
        Assert.Equal(["Id", "Titulo", "Descripcion", "Nombre de Mascota"], Headers(sheet, 4));
        Assert.Equal("Maltrato", sheet.Cell(2, 2).GetString());
        Assert.Equal("Descripción larga", sheet.Cell(2, 3).GetString());
        Assert.Equal("Luna", sheet.Cell(2, 4).GetString());
        Assert.Equal("No tiene mascota creada", sheet.Cell(3, 4).GetString());
    }

    [Fact]
    public void ExcelUsers_incluye_persona_y_roles()
    {
        var user = new User
        {
            Id = 5,
            Email = "ana@example.com",
            UserName = "ana",
            Roles = ["Admin", "Voluntario"],
            Persona = new Persona
            {
                Nombres = "Ana María",
                Apellidos = "Pérez",
                Domicilio = "Calle 1 #23",
                Telefono = "70000000",
                Genero = "Femenino",
                FechaNacimiento = new DateTime(1990, 5, 17),
                Edad = "36",
            },
        };

        using var workbook = Open(ReportUser.ExcelUsers([user]));
        var sheet = workbook.Worksheet(1);

        Assert.Equal("Usuarios", sheet.Name);
        Assert.Equal(
            ["Id", "Nombre(s)", "Apellido(s)", "Email", "Username", "Domicilio", "Numero Telefono/Celular", "Genero", "Fecha Nacimiento", "Edad", "Roles"],
            Headers(sheet, 11));
        Assert.Equal(5, sheet.Cell(2, 1).GetValue<int>());
        Assert.Equal("Ana María", sheet.Cell(2, 2).GetString());
        Assert.Equal("Pérez", sheet.Cell(2, 3).GetString());
        Assert.Equal("ana@example.com", sheet.Cell(2, 4).GetString());
        Assert.Equal("70000000", sheet.Cell(2, 7).GetString());
        Assert.Equal(new DateTime(1990, 5, 17), sheet.Cell(2, 9).GetDateTime());
        Assert.Equal("Admin,Voluntario", sheet.Cell(2, 11).GetString());
    }

    [Fact]
    public void ExcelAdopciones_con_y_sin_mascota()
    {
        var solicitudes = new[]
        {
            new SolicitudAdopcion
            {
                Id = 1, NombreCompleto = "Juan Gómez", Domicilio = "Av. Central 5", Telefono = "71111111",
                FechaSolicitudAdopcion = Inicio, Estado = "Aprobada",
                Mascota = new Mascota { Id = 9, Nombre = "Rex" },
            },
            new SolicitudAdopcion { Id = 2, NombreCompleto = "Sin Mascota", FechaSolicitudAdopcion = Fin, Estado = "Pendiente" },
        };

        using var workbook = Open(ReportAdopcion.ExcelAdopciones(solicitudes));
        var sheet = workbook.Worksheet(1);

        Assert.Equal("Adopciones", sheet.Name);
        Assert.Equal(3, sheet.LastRowUsed()!.RowNumber());
        Assert.Equal(
            ["Id", "Nombre Completo Adoptante", "Domicilio", "Numero Telefono/Celular", "Fecha Solicitud Adopcion", "Estado", "Id Mascota", "Nombre Mascota"],
            Headers(sheet, 8));
        Assert.Equal("Juan Gómez", sheet.Cell(2, 2).GetString());
        Assert.Equal(Inicio, sheet.Cell(2, 5).GetDateTime());
        Assert.Equal(9, sheet.Cell(2, 7).GetValue<int>());
        Assert.Equal("Rex", sheet.Cell(2, 8).GetString());
        Assert.Equal("Sin datos", sheet.Cell(3, 7).GetString());
        Assert.Equal("Sin datos", sheet.Cell(3, 8).GetString());
    }

    [Fact]
    public void ExcelAdopcionesRechazadas_escribe_razon()
    {
        using var workbook = Open(ReportAdopcion.ExcelAdopcionesRechazadas([new AdopcionRechazada { Id = 3, Razon = "Sin espacio" }]));
        var sheet = workbook.Worksheet(1);

        Assert.Equal(["Id", "Razon de Rechazo"], Headers(sheet, 2));
        Assert.Equal(3, sheet.Cell(2, 1).GetValue<int>());
        Assert.Equal("Sin espacio", sheet.Cell(2, 2).GetString());
    }

    [Fact]
    public void ExcelAdopcionesCanceladas_escribe_razon()
    {
        using var workbook = Open(ReportAdopcion.ExcelAdopcionesCanceladas([new AdopcionCancelada { Id = 4, Razon = "Desistió" }]));
        var sheet = workbook.Worksheet(1);

        Assert.Equal(["Id", "Razon de Cancelacion"], Headers(sheet, 2));
        Assert.Equal(4, sheet.Cell(2, 1).GetValue<int>());
        Assert.Equal("Desistió", sheet.Cell(2, 2).GetString());
    }

    [Fact]
    public void ExcelSeguimientos_con_y_sin_voluntario()
    {
        var solicitud = new SolicitudAdopcion { Id = 20, Mascota = new Mascota { Id = 9, Nombre = "Rex" } };
        var asignado = new Seguimiento
        {
            Id = 1, FechaInicio = Inicio, FechaFin = Fin, Estado = "Activo",
            SolicitudAdopcion = solicitud, SolicitudAdopcionId = 20,
            ReporteSeguimientos = [new ReporteSeguimiento(), new ReporteSeguimiento()],
            User = new User { Persona = new Persona { Nombres = "Luis", Apellidos = "Rojas" } }, UserId = 5,
        };
        var sinAsignar = new Seguimiento
        {
            Id = 2, FechaInicio = Inicio, FechaFin = Fin, Estado = "Pendiente",
            SolicitudAdopcion = solicitud, SolicitudAdopcionId = 20, ReporteSeguimientos = [],
        };

        using var workbook = Open(ReportSeguimientoReporte.ExcelSeguimientos([asignado, sinAsignar]));
        var sheet = workbook.Worksheet(1);

        Assert.Equal("Reportes", sheet.Name);
        Assert.Equal(
            ["Id", "Fecha Inicial", "Fecha Final", "Nº Reportes", "Nombre Mascota de Contrto", "Id Mascota", "Id Contrato", "Estado", "Voluntario Asignado", "Id Voluntario"],
            Headers(sheet, 10));
        Assert.Equal(Inicio, sheet.Cell(2, 2).GetDateTime().Date);
        Assert.Equal(Fin, sheet.Cell(2, 3).GetDateTime().Date);
        Assert.Equal(2, sheet.Cell(2, 4).GetValue<int>());
        Assert.Equal("Rex", sheet.Cell(2, 5).GetString());
        Assert.Equal(20, sheet.Cell(2, 7).GetValue<int>());
        Assert.Equal("Luis Rojas", sheet.Cell(2, 9).GetString());
        Assert.Equal(5, sheet.Cell(2, 10).GetValue<int>());
        Assert.Equal(0, sheet.Cell(3, 4).GetValue<int>());
        Assert.Equal("No asignado", sheet.Cell(3, 9).GetString());
    }

    [Fact]
    public void ExcelReportes_escribe_rango_de_fechas()
    {
        var reporte = new ReporteSeguimiento
        {
            Id = 8, Observaciones = "La mascota está en buen estado.", FechaReporte = new DateTime(2026, 3, 15),
            Estado = "Revisado", SeguimientoId = 1,
            Seguimiento = new Seguimiento { FechaInicio = Inicio, FechaFin = Fin },
        };

        using var workbook = Open(ReportSeguimientoReporte.ExcelReportes([reporte]));
        var sheet = workbook.Worksheet(1);

        Assert.Equal("Reportes", sheet.Name);
        Assert.Equal(
            ["Id", "Estado Mascota", "Observaciones", "Fecha Reporte", "Estado", "Rango de Fechas", "Id Seguimiento"],
            Headers(sheet, 7));
        Assert.Equal(8, sheet.Cell(2, 1).GetValue<int>());
        Assert.Equal("La mascota está en buen estado.", sheet.Cell(2, 3).GetString());
        Assert.Equal(new DateTime(2026, 3, 15), sheet.Cell(2, 4).GetDateTime());
        Assert.Equal("Revisado", sheet.Cell(2, 5).GetString());
        Assert.Equal($"{Inicio.ToShortDateString()} hasta {Fin.ToShortDateString()}", sheet.Cell(2, 6).GetString());
        Assert.Equal(1, sheet.Cell(2, 7).GetValue<int>());
    }

    /// <summary>
    /// Las fechas deben quedar como celdas de fecha (ordenables y filtrables en Excel), no como texto.
    /// Antes se escribían con <c>ToShortDateString()</c> y ClosedXML 0.95 convertía la cadena en fecha;
    /// desde 0.10x la deja como texto, por lo que los reportes escriben el <see cref="DateTime"/> directamente.
    /// </summary>
    [Fact]
    public void Fechas_se_guardan_como_celdas_de_fecha()
    {
        var seguimiento = new Seguimiento
        {
            Id = 1, FechaInicio = Inicio, FechaFin = Fin, Estado = "Activo",
            SolicitudAdopcion = new SolicitudAdopcion { Mascota = new Mascota() }, ReporteSeguimientos = [],
        };

        using var seguimientos = Open(ReportSeguimientoReporte.ExcelSeguimientos([seguimiento]));
        using var mascotas = Open(ReportMascota.ExcelMascotas([NuevaMascota()]));

        Assert.Equal(XLDataType.DateTime, seguimientos.Worksheet(1).Cell(2, 2).DataType);
        Assert.Equal(XLDataType.DateTime, seguimientos.Worksheet(1).Cell(2, 3).DataType);
        Assert.Equal(XLDataType.DateTime, mascotas.Worksheet(1).Cell(2, 10).DataType);
    }

    [Fact]
    public void Reportes_sin_datos_generan_solo_la_cabecera()
    {
        using var workbook = Open(ReportMascota.ExcelMascotas([]));

        Assert.Equal(1, workbook.Worksheet(1).LastRowUsed()!.RowNumber());
    }

    [Fact]
    public void Reportes_generan_un_xlsx_valido()
    {
        var content = ReportDenuncia.ExcelDenuncias([new Denuncia { Id = 1, Titulo = "T", Descripcion = "D" }]);

        // Un .xlsx es un ZIP: empieza por "PK".
        Assert.True(content.Length > 0);
        Assert.Equal((byte)'P', content[0]);
        Assert.Equal((byte)'K', content[1]);
    }
}
