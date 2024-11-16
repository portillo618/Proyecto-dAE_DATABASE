using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class IngresoMaterial
{
    public int NumFactura { get; set; }

    public int? IdImplemento { get; set; }

    public int? Cantidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateOnly? Fecha { get; set; }

    public virtual Implemento? IdImplementoNavigation { get; set; }
}
