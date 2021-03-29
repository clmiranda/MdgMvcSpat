using ClosedXML.Excel;
using DATA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ModalidadGradoSpat.Reports
{
    public class ReportAdopcion
    {
        public static byte[] ExcelAdopciones(IEnumerable<ContratoAdopcion> adopciones)
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
                    worksheet.Cell(currentRow, 8).Value = adopcion.Pregunta1;
                    worksheet.Cell(currentRow, 9).Value = adopcion.Pregunta2;
                    worksheet.Cell(currentRow, 10).Value = adopcion.Pregunta3;
                    worksheet.Cell(currentRow, 11).Value = adopcion.Pregunta4;
                    worksheet.Cell(currentRow, 12).Value = adopcion.Pregunta5;
                    worksheet.Cell(currentRow, 13).Value = adopcion.Pregunta6;
                    worksheet.Cell(currentRow, 14).Value = adopcion.Pregunta7;
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
        public static byte[] ExcelAdopcionesRechazadas(IEnumerable<ContratoRechazo> adopciones)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Adopciones");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Razon de Rechazo/Cancelacion";
                worksheet.Cell(currentRow, 3).Value = "Id de Contrato";
                foreach (var adopcion in adopciones)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = adopcion.Id;
                    worksheet.Cell(currentRow, 2).Value = adopcion.RazonRechazo;
                    if (adopcion.ContratoAdopcion == null)
                    {
                        worksheet.Cell(currentRow, 3).Value = "Sin datos";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 3).Value = adopcion.ContratoAdopcionId;
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
