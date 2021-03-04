using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA.Models
{
    public class Foto: BaseEntity
    {
        public string Url { get; set; }
        public bool IsPrincipal { get; set; }
        public string IdPublico { get; set; }
        public DateTime? FechaAgregado { get; set; }
        //public virtual User User { get; set; }
        public int? UserId { get; set; }
        //public virtual Mascota Mascota { get; set; }
        public int? MascotaId { get; set; }
        [Required(ErrorMessage = "Es necesario que incluya la foto.")]
        public IFormFile File { get; set; }
    }
}
