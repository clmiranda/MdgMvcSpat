using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class Denuncia : BaseEntity
    {
        //public Denuncia()
        //{
        //    CasoMascotas = new HashSet<CasoMascota>();
        //}
        [Required(ErrorMessage = "El título de la denuncia es requerida.")]
        [StringLength(100,ErrorMessage = "El titulo no debe sobrepasar los 100 caracteres.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="La descripción de la denuncia es requerida.")]
        public string Descripcion { get; set; }
        //[Required]
        public string Estado { get; set; }
        public virtual Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
    }
}