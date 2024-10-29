using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Implemento
{
    public int IdImplemento { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdDeporte { get; set; }

    public int Anio { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Cantidad { get; set; }

    public virtual ICollection<DeBaja> DeBajas { get; set; } = new List<DeBaja>();

    public virtual ICollection<DetallePrestamo> DetallePrestamos { get; set; } = new List<DetallePrestamo>();

    public virtual Deporte IdDeporteNavigation { get; set; } = null!;
}
