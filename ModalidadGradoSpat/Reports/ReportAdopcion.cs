using ClosedXML.Excel;
using DATA.Models;
using System.Collections.Generic;
using System.IO;

namespace ModalidadGradoSpat.Reports
{
    public class ReportAdopcion
    {
        public static byte[] ExcelAdopciones(IEnumerable<SolicitudAdopcion> adopcionesAprobadas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Nombre Completo Adoptante";
                worksheet.Cell(currentRow, 3).Value = "Domicilio";
                worksheet.Cell(currentRow, 4).Value = "Numero Telefono/Celular";
                worksheet.Cell(currentRow, 5).Value = "Fecha Solicitud Adopcion";
                worksheet.Cell(currentRow, 6).Value = "Estado";
                worksheet.Cell(currentRow, 7).Value = "Id Mascota";
                worksheet.Cell(currentRow, 8).Value = "Nombre Mascota";
                foreach (var adopcion in adopcionesAprobadas)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.NombreCompleto;
                    worksheet.Cell(currentRow, 3).Value = adopcion.Domicilio;
                    worksheet.Cell(currentRow, 4).Value = adopcion.Telefono;
                    worksheet.Cell(currentRow, 5).Value = adopcion.FechaSolicitudAdopcion;
                    worksheet.Cell(currentRow, 6).Value = adopcion.Estado;
                    if (adopcion.Mascota == null)
                    {
                        worksheet.Cell(currentRow, 7).Value = "Sin datos";
                        worksheet.Cell(currentRow, 8).Value = "Sin datos";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 7).Value = adopcion.Mascota.Id;
                        worksheet.Cell(currentRow, 8).Value = adopcion.Mascota.Nombre;
                    }
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return content;
                }
            }
        }
        public static byte[] ExcelAdopcionesRechazadas(IEnumerable<AdopcionRechazada> adopcionesRechazadas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Razon de Rechazo";
                foreach (var adopcion in adopcionesRechazadas)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.Razon;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return content;
                }
            }
        }
        public static byte[] ExcelAdopcionesCanceladas(IEnumerable<AdopcionCancelada> adopcionesCanceladas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Razon de Cancelacion";
                foreach (var adopcion in adopcionesCanceladas)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.Razon;
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
