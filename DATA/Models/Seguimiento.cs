using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class Seguimiento : BaseEntity
    {
        [Required(ErrorMessage = "Debe establecer el rango de fechas del Seguimiento.")]
        public string[] RangoFechas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual SolicitudAdopcion SolicitudAdopcion { get; set; }
        public int SolicitudAdopcionId { get; set; }
        public virtual List<ReporteSeguimiento> ReporteSeguimientos { get; set; }
    }
}