using ClosedXML.Excel;
using DATA.Models;
using System.Collections.Generic;
using System.IO;

namespace ModalidadGradoSpat.Reports
{
    public class ReportDenuncia
    {
        public static byte[] ExcelDenuncias(IEnumerable<Denuncia> denuncias)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Denuncias");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Titulo";
                worksheet.Cell(currentRow, 3).Value = "Descripcion";
                worksheet.Cell(currentRow, 4).Value = "Nombre de Mascota";
                foreach (var denuncia in denuncias)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = denuncia.Id;
                    worksheet.Cell(currentRow, 2).Value = denuncia.Titulo;
                    worksheet.Cell(currentRow, 3).Value = denuncia.Descripcion;
                    if (denuncia.Mascota == null)
                        worksheet.Cell(currentRow, 4).Value = "No tiene mascota creada";
                    else
                        worksheet.Cell(currentRow, 4).Value = denuncia.Mascota.Nombre;
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
