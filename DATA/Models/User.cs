using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class User: BaseEntity
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "El Email es requerido.")]
        [EmailAddress(ErrorMessage ="Ingresa un correo válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El Username es requerido.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "El Password es requerido.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).{8,}$", ErrorMessage = "La contraseña no cumple con los requisitos.")]
        public string Password { set; get; }
        //[Required(ErrorMessage = "El Nombre es requerido.")]
        //public string Nombres { get; set; }
        //[Required(ErrorMessage = "Los Apellidos son requeridos.")]
        //public string Apellidos { get; set; }
        //[Required(ErrorMessage = "El Domicilio es requerido.")]
        //public string Domicilio { get; set; }
        //[Required(ErrorMessage = "El Numero de Celular es requerido.")]
        //public string NumeroCelular { get; set; }
        //[Required(ErrorMessage = "La Fecha de Nacimiento es requerida.")]
        //public DateTime FechaNacimiento { get; set; }
        //public string Edad { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }
        //[Required(ErrorMessage = "El Sexo del usuario es requerido.")]
        //public string Sexo { get; set; }
        public string[] Roles { get; set; }
        public virtual Persona Persona { get; set; }
        //public virtual int PersonaId { get; set; }
        public virtual ICollection<Seguimiento> Seguimientos { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}