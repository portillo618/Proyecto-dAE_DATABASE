using Microsoft.EntityFrameworkCore;
using Proyecto_dAE_DATABASE.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_dAE_DATABASE
{
    public partial class Devoluciones : Form
    {
        private BodegaContext contexto = new BodegaContext();

        public Devoluciones()
        {
            InitializeComponent();
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            CargarPrestamosPendientes();
            CargarEstados(); // Inicializar ComboBox con los estados permitidos
        }

        private void CargarPrestamosPendientes()
        {
            var datosPrestamos = contexto.DetallePrestamos.Include(d => d.IdPrestamoNavigation.IdReceptorNavigation)
                                                          .Include(d => d.IdImplementoNavigation)
                                                          .Select(d => new
                                                          {
                                                              IdDetallePrestamo = d.IdDetallePrestamo,
                                                              Usuario = d.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario,
                                                              Articulo = d.IdImplementoNavigation.Tipo,
                                                              FechaPrestamo = d.IdPrestamoNavigation.FechaPrestamo,
                                                              Estado = d.Estado,
                                                              CantidadPrestada = d.CantidadPrestada
                                                          }).ToList();

            dgvPrestamos.DataSource = datosPrestamos;
        }

        private void CargarEstados()
        {
            // Lista de estados permitidos
            var estados = new List<string> { "Pendiente", "Devuelto", "Da�ado", "Perdido" };

            // Llenar el ComboBox
            cmbEstado.DataSource = estados;
            cmbEstado.SelectedIndex = -1; // Dejar sin selecci�n inicial
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPrestamos.Rows[e.RowIndex];

                txtIDUsuario.Text = selectedRow.Cells["Usuario"].Value.ToString();
                txtNombreReceptor.Text = selectedRow.Cells["Articulo"].Value.ToString();
                txtCantidad.Text = selectedRow.Cells["CantidadPrestada"].Value.ToString();

                // Establecer el estado en el ComboBox
                string estadoActual = selectedRow.Cells["Estado"].Value.ToString();
                cmbEstado.SelectedItem = estadoActual;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuarioBusqueda = txtIDUsuario.Text;

            var resultadosBusqueda = contexto.DetallePrestamos
                .Include(d => d.IdPrestamoNavigation.IdReceptorNavigation)
                .Include(d => d.IdImplementoNavigation)
                .Where(dp => dp.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario.Contains(usuarioBusqueda))
                .Select(d => new
                {
                    IdDetallePrestamo = d.IdDetallePrestamo,
                    Usuario = d.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario,
                    Articulo = d.IdImplementoNavigation.Tipo,
                    FechaPrestamo = d.IdPrestamoNavigation.FechaPrestamo,
                    Estado = d.Estado,
                    CantidadPrestada = d.CantidadPrestada
                }).ToList();

            dgvPrestamos.DataSource = resultadosBusqueda;

            if (resultadosBusqueda.Count == 0)
            {
                MessageBox.Show("No se encontraron pr�stamos para el usuario especificado.", "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmarDev_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvPrestamos.SelectedCells[0].RowIndex;
                int idDetallePrestamo = (int)dgvPrestamos.Rows[selectedRowIndex].Cells["IdDetallePrestamo"].Value;

                var detallePrestamo = contexto.DetallePrestamos.FirstOrDefault(dp => dp.IdDetallePrestamo == idDetallePrestamo);

                if (detallePrestamo != null)
                {
                    // Obtener el estado del ComboBox
                    string nuevoEstado = cmbEstado.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(nuevoEstado)) // Verificar que no est� vac�o
                    {
                        MessageBox.Show("Por favor, seleccione un estado v�lido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    detallePrestamo.Estado = nuevoEstado;
                    contexto.SaveChanges();

                    MessageBox.Show($"Estado actualizado a '{nuevoEstado}'.", "Actualizaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPrestamosPendientes();
                }
                else
                {
                    MessageBox.Show("No se encontr� el pr�stamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pr�stamo para registrar la devoluci�n.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
