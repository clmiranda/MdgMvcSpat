using DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.DTOs
{
    public class ReporteSeguimientoForUpdateDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaReporte { get; set; }
        public string Estado { get; set; }
        public Seguimiento Seguimiento { get; set; }
        public int? SeguimientoId { get; set; }
    }
}
