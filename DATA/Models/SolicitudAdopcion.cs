using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class SolicitudAdopcion : BaseEntity
    {
        [Required(ErrorMessage = "Debes ingresar tus Nombres.")]
        [MaxLength(300)]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "Debes ingresar tu Domicilio.")]
        [MaxLength(200)]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "Para ponernos en contacto contigo, debes proporcionar tu numero de Telefono/Celular")]
        [MaxLength(20)]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta1 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta2 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta3 { get; set; }
        [Required(ErrorMessage = "Debe responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta4 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta5 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta6 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        [MaxLength(300)]
        public string Respuesta7 { get; set; }
        public DateTime FechaSolicitudAdopcion { get; set; }
        public DateTime FechaAdopcion { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }
        public virtual Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
        public virtual Seguimiento Seguimiento { get; set; }
        public virtual AdopcionRechazada AdopcionRechazada { get; set; }
        public virtual AdopcionCancelada AdopcionCancelada { get; set; }
    }
}