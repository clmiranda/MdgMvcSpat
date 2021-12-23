using ClosedXML.Excel;
using DATA.Models;
using System.Collections.Generic;
using System.IO;

namespace ModalidadGradoSpat.Reports
{
    public class ReportMascota
    {
        public static byte[] ExcelMascotas(IEnumerable<Mascota> mascotas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Mascotas");
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Nombre";
                worksheet.Cell(currentRow, 3).Value = "Sexo";
                worksheet.Cell(currentRow, 4).Value = "Especie";
                worksheet.Cell(currentRow, 5).Value = "Caracteristicas";
                worksheet.Cell(currentRow, 6).Value = "Rasgos Particulares";
                worksheet.Cell(currentRow, 7).Value = "Tamaño";
                worksheet.Cell(currentRow, 8).Value = "Edad";
                worksheet.Cell(currentRow, 9).Value = "Estado";
                worksheet.Cell(currentRow, 10).Value = "Fecha de Registro";
                worksheet.Cell(currentRow, 11).Value = "Id Denuncia";
                worksheet.Cell(currentRow, 12).Value = "Titulo Denuncia";
                foreach (var mascota in mascotas)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = mascota.Id;
                    worksheet.Cell(currentRow, 2).Value = mascota.Nombre;
                    worksheet.Cell(currentRow, 3).Value = mascota.Sexo;
                    worksheet.Cell(currentRow, 4).Value = mascota.Especie;
                    worksheet.Cell(currentRow, 5).Value = mascota.Caracteristicas;
                    worksheet.Cell(currentRow, 6).Value = mascota.RasgosParticulares;
                    worksheet.Cell(currentRow, 7).Value = mascota.Tamano;
                    worksheet.Cell(currentRow, 8).Value = mascota.Edad;
                    worksheet.Cell(currentRow, 9).Value = mascota.Estado;
                    worksheet.Cell(currentRow, 10).Value = mascota.FechaCreacion.ToShortDateString();
                    if (mascota.Denuncia == null)
                    {
                        worksheet.Cell(currentRow, 11).Value = "No tiene denuncia creada.";
                        worksheet.Cell(currentRow, 12).Value = "No tiene denuncia creada.";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 11).Value = mascota.Denuncia.Id;
                        worksheet.Cell(currentRow, 12).Value = mascota.Denuncia.Titulo;
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
