using Microsoft.EntityFrameworkCore;
using Proyecto_dAE_DATABASE.Modelo;
using System;
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
        }

        private void CargarPrestamosPendientes()
        {
            var datosPrestamos = contexto.DetallePrestamos.Include(d => d.IdPrestamoNavigation.IdReceptorNavigation) 
                                                            .Include(d => d.IdImplementoNavigation).Select(d => new
        {
            IdDetallePrestamo = d.IdDetallePrestamo,
            Usuario = d.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario,Articulo = d.IdImplementoNavigation.Tipo,
            FechaPrestamo = d.IdPrestamoNavigation.FechaPrestamo,Estado = d.Estado,CantidadPrestada = d.CantidadPrestada}).ToList();
                       
            dgvPrestamos.DataSource = datosPrestamos;
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dgvPrestamos.Rows[e.RowIndex];

                txtIDUsuario.Text = selectedRow.Cells["Usuario"].Value.ToString();
                txtNombreReceptor.Text = selectedRow.Cells["Articulo"].Value.ToString();
                txtCantidad.Text = selectedRow.Cells["CantidadPrestada"].Value.ToString(); 
                txtEstado.Text = selectedRow.Cells["Estado"].Value.ToString();
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
                    CantidadPrestada = d.CantidadPrestada}).ToList();

            
            dgvPrestamos.DataSource = resultadosBusqueda;

            if (resultadosBusqueda.Count == 0)
            {
                MessageBox.Show("No se encontraron préstamos para el usuario especificado.", "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    // Obtener el estado del TextBox
                    string nuevoEstado = txtEstado.Text.Trim(); // Obtener el texto y eliminar espacios

                    if (string.IsNullOrEmpty(nuevoEstado)) // Verificar que no esté vacío
                    {
                        MessageBox.Show("Por favor, ingrese un estado válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    detallePrestamo.Estado = nuevoEstado;
                    contexto.SaveChanges();

                    MessageBox.Show($"Estado actualizado a '{nuevoEstado}'.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPrestamosPendientes();
                }
                else
                {
                    MessageBox.Show("No se encontró el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo para registrar la devolución.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
