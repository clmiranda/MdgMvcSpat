using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class AdopcionRechazada : BaseEntity
    {
        [Required(ErrorMessage ="Necesita proporcionar la razon por la cual se esta Rechazando/Cancelando la Solicitud")]
        public string Razon { get; set; }
        public virtual SolicitudAdopcion SolicitudAdopcion { get; set; }
        public int SolicitudAdopcionId { get; set; }
    }
}
