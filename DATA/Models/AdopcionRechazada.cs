using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class AdopcionRechazada : BaseEntity
    {
        [Required(ErrorMessage ="Necesita proporcionar la razon por la cual se esta rechazando la solicitud")]
        [MaxLength(300)]
        public string Razon { get; set; }
        public virtual SolicitudAdopcion SolicitudAdopcion { get; set; }
        public int SolicitudAdopcionId { get; set; }
    }
}
