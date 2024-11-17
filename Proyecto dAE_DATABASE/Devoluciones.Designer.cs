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
            txtUsuarioDevolucion = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(108, 119);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(135, 27);
            txtIDUsuario.TabIndex = 0;
            // 
            // txtNombreReceptor
            // 
            txtNombreReceptor.Enabled = false;
            txtNombreReceptor.Location = new Point(319, 119);
            txtNombreReceptor.Name = "txtNombreReceptor";
            txtNombreReceptor.Size = new Size(201, 27);
            txtNombreReceptor.TabIndex = 1;
            // 
            // lblcarne
            // 
            lblcarne.AutoSize = true;
            lblcarne.Location = new Point(108, 149);
            lblcarne.Name = "lblcarne";
            lblcarne.Size = new Size(71, 20);
            lblcarne.TabIndex = 3;
            lblcarne.Text = "USUARIO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(319, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "IMPLEMENTO";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPrestamos.Location = new Point(137, 409);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(925, 231);
            dgvPrestamos.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(837, 290);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(225, 87);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "BUSCAR PRESTAMO";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarDev
            // 
            btnConfirmarDev.Location = new Point(137, 290);
            btnConfirmarDev.Name = "btnConfirmarDev";
            btnConfirmarDev.Size = new Size(224, 87);
            btnConfirmarDev.TabIndex = 7;
            btnConfirmarDev.Text = "MODIFICAR ESTADO";
            btnConfirmarDev.UseVisualStyleBackColor = true;
            btnConfirmarDev.Click += btnConfirmarDev_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 149);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 8;
            label1.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(577, 119);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(144, 27);
            txtCantidad.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(771, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 20F);
            label3.Location = new Point(475, 41);
            label3.Name = "label3";
            label3.Size = new Size(282, 38);
            label3.TabIndex = 13;
            label3.Text = "DEVOLUCIONES";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Devuelto", "Dañado", "Perdido" });
            cmbEstado.Location = new Point(771, 119);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(124, 28);
            cmbEstado.TabIndex = 14;
            // 
            // txtUsuarioDevolucion
            // 
            txtUsuarioDevolucion.Location = new Point(931, 120);
            txtUsuarioDevolucion.Name = "txtUsuarioDevolucion";
            txtUsuarioDevolucion.Size = new Size(159, 27);
            txtUsuarioDevolucion.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(931, 149);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 16;
            label4.Text = "Encargado de devolución";
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1182, 694);
            Controls.Add(label4);
            Controls.Add(txtUsuarioDevolucion);
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
        private TextBox txtUsuarioDevolucion;
        private Label label4;
    }
}
