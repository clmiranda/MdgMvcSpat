using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class UserForLogin
    {
        [Required(ErrorMessage = "El campo Usuario o Correo Electrónico es obligatorio")]
        public string UsernameEmail { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
