using Proyecto_dAE_DATABASE.Modelo;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PrestamoEntity = Proyecto_dAE_DATABASE.Modelo.Prestamo;

namespace Prestaform
{
    public partial class Form1 : Form
    {
        public BodegaContext context = new BodegaContext();
        public Form1()
        {
            InitializeComponent();
            CargarPrestamos();
            CargarComboBoxes();
        }

        public Usuario usuarioActual;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rellenarCamposUsuario();
        }

        private void CargarPrestamos()
        {
            var prestamos = context.Prestamos
                .Include(p => p.IdReceptorNavigation)
                .Include(p => p.IdEncargadoPrestamoNavigation)
                .Include(p => p.DetallePrestamos)
                    .ThenInclude(d => d.IdImplementoNavigation)
                        .ThenInclude(i => i.IdDeporteNavigation)
                .ToList();

            if (!prestamos.Any())
            {
                MessageBox.Show("No hay pr�stamos para mostrar.");
                return;
            }


            DataGridPrestamos.DataSource = prestamos.SelectMany(p => p.DetallePrestamos, (p, d) => new
            {
                p.IdPrestamo,
                Usuario = p.IdReceptorNavigation.NombreUsuario,
                Encargado = p.IdEncargadoPrestamoNavigation.NombreEncargado,
                Implemento = d.IdImplementoNavigation.Tipo,
                Deporte = d.IdImplementoNavigation.IdDeporteNavigation.NombreDeporte,
                p.FechaPrestamo,
                p.FechaDevolucion
            }).ToList();

            // Configurar encabezados de columna
            DataGridPrestamos.DataBindingComplete += (s, e) =>
            {
                DataGridPrestamos.Columns["IdPrestamo"].HeaderText = "ID Pr�stamo";
                DataGridPrestamos.Columns["Usuario"].HeaderText = "Usuario";
                DataGridPrestamos.Columns["Encargado"].HeaderText = "Encargado";
                DataGridPrestamos.Columns["Implemento"].HeaderText = "Implemento";
                DataGridPrestamos.Columns["Deporte"].HeaderText = "Deporte";
                DataGridPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha Pr�stamo";
                DataGridPrestamos.Columns["FechaDevolucion"].HeaderText = "Fecha Devoluci�n";
            };

        }

        private void CargarComboBoxes()
        {
            // Obtener la lista de implementos desde la base de datos
            var implementos = context.Implementos
                .Include(i => i.IdDeporteNavigation) // Incluir el deporte relacionado
                .Select(i => new { i.IdImplemento, i.Tipo, i.IdDeporteNavigation.NombreDeporte, i.Cantidad })
                .ToList();

            if (implementos.Any())
            {
                cbTipoImplemento.DataSource = implementos;
                cbTipoImplemento.DisplayMember = "Tipo";
                cbTipoImplemento.ValueMember = "IdImplemento";
                cbTipoImplemento.SelectedIndex = -1; // Deseleccionar por defecto

                // Asociar el evento de selecci�n de implemento
                cbTipoImplemento.SelectedIndexChanged += CbTipoImplemento_SelectedIndexChanged;
            }
            else
            {
                MessageBox.Show("No hay implementos disponibles en la base de datos.");
            }
        }

        // Evento para actualizar el deporte al seleccionar un implemento
        private void CbTipoImplemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoImplemento.SelectedIndex != -1)
            {
                var implementoSeleccionado = (dynamic)cbTipoImplemento.SelectedItem;
                cmbDeporte.Text = implementoSeleccionado.NombreDeporte ?? string.Empty;

                numCantidad.Maximum = implementoSeleccionado.Cantidad;
            }
            else
            {
                cmbDeporte.Text = string.Empty;
                numCantidad.Maximum = 1;
            }
        }

        private void rellenarCamposUsuario()
        {
            if (int.TryParse(txtCarnet.Text, out int carne))
            {

                usuarioActual = context.Usuarios.Include(u => u.IdCarreraNavigation).ThenInclude(c => c.IdEscuelaNavigation).FirstOrDefault(u => u.CarneBiblioteca == carne);

                if (usuarioActual != null)
                {
                    txtbNombre.Text = usuarioActual.NombreUsuario;

                    if (usuarioActual.IdCarreraNavigation != null)
                    {
                        txtbCarrera.Text = usuarioActual.IdCarreraNavigation.NombreCarrera;
                        txtbEscuela.Text = usuarioActual.IdCarreraNavigation.IdEscuelaNavigation?.NombreEscuela;
                    }
                    else
                    {
                        txtbCarrera.Text = "No asignada";
                        txtbEscuela.Text = "No asignada";
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                    txtbNombre.Text = string.Empty;
                    txtbEscuela.Text = string.Empty;
                    txtbCarrera.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido para el carnet.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (usuarioActual == null)
            {
                MessageBox.Show("Por favor, busca un usuario primero.");
                return;
            }


            var encargado = context.EncargadoBodegas.FirstOrDefault(e => e.IdEncargado == int.Parse(txtEcargado.Text));
            if (encargado == null)
            {
                MessageBox.Show("Encargado no encontrado. Verifica el ID e int�ntalo nuevamente.");
                return;
            }

            var implementoSeleccionado = (dynamic)cbTipoImplemento.SelectedItem;
            int cantidadSolicitada = (int)numCantidad.Value;

            // Verificar si la cantidad solicitada es v�lida
            if (cantidadSolicitada > implementoSeleccionado.Cantidad)
            {
                MessageBox.Show("No hay suficientes implementos disponibles. Reduce la cantidad y vuelve a intentarlo.");
                return;
            }


            var nuevoPrestamo = new PrestamoEntity
            {
                IdReceptor = usuarioActual.IdUsuario,
                FechaPrestamo = DateOnly.FromDateTime(DateTime.Now),
                FechaDevolucion = DateOnly.FromDateTime(DateTime.Now.AddDays(7)),
                IdEncargadoPrestamo = encargado.IdEncargado
            };


            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    context.Prestamos.Add(nuevoPrestamo);
                    context.SaveChanges();

                    var detallePrestamo = new DetallePrestamo
                    {
                        IdPrestamo = nuevoPrestamo.IdPrestamo,
                        IdImplemento = (int)cbTipoImplemento.SelectedValue,
                        CantidadPrestada = int.Parse(numCantidad.Text),
                        Especificacion = cbTipoImplemento.SelectedItem.ToString(),
                        Estado = "Prestado"
                    };


                    context.DetallePrestamos.Add(detallePrestamo);
                    context.SaveChanges();


                    transaction.Commit();
                    MessageBox.Show("Pr�stamo agregado correctamente.");
                    CargarPrestamos();
                }

                catch (Exception ex)
                {

                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el pr�stamo: " + ex.Message);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridPrestamos.SelectedRows.Count > 0)
            {

                var selectedRow = DataGridPrestamos.SelectedRows[0];
                int idPrestamo = (int)selectedRow.Cells["IdPrestamo"].Value;


                var prestamo = context.Prestamos.Find(idPrestamo);
                if (prestamo != null)
                {

                    context.Prestamos.Remove(prestamo);
                    context.SaveChanges();

                    MessageBox.Show("Pr�stamo eliminado correctamente.");
                    CargarPrestamos();
                }
                else
                {
                    MessageBox.Show("Pr�stamo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pr�stamo para eliminar.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DataGridPrestamos.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridPrestamos.SelectedRows[0];
                int idPrestamo = (int)selectedRow.Cells["IdPrestamo"].Value;

                // Buscar el pr�stamo en la base de datos
                var prestamo = context.Prestamos
                    .Include(p => p.DetallePrestamos)
                    .FirstOrDefault(p => p.IdPrestamo == idPrestamo);

                if (prestamo != null)
                {
                    // Actualizar los datos del pr�stamo
                    if (int.TryParse(txtCarnet.Text, out int nuevoCarnet))
                    {
                        var usuario = context.Usuarios.FirstOrDefault(u => u.CarneBiblioteca == nuevoCarnet);
                        if (usuario != null)
                        {
                            prestamo.IdReceptor = usuario.IdUsuario;
                        }
                        else
                        {
                            MessageBox.Show("Carnet de usuario no encontrado.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un carnet v�lido.");
                        return;
                    }

                    if (int.TryParse(txtEcargado.Text, out int nuevoEncargado))
                    {
                        prestamo.IdEncargadoPrestamo = nuevoEncargado;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un ID de encargado v�lido.");
                        return;
                    }

                    // Actualizar la fecha de pr�stamo y devoluci�n
                    prestamo.FechaPrestamo = DateOnly.FromDateTime(dtPrestamo.Value);
                    prestamo.FechaDevolucion = DateOnly.FromDateTime(dtDevolucion.Value);


                    // Actualizar los detalles del pr�stamo
                    var detalle = prestamo.DetallePrestamos.FirstOrDefault();
                    if (detalle != null)
                    {
                        detalle.CantidadPrestada = (int)numCantidad.Value;
                        detalle.Especificacion = txtbDescripcion.Text;
                        //detalle.Estado = cmbEstado.SelectedItem.ToString();

                        var implementoSeleccionado = cbTipoImplemento.SelectedItem?.ToString();
                        if (implementoSeleccionado != null)
                        {
                            var implemento = context.Implementos
                                .FirstOrDefault(i => i.Tipo == implementoSeleccionado);

                            if (implemento != null)
                            {
                                detalle.IdImplemento = implemento.IdImplemento;
                            }
                            else
                            {
                                MessageBox.Show("Implemento seleccionado no encontrado.");
                                return;
                            }
                        }
                    }

                    // Guardar cambios en la base de datos
                    context.SaveChanges();
                    MessageBox.Show("Datos modificados correctamente.");

                    // Actualizar el DataGrid para reflejar los cambios
                    CargarPrestamos();
                }
                else
                {
                    MessageBox.Show("Pr�stamo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pr�stamo para modificar.");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void DataGridPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridPrestamos_Click(object sender, EventArgs e)
        {
            if (DataGridPrestamos.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridPrestamos.SelectedRows[0];
                int idPrestamo = (int)selectedRow.Cells["IdPrestamo"].Value;

                // Buscar el pr�stamo en la base de datos, incluyendo las entidades relacionadas
                var prestamo = context.Prestamos
                    .Include(p => p.DetallePrestamos)
                        .ThenInclude(dp => dp.IdImplementoNavigation)
                            .ThenInclude(i => i.IdDeporteNavigation)
                    .FirstOrDefault(p => p.IdPrestamo == idPrestamo);

                if (prestamo != null)
                {
                    // Convertir de DateOnly a DateTime antes de asignarlo a los DateTimePickers
                    dtPrestamo.Value = prestamo.FechaPrestamo.ToDateTime(TimeOnly.MinValue);
                    dtDevolucion.Value = prestamo.FechaDevolucion.ToDateTime(TimeOnly.MinValue);

                    // Obtener el nombre del deporte desde la entidad relacionada
                    var detalle = prestamo.DetallePrestamos.FirstOrDefault();
                    if (detalle != null)
                    {
                        numCantidad.Value = detalle.CantidadPrestada;
                        cbTipoImplemento.SelectedValue = detalle.IdImplemento;
                        txtEcargado.Text = prestamo.IdEncargadoPrestamo.ToString();
                        txtCarnet.Text = prestamo.IdReceptorNavigation.CarneBiblioteca.ToString();

                        cmbDeporte.Text = detalle.IdImplementoNavigation?.IdDeporteNavigation?.NombreDeporte ?? string.Empty;
                        txtbDescripcion.Text = detalle.Especificacion ?? "No hay especificaci�n disponible.";
                        //cmbEstado.SelectedItem = detalle.Estado;

                        rellenarCamposUsuario();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron detalles para este pr�stamo.");
                    }


                }
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            string parametro = cmbParametro.SelectedItem.ToString();
            string busqueda = txtbBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingresa un t�rmino de b�squeda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new BodegaContext())
            {
                // Nueva consulta desde DetallePrestamos
                var prestamosQuery = context.DetallePrestamos
                    .Include(dp => dp.IdPrestamoNavigation)
                    .ThenInclude(p => p.IdReceptorNavigation)
                    .Include(dp => dp.IdPrestamoNavigation)
                    .ThenInclude(p => p.IdEncargadoPrestamoNavigation)
                    .Include(dp => dp.IdImplementoNavigation)
                    .ThenInclude(i => i.IdDeporteNavigation)
                    .AsQueryable();

                switch (parametro)
                {
                    case "ID Pr�stamo":
                        if (int.TryParse(busqueda, out int idPrestamo))
                        {
                            prestamosQuery = prestamosQuery.Where(dp => dp.IdPrestamo == idPrestamo);
                        }
                        else
                        {
                            MessageBox.Show("El ID del pr�stamo debe ser un n�mero v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    case "Usuario":
                        prestamosQuery = prestamosQuery.Where(dp => dp.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario.Contains(busqueda));
                        break;

                    case "Encargado":
                        prestamosQuery = prestamosQuery.Where(dp => dp.IdPrestamoNavigation.IdEncargadoPrestamoNavigation.NombreEncargado.Contains(busqueda));
                        break;

                    case "Implemento":
                        prestamosQuery = prestamosQuery.Where(dp => dp.IdImplementoNavigation.Tipo.Contains(busqueda));
                        break;

                    case "Deporte":
                        prestamosQuery = prestamosQuery.Where(dp => dp.IdImplementoNavigation.IdDeporteNavigation.NombreDeporte.Contains(busqueda));
                        break;

                    default:
                        MessageBox.Show("Par�metro de b�squeda no v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Ajustar la proyecci�n
                var resultados = prestamosQuery.Select(dp => new
                {
                    IDPrestamo = dp.IdPrestamo,
                    Usuario = dp.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario,
                    Encargado = dp.IdPrestamoNavigation.IdEncargadoPrestamoNavigation.NombreEncargado,
                    Implemento = dp.IdImplementoNavigation.Tipo,
                    Deporte = dp.IdImplementoNavigation.IdDeporteNavigation.NombreDeporte,
                    FechaPrestamo = dp.IdPrestamoNavigation.FechaPrestamo,
                    FechaDevolucion = dp.IdPrestamoNavigation.FechaDevolucion
                }).ToList();

                DataGridPrestamos.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarPrestamos();
        }
    }
}
