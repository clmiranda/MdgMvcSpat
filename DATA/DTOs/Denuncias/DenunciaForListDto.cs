using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.DTOs.Denuncias
{
    public class DenunciaForListDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool isCasoMascota { get; set; }
    }
}
