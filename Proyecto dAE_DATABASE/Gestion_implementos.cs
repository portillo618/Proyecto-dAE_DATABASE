namespace proyectoDAE
{
    public partial class Form1 : Form
    {
        private string[] nombresImplementos = new string[100];
        private string[] tiposImplementos = new string[100];
        private int[] aniosImplementos = new int[100];
        private string[] descripcionesImplementos = new string[100];
        private int contadorImplementos = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los deportes
            cmbbox.Items.Add("Fútbol");
            cmbbox.Items.Add("Baloncesto");
            cmbbox.Items.Add("Tenis");
            cmbbox.Items.Add("Voleibol");
            cmbbox.Items.Add("Cronómetro digital");

            // Configurar columnas del DataGridView
            dataGridView1.Columns.Add("nombreImplemento", "Nombre del Implemento");
            dataGridView1.Columns.Add("deporte", "Deporte");
            dataGridView1.Columns.Add("anio", "Año");
            dataGridView1.Columns.Add("descripcion", "Descripción");

            // Llenar el ComboBox de búsqueda
            cmbBuscar.Items.Add("Nombre del Implemento");
            cmbBuscar.Items.Add("Tipo de Deporte");
            cmbBuscar.Items.Add("Año");
            cmbBuscar.Items.Add("Descripción");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtImplementos.Text) || cmbbox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtAnio.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string nombreImplemento = txtImplementos.Text;
            string deporte = cmbbox.SelectedItem.ToString();

            // Validar que el año sea un número válido
            if (!int.TryParse(txtAnio.Text, out int anio) || anio <= 0)
            {
                MessageBox.Show("Ingrese un año válido.");
                return;
            }

            string descripcion = txtDescripcion.Text;

            if (contadorImplementos < nombresImplementos.Length)
            {
                // Agregar los valores
                nombresImplementos[contadorImplementos] = nombreImplemento;
                tiposImplementos[contadorImplementos] = deporte;
                aniosImplementos[contadorImplementos] = anio;
                descripcionesImplementos[contadorImplementos] = descripcion;

                // Actualizar el DataGridView
                dataGridView1.Rows.Add(nombreImplemento, deporte, anio, descripcion);

                // Incrementar el contador
                contadorImplementos++;

                MessageBox.Show("Implemento agregado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pueden agregar más implementos, se ha alcanzado el límite.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                // Eliminar implemento
                dataGridView1.Rows.RemoveAt(index);

                for (int i = index; i < contadorImplementos - 1; i++)
                {
                    nombresImplementos[i] = nombresImplementos[i + 1];
                    tiposImplementos[i] = tiposImplementos[i + 1];
                    aniosImplementos[i] = aniosImplementos[i + 1];
                    descripcionesImplementos[i] = descripcionesImplementos[i + 1];
                }

                // Reducir el contador de implementos
                contadorImplementos--;

                MessageBox.Show("Implemento eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Seleccione un implemento para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                // Obtener los valores actuales de los controles
                string nuevoNombre = txtImplementos.Text;
                string nuevoDeporte = cmbbox.SelectedItem != null ? cmbbox.SelectedItem.ToString() : "";
                bool anioValido = int.TryParse(txtAnio.Text, out int nuevoAnio);
                string nuevaDescripcion = txtDescripcion.Text;

                if (!string.IsNullOrWhiteSpace(nuevoNombre) && !string.IsNullOrWhiteSpace(nuevoDeporte) &&
                    anioValido && !string.IsNullOrWhiteSpace(nuevaDescripcion))
                {
                    // Actualizar los valores
                    nombresImplementos[index] = nuevoNombre;
                    tiposImplementos[index] = nuevoDeporte;
                    aniosImplementos[index] = nuevoAnio;
                    descripcionesImplementos[index] = nuevaDescripcion;

                    // Actualizar el DataGridView
                    dataGridView1.Rows[index].Cells[0].Value = nuevoNombre;
                    dataGridView1.Rows[index].Cells[1].Value = nuevoDeporte;
                    dataGridView1.Rows[index].Cells[2].Value = nuevoAnio;
                    dataGridView1.Rows[index].Cells[3].Value = nuevaDescripcion;

                    MessageBox.Show("Implemento editado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un implemento para editar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de mostrar los resultados
            dataGridView1.Rows.Clear();

            string criterio = cmbBuscar.SelectedItem?.ToString();
            string valorBusqueda = txtBuscar.Text.ToLower();

            // Verificar que se haya seleccionado y que no esté vacío
            if (string.IsNullOrWhiteSpace(criterio) || string.IsNullOrWhiteSpace(valorBusqueda))
            {
                MessageBox.Show("Seleccione un criterio de búsqueda y escriba un valor.");
                return;
            }

            // Realizar la búsqueda
            for (int i = 0; i < contadorImplementos; i++)
            {
                bool encontrado = false;

                // Buscar por criterio
                if (criterio == "Nombre del Implemento" && nombresImplementos[i].ToLower().Contains(valorBusqueda))
                {
                    encontrado = true;
                }
                else if (criterio == "Tipo de Deporte" && tiposImplementos[i].ToLower().Contains(valorBusqueda))
                {
                    encontrado = true;
                }
                else if (criterio == "Año" && aniosImplementos[i].ToString() == valorBusqueda)
                {
                    encontrado = true;
                }
                else if (criterio == "Descripción" && descripcionesImplementos[i].ToLower().Contains(valorBusqueda))
                {
                    encontrado = true;
                }

                // Si se encontró el resultado, agregarlo
                if (encontrado)
                {
                    dataGridView1.Rows.Add(nombresImplementos[i], tiposImplementos[i], aniosImplementos[i], descripcionesImplementos[i]);
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


