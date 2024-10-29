using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int CarneBiblioteca { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public int IdCarrera { get; set; }

    public string Direccion { get; set; } = null!;

    public int IdRol { get; set; }

    public string Telefono { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public virtual ICollection<DeBaja> DeBajas { get; set; } = new List<DeBaja>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual Role IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
