using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class FileContratoAdopcion
    {
        [Required]
        public IFormFile Archivo { get; set; }
    }
}
