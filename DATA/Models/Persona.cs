using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public class Persona: BaseEntity
    {
        [Required(ErrorMessage = "El Nombre es requerido.")]
        [MaxLength(100)]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Los Apellidos son requeridos.")]
        [MaxLength(200)]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El Domicilio es requerido.")]
        [MaxLength(200)]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "El Numero de Celular es requerido.")]
        [MaxLength(20)]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "La Fecha de Nacimiento es requerida.")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El Género del usuario es requerido.")]
        [MaxLength(20)]
        public string Genero { get; set; }
        public string Edad { get; set; }
        public virtual User User { get; set; }
    }
}
