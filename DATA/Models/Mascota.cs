using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class Mascota : BaseEntity
    {
        //[Required(ErrorMessage = "El nombre de la mascota es requerido.")]
        public string Nombre { get; set; }
        //[Required(ErrorMessage = "Debe elegir el sexo de la mascota.")]
        public string Sexo { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la especie.")]
        public string Especie { get; set; }
        //[Required(ErrorMessage = "Debe ingresar las caracteristicas.")]
        public string Caracteristicas { get; set; }
        //[Required(ErrorMessage = "Debe ingresar los rasgos particulares.")]
        public string RasgosParticulares { get; set; }
        //[Required(ErrorMessage = "La descripcion de la mascota es requerida.")]
        //public string Descripcion { get; set; }
        //[Required(ErrorMessage = "El tamaño de la mascota es requerido.")]
        public string Tamaño { get; set; }
        //[Required(ErrorMessage = "Debe especificar si la mascota esta esterilizada.")]
        public bool Esterilizado { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la edad de la mascota.")]
        public string Edad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
        //public string TituloDenuncia { get; set; }
        //public string TituloCaso { get; set; }
        public virtual Denuncia Denuncia { get; set; }
        public int DenunciaId { get; set; }
        public virtual List<Foto> Fotos { get; set; }
        public virtual List<ReporteTratamiento> ReporteTratamientos { get; set; }
        public virtual Foto Foto { get; set; }
        public virtual ContratoAdopcion ContratoAdopcion { get; set; }
    }
}
