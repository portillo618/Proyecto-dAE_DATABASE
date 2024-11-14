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
                MessageBox.Show("No hay préstamos para mostrar.");
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
                DataGridPrestamos.Columns["IdPrestamo"].HeaderText = "ID Préstamo";
                DataGridPrestamos.Columns["Usuario"].HeaderText = "Usuario";
                DataGridPrestamos.Columns["Encargado"].HeaderText = "Encargado";
                DataGridPrestamos.Columns["Implemento"].HeaderText = "Implemento";
                DataGridPrestamos.Columns["Deporte"].HeaderText = "Deporte";
                DataGridPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha Préstamo";
                DataGridPrestamos.Columns["FechaDevolucion"].HeaderText = "Fecha Devolución";
            };

        }

        private void CargarComboBoxes()
        {
            // Obtener la lista de deportes desde la base de datos
            var deportes = context.Deportes
                .Select(d => d.NombreDeporte)
                .ToList();

            if (deportes.Any())
            {
                cmbDeporte.DataSource = deportes;
                cmbDeporte.SelectedIndex = -1; // Deseleccionar por defecto
            }
            else
            {
                MessageBox.Show("No hay deportes disponibles en la base de datos.");
            }
        
            // Obtener la lista de tipos de implementos desde la base de datos
            var implementos = context.Implementos
                .Select(i => i.Tipo)
                .ToList();

            if (implementos.Any())
            {
                cbTipoImplemento.DataSource = implementos;
                cbTipoImplemento.SelectedIndex = -1; // Deseleccionar por defecto
            }
            else
            {
                MessageBox.Show("No hay implementos disponibles en la base de datos.");
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
                MessageBox.Show("Por favor, ingrese un número válido para el carnet.");
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
                MessageBox.Show("Encargado no encontrado. Verifica el ID e inténtalo nuevamente.");
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
                        CantidadPrestada = int.Parse(numCantidad.Text),
                        Especificacion = cbTipoImplemento.SelectedItem.ToString(),
                        Estado = "Prestado"
                    };


                    context.DetallePrestamos.Add(detallePrestamo);
                    context.SaveChanges();


                    transaction.Commit();
                    MessageBox.Show("Préstamo agregado correctamente.");
                    CargarPrestamos();
                }

                catch (Exception ex)
                {

                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el préstamo: " + ex.Message);
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

                    MessageBox.Show("Préstamo eliminado correctamente.");
                    CargarPrestamos();
                }
                else
                {
                    MessageBox.Show("Préstamo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un préstamo para eliminar.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (DataGridPrestamos.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridPrestamos.SelectedRows[0];
                int idPrestamo = (int)selectedRow.Cells["IdPrestamo"].Value;


                var prestamo = context.Prestamos.Include(p => p.DetallePrestamos)
                    .FirstOrDefault(p => p.IdPrestamo == idPrestamo);

                if (prestamo != null)
                {

                    numCantidad.Value = prestamo.DetallePrestamos.First().CantidadPrestada;
                    cbTipoImplemento.SelectedItem = prestamo.DetallePrestamos.First().Especificacion;
                    txtEcargado.Text = prestamo.IdEncargadoPrestamo.ToString();

                    btnConfirmar.Enabled = true;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Préstamo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un préstamo para modificar.");
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (DataGridPrestamos.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridPrestamos.SelectedRows[0];
                int idPrestamo = (int)selectedRow.Cells["IdPrestamo"].Value;

                var prestamo = context.Prestamos.Include(p => p.DetallePrestamos)
                    .FirstOrDefault(p => p.IdPrestamo == idPrestamo);

                if (prestamo != null)
                {

                    prestamo.DetallePrestamos.First().CantidadPrestada = (int)numCantidad.Value; // Modifica según el número
                    prestamo.DetallePrestamos.First().Especificacion = cbTipoImplemento.SelectedItem.ToString();
                    prestamo.IdEncargadoPrestamo = int.Parse(txtEcargado.Text);


                    context.SaveChanges();

                    MessageBox.Show("Préstamo modificado correctamente.");
                    CargarPrestamos();


                    btnConfirmar.Enabled = false;
                    btnAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Préstamo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un préstamo para modificar.");
            }
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

                // Buscar el préstamo en la base de datos, incluyendo las entidades relacionadas
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
                        cbTipoImplemento.SelectedItem = detalle.IdImplementoNavigation.Tipo;
                        txtEcargado.Text = prestamo.IdEncargadoPrestamo.ToString();
                        txtCarnet.Text = prestamo.IdReceptorNavigation.CarneBiblioteca.ToString();

                        // Obtener el nombre del deporte desde la entidad relacionada
                        var deporte = detalle.IdImplementoNavigation?.IdDeporteNavigation?.NombreDeporte;
                        if (deporte != null)
                        {
                            cmbDeporte.SelectedItem = deporte;
                        }
                        else
                        {
                            cmbDeporte.SelectedIndex = -1; // Deseleccionar si no hay deporte
                        }

                        txtbDescripcion.Text = detalle.Especificacion ?? "No hay especificación disponible.";

                        rellenarCamposUsuario();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron detalles para este préstamo.");
                    }


                }
            }
        }
    }
}
