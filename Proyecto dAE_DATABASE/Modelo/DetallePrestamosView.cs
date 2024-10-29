using System;
using System.Collections.Generic;

namespace Proyecto_dAE_DATABASE.Modelo;

public partial class DetallePrestamosView
{
    public int PrestamoId { get; set; }

    public string? Articulo { get; set; }

    public string? Estado { get; set; }

    public string? Usuario { get; set; }

    public string? Encargado { get; set; }
}
