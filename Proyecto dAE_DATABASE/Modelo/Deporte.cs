using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Deporte
{
    public int IdDeporte { get; set; }

    public string NombreDeporte { get; set; } = null!;

    public virtual ICollection<Implemento> Implementos { get; set; } = new List<Implemento>();
}
