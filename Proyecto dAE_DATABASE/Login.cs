using Proyecto_dAE_DATABASE.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_dAE_DATABASE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BodegaContext contexto = new BodegaContext();
                int carneBiblioteca;

                // Verificar si el CarneBiblioteca es un número válido
                if (int.TryParse(txtbUsuario.Text, out carneBiblioteca))
                {
                    var usuario = contexto.Usuarios.Where(x => x.CarneBiblioteca == carneBiblioteca &&
                                                              x.Contrasenia.Equals(txtbContrasenia.Text)).ToArray();
                    if (usuario.Length > 0)
                    {
                        Usuario us = new Usuario
                        {
                            IdUsuario = usuario[0].IdUsuario,
                            NombreUsuario = usuario[0].NombreUsuario,
                            IdRol = usuario[0].IdRol
                        };

                        // Pasar el usuario logueado a la clase Principal
                        Principal principal = new Principal(us);
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sus credenciales son erróneas");
                    }
                }
                else
                {
                    MessageBox.Show("El CarneBiblioteca debe ser un número válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
