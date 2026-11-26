using System.ComponentModel.DataAnnotations;

namespace DATA.Models;

public partial class Denuncia : BaseEntity
{
    [Required(ErrorMessage = "El título de la denuncia es requerida.")]
    [MaxLength(100)]
    public string Titulo { get; set; } = null!;
    [Required(ErrorMessage ="La descripción de la denuncia es requerida.")]
    [MaxLength(300)]
    public string Descripcion { get; set; } = null!;
    public virtual Mascota? Mascota { get; set; }
    public int MascotaId { get; set; }
}