using ClosedXML.Excel;
using DATA.Models;
using System.Collections.Generic;
using System.IO;

namespace ModalidadGradoSpat.Reports
{
    public class ReportUser
    {
        public static byte[] ExcelUsers(IEnumerable<User> usuarios)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Usuarios");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Nombre(s)";
                worksheet.Cell(currentRow, 3).Value = "Apellido(s)";
                worksheet.Cell(currentRow, 4).Value = "Email";
                worksheet.Cell(currentRow, 5).Value = "Username";
                worksheet.Cell(currentRow, 6).Value = "Domicilio";
                worksheet.Cell(currentRow, 7).Value = "Numero Telefono/Celular";
                worksheet.Cell(currentRow, 8).Value = "Genero";
                worksheet.Cell(currentRow, 9).Value = "Fecha Nacimiento";
                worksheet.Cell(currentRow, 10).Value = "Edad";
                worksheet.Cell(currentRow, 11).Value = "Roles";
                foreach (var usuario in usuarios)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = usuario.Id;
                    worksheet.Cell(currentRow, 2).Value = usuario.Persona.Nombres;
                    worksheet.Cell(currentRow, 3).Value = usuario.Persona.Apellidos;
                    worksheet.Cell(currentRow, 4).Value = usuario.Email;
                    worksheet.Cell(currentRow, 5).Value = usuario.UserName;
                    worksheet.Cell(currentRow, 6).Value = usuario.Persona.Domicilio;
                    worksheet.Cell(currentRow, 7).Value = usuario.Persona.Telefono;
                    worksheet.Cell(currentRow, 8).Value = usuario.Persona.Genero;
                    worksheet.Cell(currentRow, 9).Value = usuario.Persona.FechaNacimiento;
                    worksheet.Cell(currentRow, 10).Value = usuario.Persona.Edad;
                    worksheet.Cell(currentRow, 11).Value = string.Join(",", usuario.Roles);
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
