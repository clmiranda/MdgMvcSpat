using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class CasoMascota: BaseEntity
    {
        [Required(ErrorMessage = "El título del caso es requerido.")]
        [StringLength(100, ErrorMessage = "El titulo no debe sobrepasar los 100 caracteres.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La descripción del caso es requerida.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La fecha de rescate es requerida.")]
        [DataType(DataType.Date,ErrorMessage ="Fecha Invalida")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime FechaRescate { get; set; }
        [Required]
        public string Estado { get; set; }
        //[Required(ErrorMessage = "Debe elegir la denuncia que corresponde al caso.")]
        public virtual Denuncia Denuncia { get; set; }
        public int DenunciaId { get; set; }
        //public virtual Denuncia Denuncia { get; set; }
        public virtual /*ICollection<*/Mascota/*>*/ Mascota { get; set; }
        //public string TituloDenuncia { get; set; }
        //public int IdMascota { get; set; }

        //public virtual Mascota Mascota { get; set; }
    }
}