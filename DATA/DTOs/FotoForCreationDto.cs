using Microsoft.AspNetCore.Http;

namespace DATA.DTOs;

public class FotoForCreationDto
{
    public IEnumerable<IFormFile> Archivo { get; set; }
}
