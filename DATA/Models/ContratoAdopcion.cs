using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class ContratoAdopcion : BaseEntity
    {
        //[Required(ErrorMessage = "Debe ingresar sus Nombres y Apellidos Completos.")]
        //public string NombreCompleto { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la direccion de su Domicilio.")]
        //public string Domicilio { get; set; }
        //[Required(ErrorMessage = "Debe ingresar su numero de Celular.")]
        //public string NumeroCelular { get; set; }
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
        public string Pregunta1 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Pregunta2 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Pregunta3 { get; set; }
        [Required(ErrorMessage = "Debe responder la pregunta.")]
        public string Pregunta4 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Pregunta5 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Pregunta6 { get; set; }
        [Required(ErrorMessage = "Debes responder la pregunta.")]
        public string Pregunta7 { get; set; }
        //[Required(ErrorMessage = "Debe completar el campo.")]
        //public string CasaPropia { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la razon por la cual quiere adoptar.")]
        //public string RazonAdopcion { get; set; }
        //[Required(ErrorMessage = "Debe ingresar su edad, debe ser mayor de 18 años para poder adoptar.")]
        //public string Edad { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debes aceptar los terminos del contrato para continuar con el proceso de adopcion.")]
        public bool TerminosCondiciones { get; set; }
        //public string Ci { get; set; }
        public DateTime FechaSolicitudAdopcion { get; set; }
        public DateTime FechaAdopcion { get; set; }
        public string RazonAdopcion { get; set; }
        public string Estado { get; set; }
        public virtual Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
        //public virtual User User { get; set; }
        //public int UserId { get; set; }
        public virtual Seguimiento Seguimiento { get; set; }
        public virtual ContratoRechazo ContratoRechazo { get; set; }
    }
}