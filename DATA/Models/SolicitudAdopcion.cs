using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class SolicitudAdopcion : BaseEntity
    {
        [Required(ErrorMessage = "Debes ingresar tus Nombres.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Debes ingresar tus Apellidos.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Debes ingresar tu Carnet de Identidad.")]
        public string Ci { get; set; }
        [Required(ErrorMessage = "Debes ingresar tu Domicilio.")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "Para ponernos en contacto contigo, debes proporcionar tu numero de Telefono/Celular")]
        public string NumeroCelular { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Respuesta1 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Respuesta2 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Respuesta3 { get; set; }
        [Required(ErrorMessage = "Debe responder la pregunta.")]
        public string Respuesta4 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Respuesta5 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Respuesta6 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Respuesta7 { get; set; }
        public DateTime FechaSolicitudAdopcion { get; set; }
        public DateTime FechaAdopcion { get; set; }
        public string RazonAdopcion { get; set; }
        public string Estado { get; set; }
        public virtual Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
        public virtual Seguimiento Seguimiento { get; set; }
        public virtual AdopcionRechazada AdopcionRechazada { get; set; }
        public virtual AdopcionCancelada AdopcionCancelada { get; set; }
    }
}