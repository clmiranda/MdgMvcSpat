using DATA.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA.DTOs
{
    public class ContratoAdopcionDto
    {
        public virtual User User { get; set; }
        public virtual ContratoAdopcion ContratoAdopcion { get; set; }
        //public virtual IFormFile Archivo { get; set; }
    }
}