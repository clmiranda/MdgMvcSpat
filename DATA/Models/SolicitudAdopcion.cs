using System.ComponentModel.DataAnnotations;

namespace DATA.Models;

public partial class SolicitudAdopcion : BaseEntity
{
    [Required(ErrorMessage = "Debe ingresar su nombre completo.")]
    [MaxLength(300)]
    public string NombreCompleto { get; set; } = null!;
    [Required(ErrorMessage = "Debe ingresar su domicilio.")]
    [MaxLength(200)]
    public string Domicilio { get; set; } = null!;
    [Required(ErrorMessage = "Para ponernos en contacto con usted, debe ingresar su número de teléfono/celular")]
    [MaxLength(20)]
    public string Telefono { get; set; } = null!;
    public DateTime FechaSolicitudAdopcion { get; set; }
    public DateTime FechaAdopcion { get; set; }
    [MaxLength(20)]
    public string? Estado { get; set; }
    public virtual ContratoAdopcion? ContratoAdopcion { get; set; }
    public virtual Mascota? Mascota { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar la mascota a adoptar.")]
    public int MascotaId { get; set; }
    public virtual Seguimiento? Seguimiento { get; set; }
    public virtual AdopcionRechazada? AdopcionRechazada { get; set; }
    public virtual AdopcionCancelada? AdopcionCancelada { get; set; }
}
