using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class Foto: BaseEntity
    {
        public string Url { get; set; }
        public bool IsPrincipal { get; set; }
        public string IdPublico { get; set; }
        public DateTime? FechaAgregado { get; set; }
        public int? UserId { get; set; }
        public int? MascotaId { get; set; }
        [Required(ErrorMessage = "Es necesario que incluya la foto.")]
        public IFormFile File { get; set; }
    }
}
