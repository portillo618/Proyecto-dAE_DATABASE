using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class DetallePrestamo
{
    public int IdDetallePrestamo { get; set; }

    public string? Especificacion { get; set; }

    public int? IdPrestamo { get; set; }

    public int? IdImplemento { get; set; }

    public int? CantidadPrestada { get; set; }

    public string? Estado { get; set; }

    public virtual Implemento? IdImplementoNavigation { get; set; }

    public virtual Prestamo? IdPrestamoNavigation { get; set; }

    public virtual ICollection<Perdido> Perdidos { get; set; } = new List<Perdido>();
}
