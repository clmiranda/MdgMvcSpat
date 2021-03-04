using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.DTOs
{
    public class FotoForCreationDto
    {
        public string Url { get; set; }
        public bool? IsPrincipal { get; set; }
        //Mismo Name 'File' en el input de la vista
        public IFormFile File { get; set; }
        public DateTime FechaAgregado { get; set; }
        public string IdPublico { get; set; }
        public int? UserId { get; set; }
        public int? MascotaId { get; set; }
    }
}
