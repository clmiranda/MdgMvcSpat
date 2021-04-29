﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class ReporteTratamiento : BaseEntity
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
    }
}