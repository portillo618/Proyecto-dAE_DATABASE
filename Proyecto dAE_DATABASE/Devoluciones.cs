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
        private string usuarioLogueado;

        public Devoluciones(string usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            CargarPrestamosPendientes();
            CargarEstados();

            // Mostrar el usuario logueado
            txtUsuarioDevolucion.Text = usuarioLogueado;
            txtUsuarioDevolucion.ReadOnly = true; // Evitar edici�n
        }

        private void CargarPrestamosPendientes()
        {
            var datosPrestamos = contexto.DetallePrestamos
                                         .Include(d => d.IdPrestamoNavigation.IdReceptorNavigation)
                                         .Include(d => d.IdImplementoNavigation)
                                         .Select(d => new
                                         {
                                             IdDetallePrestamo = d.IdDetallePrestamo,
                                             Usuario = d.IdPrestamoNavigation.IdReceptorNavigation.NombreUsuario,
                                             Articulo = d.IdImplementoNavigation.Tipo,
                                             FechaPrestamo = d.IdPrestamoNavigation.FechaPrestamo,
                                             Estado = d.Estado,
                                             CantidadPrestada = d.CantidadPrestada,
                                             UsuarioDevolucion = d.UsuarioDevolucion
                                         }).ToList();

            dgvPrestamos.DataSource = datosPrestamos;

            dgvPrestamos.Columns["IdDetallePrestamo"].HeaderText = "ID Detalle";
            dgvPrestamos.Columns["Usuario"].HeaderText = "Usuario";
            dgvPrestamos.Columns["Articulo"].HeaderText = "Art�culo";
            dgvPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha de Pr�stamo";
            dgvPrestamos.Columns["Estado"].HeaderText = "Estado";
            dgvPrestamos.Columns["CantidadPrestada"].HeaderText = "Cantidad Prestada";
            dgvPrestamos.Columns["UsuarioDevolucion"].HeaderText = "Usuario Devoluci�n";
        }

        private void CargarEstados()
        {
            var estados = new List<string> { "Pendiente", "Devuelto", "Da�ado", "Perdido" };
            cmbEstado.DataSource = estados;
            cmbEstado.SelectedIndex = -1;
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
                    string nuevoEstado = cmbEstado.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(nuevoEstado))
                    {
                        MessageBox.Show("Por favor, seleccione un estado v�lido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    detallePrestamo.Estado = nuevoEstado;
                    detallePrestamo.UsuarioDevolucion = usuarioLogueado;

                    contexto.SaveChanges();

                    MessageBox.Show($"Devoluci�n registrada por '{usuarioLogueado}'.\nEstado actualizado a '{nuevoEstado}'.", "Actualizaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
