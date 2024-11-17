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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BodegaContext contexto = new BodegaContext();
                var usuario = contexto.Usuarios.Where(x => x.CarneBiblioteca == int.Parse(txtbUsuario.Text) &&
                                                      x.Contrasenia.Equals(txtbContrasenia.Text)).ToArray();
                if (usuario.Length > 0)
                {
                    Usuario us = new Usuario();
                    us.IdUsuario = usuario[0].IdUsuario;
                    us.NombreUsuario = usuario[0].NombreUsuario;
                    us.IdRol = usuario[0].IdRol;
                    Principal principal = new Principal(us);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sus credenciales son erróneas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación antes de salir (opcional)
            var result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cierra la aplicación
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
