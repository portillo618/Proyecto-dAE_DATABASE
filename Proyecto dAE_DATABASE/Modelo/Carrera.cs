using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Carrera
{
    public int IdCarrera { get; set; }

    public string NombreCarrera { get; set; } = null!;

    public int IdEscuela { get; set; }

    public virtual Escuela IdEscuelaNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
