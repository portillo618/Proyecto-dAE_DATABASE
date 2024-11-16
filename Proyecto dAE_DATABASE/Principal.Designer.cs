namespace Proyecto_dAE_DATABASE
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            uSUARIOToolStripMenuItem = new ToolStripMenuItem();
            pRESTAMOSToolStripMenuItem = new ToolStripMenuItem();
            dEVOLUCIONESToolStripMenuItem = new ToolStripMenuItem();
            gESTIONDEIMPLEMENTOSToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uSUARIOToolStripMenuItem, pRESTAMOSToolStripMenuItem, dEVOLUCIONESToolStripMenuItem, gESTIONDEIMPLEMENTOSToolStripMenuItem });
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(78, 29);
            mENUToolStripMenuItem.Text = "MENU";
            mENUToolStripMenuItem.Click += mENUToolStripMenuItem_Click;
            // 
            // uSUARIOToolStripMenuItem
            // 
            uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            uSUARIOToolStripMenuItem.Size = new Size(336, 34);
            uSUARIOToolStripMenuItem.Text = "USUARIO";
            uSUARIOToolStripMenuItem.Click += uSUARIOToolStripMenuItem_Click;
            // 
            // pRESTAMOSToolStripMenuItem
            // 
            pRESTAMOSToolStripMenuItem.Name = "pRESTAMOSToolStripMenuItem";
            pRESTAMOSToolStripMenuItem.Size = new Size(336, 34);
            pRESTAMOSToolStripMenuItem.Text = "PRESTAMOS";
            pRESTAMOSToolStripMenuItem.Click += pRESTAMOSToolStripMenuItem_Click;
            // 
            // dEVOLUCIONESToolStripMenuItem
            // 
            dEVOLUCIONESToolStripMenuItem.Name = "dEVOLUCIONESToolStripMenuItem";
            dEVOLUCIONESToolStripMenuItem.Size = new Size(336, 34);
            dEVOLUCIONESToolStripMenuItem.Text = "DEVOLUCIONES";
            dEVOLUCIONESToolStripMenuItem.Click += dEVOLUCIONESToolStripMenuItem_Click;
            // 
            // gESTIONDEIMPLEMENTOSToolStripMenuItem
            // 
            gESTIONDEIMPLEMENTOSToolStripMenuItem.Name = "gESTIONDEIMPLEMENTOSToolStripMenuItem";
            gESTIONDEIMPLEMENTOSToolStripMenuItem.Size = new Size(336, 34);
            gESTIONDEIMPLEMENTOSToolStripMenuItem.Text = "GESTION DE IMPLEMENTOS";
            gESTIONDEIMPLEMENTOSToolStripMenuItem.Click += gESTIONDEIMPLEMENTOSToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Principal";
            Text = "Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem uSUARIOToolStripMenuItem;
        private ToolStripMenuItem pRESTAMOSToolStripMenuItem;
        private ToolStripMenuItem dEVOLUCIONESToolStripMenuItem;
        private ToolStripMenuItem gESTIONDEIMPLEMENTOSToolStripMenuItem;
    }
}