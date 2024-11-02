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
    public partial class Principal : Form
    {
        public Usuario usuario = new Usuario();
        public Principal(Usuario us)
        {
            InitializeComponent();
            this.usuario = us;
            this.IsMdiContainer = true; // Esta línea es crucial para evitar el error
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.usuario.IdRol == 3)
            {
                frmUsuario frmUs = new frmUsuario();
                frmUs.MdiParent = this;
                frmUs.Show();

            }
            else
            {
                MessageBox.Show("No tienes permisos");
            }
        }
    }
}
