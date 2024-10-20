using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public int? IdCarrera { get; set; }

    public string? Direccion { get; set; }

    public string? Rol { get; set; }

    public string? Telefono { get; set; }

    public int? Contrasenia { get; set; }

    public virtual Carrera? IdCarreraNavigation { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
