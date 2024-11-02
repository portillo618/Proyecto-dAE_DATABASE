using Microsoft.Win32;
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
    public partial class frmUsuario : Form
    {
        BodegaContext contexto = new BodegaContext();
        public frmUsuario()
        {
            InitializeComponent();
            CargarDatos();
            LlenarComboboxes();
        }

        private void VaciarCampos()
        {
            txtbId.Clear();
            txtbNombre.Clear();
            txtbCarne.Clear();
            txtbEscuela.Clear();
            txtbDireccion.Clear();
            txtbTelefono.Clear();
            txtbContrasenia.Clear();

            // Seleccionar los elementos correspondientes en los ComboBox
            cmbbCarrera.SelectedValue = 0;
            cmbbRol.SelectedValue = 0;
        }

        private void LlenarComboboxes()
        {
            cmbbCarrera.DataSource = contexto.Carreras.ToList();
            cmbbCarrera.DisplayMember = "nombreCarrera";
            cmbbCarrera.ValueMember = "idCarrera";

            cmbbRol.DataSource = contexto.Roles.ToList();
            cmbbRol.DisplayMember = "nombreRol";
            cmbbRol.ValueMember = "idRol";
        }

        private void CargarDatos()
        {
            var datosUsuarios = from u in contexto.Usuarios
                                join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera into carrerasGroup
                                from c in carrerasGroup.DefaultIfEmpty() // LEFT JOIN
                                join r in contexto.Roles on u.IdRol equals r.IdRol
                                join e in contexto.Escuelas on c.IdEscuela equals e.IdEscuela into escuelasGroup
                                from e in escuelasGroup.DefaultIfEmpty() // LEFT JOIN para la escuela
                                select new
                                {
                                    u.IdUsuario,
                                    u.NombreUsuario,
                                    u.CarneBiblioteca,
                                    Carrera = c.NombreCarrera,
                                    Escuela = e.NombreEscuela,
                                    u.Direccion,
                                    Rol = r.NombreRol,
                                    u.Telefono,
                                    u.Contrasenia
                                };

            dataGridView1.DataSource = datosUsuarios.ToList();
            dataGridView1.Columns["IdUsuario"].HeaderText = "ID";
            dataGridView1.Columns["NombreUsuario"].HeaderText = "NOMBRE";
            dataGridView1.Columns["CarneBiblioteca"].HeaderText = "CARNÉ";
            dataGridView1.Columns["Carrera"].HeaderText = "CARRERA";
            dataGridView1.Columns["Escuela"].HeaderText = "ESCUELA";
            dataGridView1.Columns["Direccion"].HeaderText = "DIRECCIÓN";
            dataGridView1.Columns["Rol"].HeaderText = "ROL";
            dataGridView1.Columns["Telefono"].HeaderText = "TELÉFONO";
            dataGridView1.Columns["Contrasenia"].HeaderText = "CONTRASEÑA";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                txtbId.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txtbNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtbCarne.Text = dataGridView1.SelectedCells[2].Value.ToString();
                if (dataGridView1.SelectedCells[3].Value != null)
                {
                    string nombreCarrera = dataGridView1.SelectedCells[3].Value.ToString();
                    int idCarrera = contexto.Carreras.FirstOrDefault(c => c.NombreCarrera == nombreCarrera)?.IdCarrera ?? 0;
                    cmbbCarrera.SelectedValue = idCarrera;
                }
                if (dataGridView1.SelectedCells[4].Value != null)
                {
                    txtbEscuela.Text = dataGridView1.SelectedCells[4].Value.ToString();
                }
                txtbDireccion.Text = dataGridView1.SelectedCells[5].Value.ToString();
                if (dataGridView1.SelectedCells[6].Value != null)
                {
                    string nombreRol = dataGridView1.SelectedCells[6].Value.ToString();
                    int idRol = contexto.Roles.FirstOrDefault(c => c.NombreRol == nombreRol)?.IdRol ?? 0;
                    cmbbRol.SelectedValue = idRol;
                }
                txtbTelefono.Text = dataGridView1.SelectedCells[7].Value.ToString();
                txtbContrasenia.Text = dataGridView1.SelectedCells[8].Value.ToString();
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //crear obj entidad
            Usuario u = new Usuario();

            // Obtener el carné de la entrada
            int carneBiblioteca;
            if (!int.TryParse(txtbCarne.Text, out carneBiblioteca))
            {
                MessageBox.Show("El carné debe ser un número válido.");
                return;
            }

            // Comprobar si el carné ya existe
            if (contexto.Usuarios.Any(u => u.CarneBiblioteca == carneBiblioteca))
            {
                MessageBox.Show("El carné ya existe. Intenta con otro.");
                return;
            }

            string nombre = txtbNombre.Text;

            // Comprobar si el nombre ya existe
            if (contexto.Usuarios.Any(u => u.NombreUsuario == nombre))
            {
                MessageBox.Show("El nombre de usuario ya existe. Intenta con otro.");
                return;
            }

            // Obtener el teléfono de la entrada
            int telefono;
            if (!int.TryParse(txtbTelefono.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser un número válido.");
                return;
            }

            //llenar objeto del form
            u.NombreUsuario = nombre;
            u.CarneBiblioteca = carneBiblioteca;
            u.Direccion = txtbDireccion.Text;
            u.Telefono = telefono;
            u.Contrasenia = txtbContrasenia.Text;

            // Acceder a los id de los elementos seleccionados en los ComboBox

            u.IdCarrera = cmbbCarrera.SelectedValue != null && (int)cmbbCarrera.SelectedValue != 0
              ? (int?)cmbbCarrera.SelectedValue
              : null;

            u.IdRol = (int)cmbbRol.SelectedValue;

            //if para guardar registro
            try
            {
                contexto.Usuarios.Add(u);
                contexto.SaveChanges();
                MessageBox.Show("Registro guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede guardar");
            }

            CargarDatos();
            VaciarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtbId.Text);

            var regAModificar = contexto.Usuarios.Find(idUsuario);
            if (MessageBox.Show(this, "Seguro?", "Titulo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                regAModificar.NombreUsuario = txtbNombre.Text;
                regAModificar.CarneBiblioteca = int.Parse(txtbCarne.Text);
                regAModificar.Direccion = txtbDireccion.Text;
                regAModificar.Telefono = int.Parse(txtbTelefono.Text);
                regAModificar.Contrasenia = txtbContrasenia.Text;

                // Manejar el caso en que el ComboBox puede estar vacío
                regAModificar.IdCarrera = cmbbCarrera.SelectedValue != null && !string.IsNullOrEmpty(cmbbCarrera.SelectedValue.ToString())
                    ? (int?)Convert.ToInt32(cmbbCarrera.SelectedValue)
                    : null; // O un valor por defecto si no permite null
                regAModificar.IdRol = Convert.ToInt32(cmbbRol.SelectedValue);
                contexto.SaveChanges();
                CargarDatos();
                VaciarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtbId.Text);
            var regAModificar = contexto.Usuarios.Find(idUsuario);

            if (MessageBox.Show(this, "Seguro?", "Titulo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                contexto.Usuarios.Remove(regAModificar);
                contexto.SaveChanges();
                CargarDatos();
                VaciarCampos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string elegido = cmbbBuscar.Text;
            var registro = Enumerable.Empty<object>().ToArray();
            string texto = txtbBuscar.Text.Trim();

            try
            {
                switch (elegido.ToUpper())
                {
                    case "ID":
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where u.IdUsuario.ToString() == texto
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    case "NOMBRE":
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where u.NombreUsuario == texto
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    case "CARNÉ":
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where u.CarneBiblioteca.ToString() == texto
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    case "CARRERA":
                        int idCarrera = contexto.Carreras.Where(c => c.NombreCarrera == texto).Select(c => c.IdCarrera).FirstOrDefault();
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where u.IdCarrera == idCarrera
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    case "ESCUELA":
                        int idEscuela = contexto.Escuelas.Where(es => es.NombreEscuela == texto).Select(es => es.IdEscuela).FirstOrDefault();
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where c.IdEscuela == idEscuela
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    case "ROL":
                        int idRol = contexto.Roles.Where(c => c.NombreRol == texto).Select(c => c.IdRol).FirstOrDefault();
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where u.IdRol == idRol
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    case "TELÉFONO":
                        registro = (from u in contexto.Usuarios
                                    join c in contexto.Carreras on u.IdCarrera equals c.IdCarrera
                                    join r in contexto.Roles on u.IdRol equals r.IdRol
                                    join es in contexto.Escuelas on c.IdEscuela equals es.IdEscuela
                                    where u.Telefono == int.Parse(texto)
                                    select new
                                    {
                                        u.IdUsuario,
                                        u.NombreUsuario,
                                        u.CarneBiblioteca,
                                        Carrera = c.NombreCarrera,
                                        Escuela = es.NombreEscuela,
                                        u.Direccion,
                                        Rol = r.NombreRol,
                                        u.Telefono,
                                        u.Contrasenia
                                    }).ToArray();
                        break;

                    default:
                        MessageBox.Show("Ingresa todos los datos para la búsqueda");
                        break;
                }

                if (registro.Any())
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = registro;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la búsqueda: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            CargarDatos();
        }
    }
}
