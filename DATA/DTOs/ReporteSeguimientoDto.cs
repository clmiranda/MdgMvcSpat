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
        public virtual IFormFile Foto { get; set; }
    }
}
