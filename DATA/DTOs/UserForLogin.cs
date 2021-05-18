using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class UserForLogin
    {
        [Required(ErrorMessage = "El campo Usuario es obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
