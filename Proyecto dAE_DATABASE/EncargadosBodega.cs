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
    public partial class EncargadosBodega : Form
    {
        public EncargadosBodega()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            using (var context = new BodegaContext())
            {
                var encargados = context.EncargadoBodegas.ToList();
                dataGridView1.DataSource = encargados;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametro = cmbParametro.SelectedItem?.ToString();
            string busqueda = txtbBusqueda.Text.Trim();

            using (var context = new BodegaContext())
            {
                IQueryable<EncargadoBodega> query = context.EncargadoBodegas;

                if (!string.IsNullOrEmpty(busqueda))
                {
                    // Filtrar por el parámetro seleccionado
                    if (parametro == "Nombre")
                    {
                        query = query.Where(e => e.NombreEncargado.Contains(busqueda));
                    }
                    else if (parametro == "ID")
                    {
                        // Convertir el valor de búsqueda a entero y filtrar por ID
                        if (int.TryParse(busqueda, out int id))
                        {
                            query = query.Where(e => e.IdEncargado == id);
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingresa un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new BodegaContext())
            {
                var nuevoEncargado = new EncargadoBodega
                {
                    NombreEncargado = nombre,
                    // Puedes agregar más campos si los tienes en la tabla EncargadoBodega
                };

                context.EncargadoBodegas.Add(nuevoEncargado);
                context.SaveChanges();

                MessageBox.Show("Encargado de bodega agregado exitosamente.");
                CargarGrid(); // Función que recarga el DataGridView con los registros
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value; // Asumiendo que tienes una columna "Id"
            string nombre = txtbNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingresa un nombre para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new BodegaContext())
            {
                var encargado = context.EncargadoBodegas.Find(idSeleccionado);
                if (encargado != null)
                {
                    encargado.NombreEncargado = nombre;
                    // Modificar otros campos si es necesario
                    context.SaveChanges();

                    MessageBox.Show("Encargado de bodega modificado exitosamente.");
                    CargarGrid(); // Recargar el DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontró el encargado de bodega.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value; // Asumiendo que tienes una columna "Id"

            using (var context = new BodegaContext())
            {
                var encargado = context.EncargadoBodegas.Find(idSeleccionado);
                if (encargado != null)
                {
                    context.EncargadoBodegas.Remove(encargado);
                    context.SaveChanges();

                    MessageBox.Show("Encargado de bodega eliminado exitosamente.");
                    CargarGrid(); // Recargar el DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontró el encargado de bodega.");
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridView1.SelectedRows[0];
                int idSeleccionado = (int)filaSeleccionada.Cells["Id"].Value; // Asumiendo que tienes una columna "Id"

                using (var context = new BodegaContext())
                {
                    var encargado = context.EncargadoBodegas.Find(idSeleccionado);
                    if (encargado != null)
                    {
                        txtbNombre.Text = encargado.NombreEncargado;
                        // Cargar otros campos si es necesario
                    }
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
