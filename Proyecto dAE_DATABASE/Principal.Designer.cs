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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uSUARIOToolStripMenuItem, pRESTAMOSToolStripMenuItem, dEVOLUCIONESToolStripMenuItem });
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(65, 24);
            mENUToolStripMenuItem.Text = "MENU";
            mENUToolStripMenuItem.Click += mENUToolStripMenuItem_Click;
            // 
            // uSUARIOToolStripMenuItem
            // 
            uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            uSUARIOToolStripMenuItem.Size = new Size(224, 26);
            uSUARIOToolStripMenuItem.Text = "USUARIO";
            uSUARIOToolStripMenuItem.Click += uSUARIOToolStripMenuItem_Click;
            // 
            // pRESTAMOSToolStripMenuItem
            // 
            pRESTAMOSToolStripMenuItem.Name = "pRESTAMOSToolStripMenuItem";
            pRESTAMOSToolStripMenuItem.Size = new Size(224, 26);
            pRESTAMOSToolStripMenuItem.Text = "PRESTAMOS";
            // 
            // dEVOLUCIONESToolStripMenuItem
            // 
            dEVOLUCIONESToolStripMenuItem.Name = "dEVOLUCIONESToolStripMenuItem";
            dEVOLUCIONESToolStripMenuItem.Size = new Size(224, 26);
            dEVOLUCIONESToolStripMenuItem.Text = "DEVOLUCIONES";
            dEVOLUCIONESToolStripMenuItem.Click += dEVOLUCIONESToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}