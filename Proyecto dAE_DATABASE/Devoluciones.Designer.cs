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
            txtEstado = new TextBox();
            label2 = new Label();
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
            lblcarne.Size = new Size(71, 20);
            lblcarne.TabIndex = 3;
            lblcarne.Text = "USUARIO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(387, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "IMPLEMENTO";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPrestamos.Location = new Point(28, 234);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1059, 337);
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
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConfirmarDev
            // 
            btnConfirmarDev.Location = new Point(259, 158);
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
            label1.Location = new Point(677, 98);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 8;
            label1.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(677, 68);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(160, 27);
            txtCantidad.TabIndex = 9;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(901, 68);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(901, 98);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "ESTADO";
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 583);
            Controls.Add(label2);
            Controls.Add(txtEstado);
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
        private Label label1;
        private TextBox txtCantidad;
        private TextBox txtEstado;
        private Label label2;
    }
}
