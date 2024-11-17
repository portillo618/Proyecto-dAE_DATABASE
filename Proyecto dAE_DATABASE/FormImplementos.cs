using Proyecto_dAE_DATABASE.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace proyectoDAE
{
    public partial class FormImplementos : Form
    {
        private BodegaContext dbContext;

        public FormImplementos()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormImplementos_Load);
            dbContext = new BodegaContext();
        }

        private void FormImplementos_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Tipo", "Nombre del Implemento");
                dataGridView1.Columns.Add("deporte", "Deporte");
                dataGridView1.Columns.Add("anio", "Año");
                dataGridView1.Columns.Add("descripcion", "Descripción");
            }

            cmbbox.Items.Add("Fútbol");
            cmbbox.Items.Add("Baloncesto");
            cmbbox.Items.Add("Natación");
            cmbbox.Items.Add("Atletismo");
            cmbbox.Items.Add("Tenis");
            cmbbox.Items.Add("Voleibol");
            cmbbox.Items.Add("Cronómetro digital");

            cmbBuscar.Items.Add("Nombre del Implemento");
            cmbBuscar.Items.Add("Tipo de Deporte");
            cmbBuscar.Items.Add("Año");
            cmbBuscar.Items.Add("Descripción");

            LoadImplementos();
        }

        private void LoadImplementos()
        {
            dataGridView1.Rows.Clear();

            var implementos = dbContext.Implementos.Include(i => i.IdDeporteNavigation).ToList();

            if (implementos != null && implementos.Any())
            {
                foreach (var implemento in implementos)
                {
                    string nombreDeporte = implemento.IdDeporteNavigation?.NombreDeporte ?? "Desconocido";
                    string nombreImplemento = implemento.Tipo;
                    string descripcion = implemento.Descripcion;
                    int anio = implemento.Anio;

                    dataGridView1.Rows.Add(nombreImplemento, nombreDeporte, anio, descripcion);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron implementos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImplementos.Text) || cmbbox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtAnio.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string Tipo = txtImplementos.Text;
            string tipoDeporte = cmbbox.SelectedItem.ToString();

            if (!int.TryParse(txtAnio.Text, out int anio) || anio <= 0)
            {
                MessageBox.Show("Ingrese un año válido.");
                return;
            }

            string descripcion = txtDescripcion.Text;

            var nuevoImplemento = new Implemento
            {
                Tipo = Tipo,
                Anio = anio,
                Descripcion = descripcion,
                Cantidad = 1,
                IdDeporte = dbContext.Deportes.FirstOrDefault(d => d.NombreDeporte == tipoDeporte)?.IdDeporte ?? 0
            };

            dbContext.Implementos.Add(nuevoImplemento);
            dbContext.SaveChanges();

            LoadImplementos();

            MessageBox.Show("Implemento agregado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string descripcionImplemento = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var implemento = dbContext.Implementos.FirstOrDefault(i => i.Descripcion == descripcionImplemento);
                if (implemento != null)
                {
                    dbContext.Implementos.Remove(implemento);
                    dbContext.SaveChanges();

                    LoadImplementos();

                    MessageBox.Show("Implemento eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un implemento para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string descripcionImplemento = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var implemento = dbContext.Implementos.FirstOrDefault(i => EF.Functions.Like(i.Descripcion, descripcionImplemento));

                if (implemento != null)
                {
                    string nuevoNombre = txtImplementos.Text;
                    string nuevoTipoDeporte = cmbbox.SelectedItem != null ? cmbbox.SelectedItem.ToString() : "";
                    bool anioValido = int.TryParse(txtAnio.Text, out int nuevoAnio);
                    string nuevaDescripcion = txtDescripcion.Text;

                    if (!string.IsNullOrWhiteSpace(nuevoNombre) && !string.IsNullOrWhiteSpace(nuevoTipoDeporte) &&
                        anioValido && !string.IsNullOrWhiteSpace(nuevaDescripcion))
                    {
                        implemento.Tipo = nuevoTipoDeporte;
                        implemento.Anio = nuevoAnio;
                        implemento.Descripcion = nuevaDescripcion;

                        dbContext.SaveChanges();

                        LoadImplementos();

                        MessageBox.Show("Implemento editado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ingrese todos los campos correctamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un implemento para editar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string criterio = cmbBuscar.SelectedItem?.ToString();
            string valorBusqueda = txtBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(criterio) || string.IsNullOrWhiteSpace(valorBusqueda))
            {
                MessageBox.Show("Seleccione un criterio de búsqueda y escriba un valor.");
                return;
            }

            var implementos = dbContext.Implementos.ToList();

            foreach (var implemento in implementos)
            {
                bool encontrado = false;

                if (criterio == "Nombre del Implemento" && implemento.Descripcion.ToLower().Contains(valorBusqueda))
                {
                    encontrado = true;
                }
                else if (criterio == "Tipo de Deporte" && implemento.Tipo.ToLower().Contains(valorBusqueda))
                {
                    encontrado = true;
                }
                else if (criterio == "Año" && implemento.Anio.ToString() == valorBusqueda)
                {
                    encontrado = true;
                }
                else if (criterio == "Descripción" && implemento.Descripcion.ToLower().Contains(valorBusqueda))
                {
                    encontrado = true;
                }

                if (encontrado)
                {
                    dataGridView1.Rows.Add(implemento.Descripcion, implemento.Tipo, implemento.Anio, implemento.Descripcion);
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridView1.SelectedRows[0];

                // Extraer los valores de las celdas
                string nombreImplemento = filaSeleccionada.Cells["Tipo"].Value?.ToString() ?? "";
                string nombreDeporte = filaSeleccionada.Cells["deporte"].Value?.ToString() ?? "";
                string anioTexto = filaSeleccionada.Cells["anio"].Value?.ToString() ?? "0";
                string descripcion = filaSeleccionada.Cells["descripcion"].Value?.ToString() ?? "";

                // Asignar los valores a los controles
                txtImplementos.Text = nombreImplemento;
                txtDescripcion.Text = descripcion;

                if (int.TryParse(anioTexto, out int anio))
                {
                    txtAnio.Text = anio.ToString();
                }
                else
                {
                    txtAnio.Text = "0"; // Valor predeterminado si no es válido
                }

                cmbbox.SelectedItem = nombreDeporte; // Seleccionar el deporte en el ComboBox
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LoadImplementos();
        }
    }
}