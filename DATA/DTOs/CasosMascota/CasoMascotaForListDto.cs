using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA.DTOs.CasosMascota
{
    public class CasoMascotaForListDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El título del caso es requerido.")]
        [StringLength(100, ErrorMessage = "El titulo no debe sobrepasar los 100 caracteres.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La descripción del caso es requerida.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La fecha de rescate es requerida.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime FechaRescate { get; set; }
        public string TituloDenuncia { get; set; }
    }
}
