using ClosedXML.Excel;
using DATA.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModalidadGradoSpat.Reports
{
    public class ReportSeguimientoReporte
    {
        public static byte[] ExcelSeguimientos(IEnumerable<Seguimiento> seguimientos)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Reportes");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Fecha Inicial";
                worksheet.Cell(currentRow, 3).Value = "Fecha Final";
                worksheet.Cell(currentRow, 4).Value = "Nº Reportes";
                worksheet.Cell(currentRow, 5).Value = "Nombre Mascota de Contrto";
                worksheet.Cell(currentRow, 6).Value = "Id Mascota";
                worksheet.Cell(currentRow, 7).Value = "Id Contrato";
                worksheet.Cell(currentRow, 8).Value = "Estado";
                worksheet.Cell(currentRow, 9).Value = "Voluntario Asignado";
                worksheet.Cell(currentRow, 10).Value = "Id Voluntario";
                foreach (var seguimiento in seguimientos)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = seguimiento.Id;
                    worksheet.Cell(currentRow, 2).Value = seguimiento.FechaInicio.ToShortDateString();
                    worksheet.Cell(currentRow, 3).Value = seguimiento.FechaConclusion.ToShortDateString();
                    worksheet.Cell(currentRow, 4).Value = seguimiento.ReporteSeguimientos.Count();
                    worksheet.Cell(currentRow, 5).Value = seguimiento.ContratoAdopcion.Mascota.Nombre;
                    worksheet.Cell(currentRow, 6).Value = seguimiento.ContratoAdopcion.Mascota.Id;
                    worksheet.Cell(currentRow, 7).Value = seguimiento.ContratoAdopcionId;
                    worksheet.Cell(currentRow, 8).Value = seguimiento.Estado;

                    if (seguimiento.User != null)
                        worksheet.Cell(currentRow, 9).Value = seguimiento.User.Nombres + " " + seguimiento.User.Apellidos;
                    else
                        worksheet.Cell(currentRow, 9).Value = "No asignado";
                    worksheet.Cell(currentRow, 10).Value = seguimiento.UserId;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return content;
                }
            }
        }

        public static byte[] ExcelReportes(IEnumerable<ReporteSeguimiento> reporteSeguimientos)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Reportes");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Estado Mascota";
                worksheet.Cell(currentRow, 3).Value = "Observaciones";
                worksheet.Cell(currentRow, 4).Value = "Fecha Reporte";
                worksheet.Cell(currentRow, 5).Value = "Estado";
                worksheet.Cell(currentRow, 6).Value = "Rango de Fechas";
                worksheet.Cell(currentRow, 7).Value = "Id Seguimiento";
                foreach (var reporte in reporteSeguimientos)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = reporte.Id;
                    worksheet.Cell(currentRow, 2).Value = reporte.EstadoHogarMascota;
                    worksheet.Cell(currentRow, 3).Value = reporte.Observaciones;
                    worksheet.Cell(currentRow, 4).Value = reporte.Fecha;
                    worksheet.Cell(currentRow, 5).Value = reporte.Estado;
                    worksheet.Cell(currentRow, 6).Value = reporte.Seguimiento.FechaInicio.ToShortDateString() + " hasta " + reporte.Seguimiento.FechaConclusion.ToShortDateString();
                    worksheet.Cell(currentRow, 7).Value = reporte.SeguimientoId;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return content;
                }
            }
        }
    }
}
