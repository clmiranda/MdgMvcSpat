using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace DATA.DTOs
{
    public class FotoForCreationDto
    {
        public IEnumerable<IFormFile> Archivo { get; set; }
    }
}
