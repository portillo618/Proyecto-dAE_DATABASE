using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Carrera
{
    public int IdCarrera { get; set; }

    public string? NombreCarrera { get; set; }

    public int? IdEscuela { get; set; }

    public virtual Escuela? IdEscuelaNavigation { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
