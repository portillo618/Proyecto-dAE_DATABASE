using Proyecto_dAE_DATABASE.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_dAE_DATABASE
{
    public partial class Deportes : Form
    {
        public Deportes()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            using (var context = new BodegaContext())
            {
                var deportes = context.Deportes.ToList();
                dataGridView1.DataSource = deportes;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametro = cmbParametro.SelectedItem?.ToString();
            string busqueda = txtbBusqueda.Text.Trim();

            using (var context = new BodegaContext())
            {
                IQueryable<Deporte> query = context.Deportes;

                if (!string.IsNullOrEmpty(busqueda))
                {
                    if (parametro == "Nombre")
                    {
                        query = query.Where(d => d.NombreDeporte.Contains(busqueda));
                    }
                    else if (parametro == "ID")
                    {
                        if (int.TryParse(busqueda, out int id))
                        {
                            query = query.Where(d => d.IdDeporte == id);
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreDeporte = txtbNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombreDeporte))
            {
                MessageBox.Show("Por favor ingresa un nombre para el deporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new BodegaContext())
            {
                var nuevoDeporte = new Deporte
                {
                    NombreDeporte = nombreDeporte
                };

                context.Deportes.Add(nuevoDeporte);
                context.SaveChanges();

                MessageBox.Show("Deporte agregado exitosamente.");

                // Recargar el DataGridView
                CargarGrid();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreDeporte = txtbNombre.Text.Trim(); // Obtenemos el nombre del deporte desde el cuadro de texto

            if (string.IsNullOrEmpty(nombreDeporte))
            {
                MessageBox.Show("Por favor ingresa un nombre para el deporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new BodegaContext())
            {
                // Buscar el deporte por nombre
                var deporte = context.Deportes.FirstOrDefault(d => d.NombreDeporte.Equals(nombreDeporte, StringComparison.OrdinalIgnoreCase));

                if (deporte == null)
                {
                    MessageBox.Show("El deporte no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Modificar el nombre del deporte (o cualquier otro campo que desees actualizar)
                deporte.NombreDeporte = nombreDeporte;

                // Guardar los cambios en la base de datos
                context.SaveChanges();

                MessageBox.Show("Deporte modificado exitosamente.");

                // Recargar el DataGridView
                CargarGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreDeporte = txtbNombre.Text.Trim(); // Obtenemos el nombre del deporte desde el cuadro de texto

            if (string.IsNullOrEmpty(nombreDeporte))
            {
                MessageBox.Show("Por favor ingresa un nombre para el deporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new BodegaContext())
            {
                // Buscar el deporte por nombre
                var deporte = context.Deportes.FirstOrDefault(d => d.NombreDeporte.Equals(nombreDeporte, StringComparison.OrdinalIgnoreCase));

                if (deporte == null)
                {
                    MessageBox.Show("El deporte no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar que el usuario quiere eliminar el deporte
                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este deporte?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar el deporte
                    context.Deportes.Remove(deporte);
                    context.SaveChanges();

                    MessageBox.Show("Deporte eliminado exitosamente.");

                    // Recargar el DataGridView
                    CargarGrid();
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridView1.SelectedRows[0];

                string nombreDeporte = filaSeleccionada.Cells["NombreDeporte"].Value.ToString();

                txtbNombre.Text = nombreDeporte;
            }
        }
    }
}
