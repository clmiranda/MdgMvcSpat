using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA.DTOs
{
    public class UserForLogin
    {
        //[BindProperty]
        //public InputModel Input { get; set; }
        //[TempData]
        //public string ErrorMessage { get; set; }
        //public class InputModel {
        [Required(ErrorMessage = "El campo Usuario es obligatorio")]
        //[Display(Name = "Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string Password { get; set; }
        //}
    }
}
