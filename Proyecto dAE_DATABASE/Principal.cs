using Prestaform;
using Proyecto_dAE_DATABASE.Modelo;
using proyectoDAE;
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

        private void dEVOLUCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.usuario.IdRol == 3)
            {
                Devoluciones frmde = new Devoluciones();
                frmde.MdiParent = this;
                frmde.Show();

            }
            else
            {
                MessageBox.Show("No tienes permisos");
            }
        }

        private void pRESTAMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmde = new Form1();
            frmde.MdiParent = this;
            frmde.Show();
        }

        private void gESTIONDEIMPLEMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.usuario.IdRol == 2 || this.usuario.IdRol == 3)
            {
                FormImplementos frmdes = new FormImplementos();
                frmdes.MdiParent = this;
                frmdes.Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a esta funcionalidad.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iNGRESOMATERIALNUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.usuario.IdRol == 3)
            {
                IngresoMaterialNuevo frmde = new IngresoMaterialNuevo();
                frmde.MdiParent = this;
                frmde.Show();

            }
            else
            {
                MessageBox.Show("No tienes permisos");
            }
        }
    }
}

