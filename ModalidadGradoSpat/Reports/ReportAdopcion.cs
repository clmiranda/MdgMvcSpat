using ClosedXML.Excel;
using DATA.Models;
using System.Collections.Generic;
using System.IO;

namespace ModalidadGradoSpat.Reports
{
    public class ReportAdopcion
    {
        public static byte[] ExcelAdopciones(IEnumerable<SolicitudAdopcion> adopciones)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Nombre Completo Adoptante";
                worksheet.Cell(currentRow, 3).Value = "Ci";
                worksheet.Cell(currentRow, 4).Value = "Domicilio";
                worksheet.Cell(currentRow, 5).Value = "Numero Celular";
                worksheet.Cell(currentRow, 6).Value = "Fecha Solicitud Adopcion";
                worksheet.Cell(currentRow, 7).Value = "Estado";
                worksheet.Cell(currentRow, 8).Value = "Respuesta Pregunta 1";
                worksheet.Cell(currentRow, 9).Value = "Respuesta Pregunta 2";
                worksheet.Cell(currentRow, 10).Value = "Respuesta Pregunta 3";
                worksheet.Cell(currentRow, 11).Value = "Respuesta Pregunta 4";
                worksheet.Cell(currentRow, 12).Value = "Respuesta Pregunta 5";
                worksheet.Cell(currentRow, 13).Value = "Respuesta Pregunta 6";
                worksheet.Cell(currentRow, 14).Value = "Respuesta Pregunta 7";
                worksheet.Cell(currentRow, 15).Value = "Id Mascota";
                worksheet.Cell(currentRow, 16).Value = "Nombre Mascota";
                foreach (var adopcion in adopciones)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.Nombres +" "+ adopcion.Apellidos;
                    worksheet.Cell(currentRow, 3).Value = adopcion.Ci;
                    worksheet.Cell(currentRow, 4).Value = adopcion.Domicilio;
                    worksheet.Cell(currentRow, 5).Value = adopcion.NumeroCelular;
                    worksheet.Cell(currentRow, 6).Value = adopcion.FechaSolicitudAdopcion;
                    worksheet.Cell(currentRow, 7).Value = adopcion.Estado;
                    worksheet.Cell(currentRow, 8).Value = adopcion.Respuesta1;
                    worksheet.Cell(currentRow, 9).Value = adopcion.Respuesta2;
                    worksheet.Cell(currentRow, 10).Value = adopcion.Respuesta3;
                    worksheet.Cell(currentRow, 11).Value = adopcion.Respuesta4;
                    worksheet.Cell(currentRow, 12).Value = adopcion.Respuesta5;
                    worksheet.Cell(currentRow, 13).Value = adopcion.Respuesta6;
                    worksheet.Cell(currentRow, 14).Value = adopcion.Respuesta7;
                    if (adopcion.Mascota == null)
                    {
                        worksheet.Cell(currentRow, 15).Value = "Sin datos";
                        worksheet.Cell(currentRow, 16).Value = "Sin datos";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 15).Value = adopcion.Mascota.Id;
                        worksheet.Cell(currentRow, 16).Value = adopcion.Mascota.Nombre;
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
        public static byte[] ExcelAdopcionesRechazadas(IEnumerable<AdopcionRechazada> adopciones)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Razon";
                worksheet.Cell(currentRow, 3).Value = "Id de Solicitud";
                foreach (var adopcion in adopciones)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.Razon;
                    if (adopcion.SolicitudAdopcion == null)
                    {
                        worksheet.Cell(currentRow, 3).Value = "Sin datos";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 3).Value = adopcion.SolicitudAdopcionId;
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
        public static byte[] ExcelAdopcionesCanceladas(IEnumerable<AdopcionCancelada> adopciones)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Razon";
                worksheet.Cell(currentRow, 3).Value = "Id de Solicitud";
                foreach (var adopcion in adopciones)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.Razon;
                    if (adopcion.SolicitudAdopcion == null)
                    {
                        worksheet.Cell(currentRow, 3).Value = "Sin datos";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 3).Value = adopcion.SolicitudAdopcionId;
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
    }
}
