using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATA.Models
{
    public partial class Seguimiento : BaseEntity
    {
        [Required(ErrorMessage = "Debe establecer el rango de fechas del Seguimiento.")]
        public string[] RangoFechas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaConclusion { get; set; }
        //[Required(ErrorMessage = "Debe asignar la cantidad de visitas de acuerdo al rango de fechas")]
        //[Range(3, 10, ErrorMessage = "El minimo debe ser de 3 visitas hasta un maximo de 10.")]
        //public int CantidadVisitas { get; set; }
        public string Estado { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual ContratoAdopcion ContratoAdopcion { get; set; }
        public int ContratoAdopcionId { get; set; }
        public virtual List<ReporteSeguimiento> ReporteSeguimientos { get; set; }
        //public Seguimiento()
        //{
        //    if (this.ReporteSeguimientos == null)
        //        this.ReporteSeguimientos = new List<ReporteSeguimiento>();
        //}
    }
}
