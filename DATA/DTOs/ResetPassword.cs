using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATA.DTOs
{
    public class ResetPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="La nueva contraseña es requerida.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{8,}$",ErrorMessage ="La contraseña no cumple con los requisitos.")]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage ="Debe confirmar la contraseña.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; }
        //[Required]
        //public string Token { get; set; }
    }
}
