using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class User: BaseEntity
    {
        [Required(ErrorMessage = "El Email es requerido.")]
        [EmailAddress(ErrorMessage ="Ingresa un correo válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El Username es requerido.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "El Password es requerido.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).{8,}$", ErrorMessage = "La contraseña no cumple con los requisitos.")]
        public string Password { set; get; }
        [MaxLength(20)]
        public string Estado { get; set; }
        public string[] Roles { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Seguimiento> Seguimientos { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}