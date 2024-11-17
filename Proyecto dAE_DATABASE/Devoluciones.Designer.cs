namespace Proyecto_dAE_DATABASE
{
    partial class Devoluciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIDUsuario = new TextBox();
            txtNombreReceptor = new TextBox();
            lblcarne = new Label();
            lblNombre = new Label();
            dgvPrestamos = new DataGridView();
            btnBuscar = new Button();
            btnConfirmarDev = new Button();
            label1 = new Label();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(12, 120);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(135, 27);
            txtIDUsuario.TabIndex = 0;
            // 
            // txtNombreReceptor
            // 
            txtNombreReceptor.Enabled = false;
            txtNombreReceptor.Location = new Point(179, 120);
            txtNombreReceptor.Name = "txtNombreReceptor";
            txtNombreReceptor.Size = new Size(201, 27);
            txtNombreReceptor.TabIndex = 1;
            // 
            // lblcarne
            // 
            lblcarne.AutoSize = true;
            lblcarne.Location = new Point(12, 150);
            lblcarne.Name = "lblcarne";
            lblcarne.Size = new Size(71, 20);
            lblcarne.TabIndex = 3;
            lblcarne.Text = "USUARIO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(179, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "IMPLEMENTO";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPrestamos.Location = new Point(10, 288);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(802, 249);
            dgvPrestamos.TabIndex = 5;
            dgvPrestamos.CellContentClick += dgvPrestamos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(254, 222);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(226, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "BUSCAR PRESTAMO";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConfirmarDev
            // 
            btnConfirmarDev.Location = new Point(10, 222);
            btnConfirmarDev.Name = "btnConfirmarDev";
            btnConfirmarDev.Size = new Size(226, 29);
            btnConfirmarDev.TabIndex = 7;
            btnConfirmarDev.Text = "MODIFICAR ESTADO";
            btnConfirmarDev.UseVisualStyleBackColor = true;
            btnConfirmarDev.Click += btnConfirmarDev_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 150);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 8;
            label1.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(431, 120);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(144, 27);
            txtCantidad.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(611, 151);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 20F);
            label3.Location = new Point(279, 36);
            label3.Name = "label3";
            label3.Size = new Size(282, 38);
            label3.TabIndex = 13;
            label3.Text = "DEVOLUCIONES";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Devuelto", "Dañado", "Perdido" });
            cmbEstado.Location = new Point(611, 120);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(124, 28);
            cmbEstado.TabIndex = 14;
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(826, 545);
            Controls.Add(cmbEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(btnConfirmarDev);
            Controls.Add(btnBuscar);
            Controls.Add(dgvPrestamos);
            Controls.Add(lblNombre);
            Controls.Add(lblcarne);
            Controls.Add(txtNombreReceptor);
            Controls.Add(txtIDUsuario);
            Name = "Devoluciones";
            Text = "Gestión Devoluciones";
            WindowState = FormWindowState.Maximized;
            Load += Devoluciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDUsuario;
        private TextBox txtNombreReceptor;
        private Label lblcarne;
        private Label lblNombre;
        private DataGridView dgvPrestamos;
        private Button btnBuscar;
        private Button btnConfirmarDev;
        private Label label1;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private ComboBox cmbEstado;
    }
}
