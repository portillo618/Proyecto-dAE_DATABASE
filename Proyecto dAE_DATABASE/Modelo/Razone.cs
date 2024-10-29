using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Razone
{
    public int IdRazon { get; set; }

    public string NombreRazon { get; set; } = null!;

    public virtual ICollection<DeBaja> DeBajas { get; set; } = new List<DeBaja>();
}
