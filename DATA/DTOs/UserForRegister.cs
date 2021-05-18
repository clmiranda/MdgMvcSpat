using System;
using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class UserForRegister
    {
        [Required(ErrorMessage ="El campo Correo Electrónico es obligatorio.")]
        [StringLength(100)]
        public string Email { set; get; }
        [Required(ErrorMessage = "El campo Usuario es obligatorio.")]
        public string Username { set; get; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Su Contraseña de tener entre 4 y 8 caracteres.")]
        public string Password { set; get; }
        [Required(ErrorMessage = "Debe confirmar la contraseña.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El campo Domicilio es obligatorio, lo usaremos para las adopciones.")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "El Numero de Celular es obligatorio, lo usaremos para comunicarnos con usted.")]
        public string NumeroCelular { get; set; }
        [Required(ErrorMessage = "El campo Edad es requerido.")]
        [Range(18,100,ErrorMessage ="Debe ser mayor de edad para adoptar.")]
        public string Edad { get; set; }
        public string Estado { get; set; }
        [Required(ErrorMessage = "Debe Seleccionar su Sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "La Fecha de Nacimiento es requerida.")]
        public DateTime FechaNacimiento { get; set; }
    }
}
