using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class AdopcionCancelada: BaseEntity
    {
        [Required(ErrorMessage = "Necesita proporcionar la razon por la cual se esta cancelando la solicitud")]
        [MaxLength(300)]
        public string Razon { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual SolicitudAdopcion SolicitudAdopcion { get; set; }
        public int SolicitudAdopcionId { get; set; }
    }
}
