using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Escuela
{
    public int IdEscuela { get; set; }

    public string? NombreEscuela { get; set; }

    public virtual ICollection<Carrera> Carreras { get; set; } = new List<Carrera>();
}
