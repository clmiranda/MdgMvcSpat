using DATA.Models;
using System.Collections;
using System.Collections.Generic;

namespace DATA.DTOs
{
    public class AntecedentesAdopcionDto
    {
        public List<AdopcionRechazada> ListaAdopcionRechazada { get; set; }
        public List<AdopcionCancelada> ListaAdopcionCancelada { get; set; }
    }
}
