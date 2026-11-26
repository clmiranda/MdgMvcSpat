using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace DATA.DTOs;

public class FileContratoAdopcion
{
    [Required]
    public IFormFile Archivo { get; set; }
}
