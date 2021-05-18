using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class ForgotPassword
    {
        [Required(ErrorMessage ="El correo es requerido.")]
        [EmailAddress(ErrorMessage ="Ingrese un Email válido.")]
        public string Email { get; set; }
    }
}
