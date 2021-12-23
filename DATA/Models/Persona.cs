using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class Persona: BaseEntity
    {
        [Required(ErrorMessage = "El Nombre es requerido.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Los Apellidos son requeridos.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El Domicilio es requerido.")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "El Numero de Celular es requerido.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "La Fecha de Nacimiento es requerida.")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El Género del usuario es requerido.")]
        public string Genero { get; set; }
        public string Edad { get; set; }
        public virtual User User { get; set; }
    }
}
