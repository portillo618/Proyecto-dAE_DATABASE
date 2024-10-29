using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public int IdReceptor { get; set; }

    public DateOnly FechaPrestamo { get; set; }

    public DateOnly FechaDevolucion { get; set; }

    public int? IdEncargadoPrestamo { get; set; }

    public virtual ICollection<DetallePrestamo> DetallePrestamos { get; set; } = new List<DetallePrestamo>();

    public virtual EncargadoBodega? IdEncargadoPrestamoNavigation { get; set; }

    public virtual Usuario IdReceptorNavigation { get; set; } = null!;
}
