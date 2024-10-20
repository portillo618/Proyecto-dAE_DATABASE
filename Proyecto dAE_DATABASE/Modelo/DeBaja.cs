using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class DeBaja
{
    public int IdDeBaja { get; set; }

    public int? IdImplemento { get; set; }

    public string? Razon { get; set; }

    public virtual Implemento? IdImplementoNavigation { get; set; }
}
