using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA.Models
{
    public class ContratoRechazo : BaseEntity
    {
        [Required(ErrorMessage ="Necesita proporcionar la razon por la cual se esta Rechazando/Cancelando la Solicitud")]
        public string RazonRechazo { get; set; }
        public virtual ContratoAdopcion ContratoAdopcion { get; set; }
        public int ContratoAdopcionId { get; set; }
    }
}
