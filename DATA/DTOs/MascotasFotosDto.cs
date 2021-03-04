using DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.DTOs
{
    public class MascotasFotosDto
    {
        public virtual Mascota Mascota { get; set; }
        public virtual IEnumerable<Foto> Fotos { get; set; }
    }
}
