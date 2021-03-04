using System;
using System.Collections.Generic;

namespace DATA.Models
{
    public partial class Notificacion : BaseEntity
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
