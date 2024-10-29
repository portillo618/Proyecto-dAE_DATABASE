using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class DeBaja
{
    public int IdDeBaja { get; set; }

    public int? IdImplemento { get; set; }

    public int Cantidad { get; set; }

    public int? IdRazon { get; set; }

    public int? IdUsuarioResponsable { get; set; }

    public DateOnly FechaDeBaja { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Implemento? IdImplementoNavigation { get; set; }

    public virtual Razone? IdRazonNavigation { get; set; }

    public virtual Usuario? IdUsuarioResponsableNavigation { get; set; }
}
