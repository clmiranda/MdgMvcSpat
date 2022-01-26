using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class ReporteSeguimiento : BaseEntity
    {
        [Required(ErrorMessage = "Debe ingresar la descripción del actual reporte.")]
        [MaxLength(300)]
        [StringLength(maximumLength: 3000, MinimumLength = 20, ErrorMessage = "La descripción debe contener como mínimo 20 caracteres.")]
        public string Observaciones { get; set; }
        public DateTime FechaReporte { get; set; }
        public DateTime FechaCreacion { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }
        public virtual Seguimiento Seguimiento { get; set; }
        public int SeguimientoId { get; set; }
        [Required(ErrorMessage = "Debe contener una imagen de la mascota.")]
        [DataType(DataType.Upload)]
        public virtual Foto Foto { get; set; }
    }
}
