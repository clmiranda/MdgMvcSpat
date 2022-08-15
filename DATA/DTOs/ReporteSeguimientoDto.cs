using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DATA.DTOs
{
    public class ReporteSeguimientoDto
    {
        public int Id { get; set; }
        public int SeguimientoId { get; set; }
        [Required(ErrorMessage = "Debe ingresar la descripción del actual reporte.")]
        [MaxLength(300)]
        [StringLength(maximumLength: 3000, MinimumLength = 20, ErrorMessage = "La descripción debe contener como mínimo 20 caracteres.")]
        public string Observaciones { get; set; }
        [Required(ErrorMessage = "Debe contener una imagen de la mascota.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(3 * 1024 * 1024)]
        public virtual IFormFile Foto { get; set; }
    }
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"El tamaño máximo permitido es { _maxFileSize / 1024 / 1024} mb.";
        }
    }
}
