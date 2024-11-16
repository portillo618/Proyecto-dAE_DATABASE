namespace proyectoDAE
{
    partial class FormImplementos
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            cmbbox = new ComboBox();
            txtImplementos = new TextBox();
            btnBuscar = new Button();
            cmbBuscar = new ComboBox();
            txtBuscar = new TextBox();
            lbAnio = new Label();
            lbImplemento = new Label();
            lbImplementos = new Label();
            lbDeporte = new Label();
            txtAnio = new TextBox();
            txtDescripcion = new TextBox();
            lbDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 388);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(761, 256);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(31, 291);
            button1.Name = "button1";
            button1.Size = new Size(122, 50);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(260, 291);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(466, 291);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(121, 50);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // cmbbox
            // 
            cmbbox.FormattingEnabled = true;
            cmbbox.Location = new Point(591, 221);
            cmbbox.Name = "cmbbox";
            cmbbox.Size = new Size(182, 33);
            cmbbox.TabIndex = 4;
            // 
            // txtImplementos
            // 
            txtImplementos.Location = new Point(21, 219);
            txtImplementos.Name = "txtImplementos";
            txtImplementos.Size = new Size(202, 31);
            txtImplementos.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(997, 252);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 50);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbBuscar
            // 
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(950, 322);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(182, 33);
            cmbBuscar.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(747, 324);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(191, 31);
            txtBuscar.TabIndex = 8;
            // 
            // lbAnio
            // 
            lbAnio.AutoSize = true;
            lbAnio.Location = new Point(248, 178);
            lbAnio.Name = "lbAnio";
            lbAnio.Size = new Size(45, 25);
            lbAnio.TabIndex = 10;
            lbAnio.Text = "Año";
            // 
            // lbImplemento
            // 
            lbImplemento.AutoSize = true;
            lbImplemento.Location = new Point(21, 178);
            lbImplemento.Name = "lbImplemento";
            lbImplemento.Size = new Size(174, 25);
            lbImplemento.TabIndex = 11;
            lbImplemento.Text = "Tipo de Implemento";
            // 
            // lbImplementos
            // 
            lbImplementos.AutoSize = true;
            lbImplementos.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbImplementos.Location = new Point(451, 30);
            lbImplementos.Name = "lbImplementos";
            lbImplementos.Size = new Size(359, 38);
            lbImplementos.TabIndex = 12;
            lbImplementos.Text = "Gestion de Implementos";
            // 
            // lbDeporte
            // 
            lbDeporte.AutoSize = true;
            lbDeporte.Location = new Point(591, 178);
            lbDeporte.Name = "lbDeporte";
            lbDeporte.Size = new Size(179, 25);
            lbDeporte.TabIndex = 13;
            lbDeporte.Text = "Deporte Implemento";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(248, 221);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(111, 31);
            txtAnio.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(382, 221);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(182, 31);
            txtDescripcion.TabIndex = 15;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(382, 178);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(104, 25);
            lbDescripcion.TabIndex = 16;
            lbDescripcion.Text = "Descripcion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 656);
            Controls.Add(lbDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtAnio);
            Controls.Add(lbDeporte);
            Controls.Add(lbImplementos);
            Controls.Add(lbImplemento);
            Controls.Add(lbAnio);
            Controls.Add(txtBuscar);
            Controls.Add(cmbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(txtImplementos);
            Controls.Add(cmbbox);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEliminar;
        private Button btnEditar;
        private ComboBox cmbbox;
        private TextBox txtImplementos;
        private Button btnBuscar;
        private ComboBox cmbBuscar;
        private TextBox txtBuscar;
        private TextBox txtCantidad;
        private Label lbAnio;
        private Label lbImplemento;
        private Label lbImplementos;
        private Label lbDeporte;
        private TextBox txtAnio;
        private TextBox txtDescripcion;
        private Label lbDescripcion;
    }
}
