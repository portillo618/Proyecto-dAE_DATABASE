using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Perdido
{
    public int IdPerdido { get; set; }

    public int? IdDetallePrestamo { get; set; }

    public int? CantidadPerdida { get; set; }

    public virtual DetallePrestamo? IdDetallePrestamoNavigation { get; set; }
}
