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
            btnCancelar = new Button();
            btnActualizarEstado = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(58, 68);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(244, 27);
            txtIDUsuario.TabIndex = 0;
            // 
            // txtNombreReceptor
            // 
            txtNombreReceptor.Location = new Point(387, 68);
            txtNombreReceptor.Name = "txtNombreReceptor";
            txtNombreReceptor.Size = new Size(240, 27);
            txtNombreReceptor.TabIndex = 1;
            // 
            // lblcarne
            // 
            lblcarne.AutoSize = true;
            lblcarne.Location = new Point(58, 98);
            lblcarne.Name = "lblcarne";
            lblcarne.Size = new Size(47, 20);
            lblcarne.TabIndex = 3;
            lblcarne.Text = "Carne";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(387, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(124, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre receptor";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(58, 257);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(862, 314);
            dgvPrestamos.TabIndex = 5;
            dgvPrestamos.CellContentClick += dgvPrestamos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(58, 158);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "BUSCAR PRESTAMO";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarDev
            // 
            btnConfirmarDev.Location = new Point(259, 158);
            btnConfirmarDev.Name = "btnConfirmarDev";
            btnConfirmarDev.Size = new Size(226, 29);
            btnConfirmarDev.TabIndex = 7;
            btnConfirmarDev.Text = "CONFIRMAR DEVOLUCIÓN";
            btnConfirmarDev.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(528, 158);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(187, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Location = new Point(756, 158);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(204, 29);
            btnActualizarEstado.TabIndex = 9;
            btnActualizarEstado.Text = "ACTUALIZAR ESTADO";
            btnActualizarEstado.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(835, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 583);
            Controls.Add(textBox1);
            Controls.Add(btnActualizarEstado);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarDev);
            Controls.Add(btnBuscar);
            Controls.Add(dgvPrestamos);
            Controls.Add(lblNombre);
            Controls.Add(lblcarne);
            Controls.Add(txtNombreReceptor);
            Controls.Add(txtIDUsuario);
            Name = "Devoluciones";
            Text = "Form1";
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
        private Button btnCancelar;
        private Button btnActualizarEstado;
        private TextBox textBox1;
    }
}
