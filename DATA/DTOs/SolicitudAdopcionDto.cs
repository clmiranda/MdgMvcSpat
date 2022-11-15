using DATA.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class SolicitudAdopcionDto
    {
        [Required(ErrorMessage = "Debe ingresar su nombre completo.")]
        [MaxLength(300)]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "Debe ingresar su domicilio.")]
        [MaxLength(200)]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "Para ponernos en contacto con usted, debe ingresar su número de teléfono/celular")]
        [MaxLength(20)]
        public string Telefono { get; set; }
        public DateTime FechaSolicitudAdopcion { get; set; }
        public DateTime FechaAdopcion { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }
        public virtual Mascota Mascota { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar la mascota a adoptar.")]
        public int MascotaId { get; set; }
        public virtual Seguimiento Seguimiento { get; set; }
        public virtual AdopcionRechazada AdopcionRechazada { get; set; }
        public virtual AdopcionCancelada AdopcionCancelada { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe marcar la opción para indicar que está de acuerdo.")]
        public bool Check1 { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe marcar la opción para indicar que está de acuerdo.")]
        public bool Check2 { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe marcar la opción para indicar que está de acuerdo.")]
        public bool Check3 { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe marcar la opción para indicar que está de acuerdo.")]
        public bool Check4 { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe marcar la opción para indicar que está de acuerdo.")]
        public bool Check5 { get; set; }
    }
}
