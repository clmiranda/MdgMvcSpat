using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class ReporteTratamiento : BaseEntity
    {
        [Required(ErrorMessage = "Debes ingresar la descripcion.")]
        [MaxLength(300)]
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
    }
}
