using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class Mascota : BaseEntity
    {
        [Required(ErrorMessage = "El nombre de la mascota es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe elegir el sexo dela mascota.")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "La descripcion de la mascota es requerida.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El tamaño de la mascota es requerido.")]
        public string Tamaño { get; set; }
        [Required(ErrorMessage = "Debe especificar si la mascota esta actualmente esterilizada.")]
        public bool Esterilizado { get; set; }
        [Required(ErrorMessage = "La edad de la mascota es requerido.")]
        public string Edad { get; set; }
        public DateTime FechaAgregado { get; set; }
        public string EstadoSituacion { get; set; }
        //public string TituloDenuncia { get; set; }
        //public string TituloCaso { get; set; }
        public virtual Denuncia Denuncia { get; set; }
        public int DenunciaId { get; set; }
        public virtual IEnumerable<Foto> Fotos { get; set; }
        public virtual Foto Foto { get; set; }
        public virtual ContratoAdopcion ContratoAdopcion { get; set; }
    }
}
