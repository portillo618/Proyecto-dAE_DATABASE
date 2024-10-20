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
            // Cargar los datos desde la vista en el DataGridView
            dgvPrestamos.DataSource = contexto.DetallePrestamosViews.ToList();
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se ha hecho clic en una celda
            if (dgvPrestamos.SelectedCells.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedRowIndex = dgvPrestamos.SelectedCells[0].RowIndex;

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvPrestamos.Rows[selectedRowIndex];

                // Asignar los valores de las celdas correspondientes a los TextBox
                txtIDUsuario.Text = selectedRow.Cells["Usuario"].Value.ToString();  // Nombre del usuario
                txtNombreReceptor.Text = selectedRow.Cells["Articulo"].Value.ToString();  // Descripción del artículo
            }
        }
    }
}
