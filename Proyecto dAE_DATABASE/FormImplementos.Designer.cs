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
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 232);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(533, 154);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 175);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(182, 175);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(326, 175);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 30);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // cmbbox
            // 
            cmbbox.FormattingEnabled = true;
            cmbbox.Location = new Point(414, 133);
            cmbbox.Margin = new Padding(2);
            cmbbox.Name = "cmbbox";
            cmbbox.Size = new Size(128, 23);
            cmbbox.TabIndex = 4;
            // 
            // txtImplementos
            // 
            txtImplementos.Location = new Point(15, 131);
            txtImplementos.Margin = new Padding(2);
            txtImplementos.Name = "txtImplementos";
            txtImplementos.Size = new Size(142, 23);
            txtImplementos.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(698, 152);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 30);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbBuscar
            // 
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(665, 194);
            cmbBuscar.Margin = new Padding(2);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(128, 23);
            cmbBuscar.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(523, 194);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(135, 23);
            txtBuscar.TabIndex = 8;
            // 
            // lbAnio
            // 
            lbAnio.AutoSize = true;
            lbAnio.Location = new Point(173, 106);
            lbAnio.Margin = new Padding(2, 0, 2, 0);
            lbAnio.Name = "lbAnio";
            lbAnio.Size = new Size(29, 15);
            lbAnio.TabIndex = 10;
            lbAnio.Text = "Año";
            // 
            // lbImplemento
            // 
            lbImplemento.AutoSize = true;
            lbImplemento.Location = new Point(15, 106);
            lbImplemento.Margin = new Padding(2, 0, 2, 0);
            lbImplemento.Name = "lbImplemento";
            lbImplemento.Size = new Size(114, 15);
            lbImplemento.TabIndex = 11;
            lbImplemento.Text = "Tipo de Implemento";
            // 
            // lbImplementos
            // 
            lbImplementos.AutoSize = true;
            lbImplementos.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbImplementos.Location = new Point(316, 18);
            lbImplementos.Margin = new Padding(2, 0, 2, 0);
            lbImplementos.Name = "lbImplementos";
            lbImplementos.Size = new Size(241, 25);
            lbImplementos.TabIndex = 12;
            lbImplementos.Text = "Gestion de Implementos";
            // 
            // lbDeporte
            // 
            lbDeporte.AutoSize = true;
            lbDeporte.Location = new Point(414, 106);
            lbDeporte.Margin = new Padding(2, 0, 2, 0);
            lbDeporte.Name = "lbDeporte";
            lbDeporte.Size = new Size(117, 15);
            lbDeporte.TabIndex = 13;
            lbDeporte.Text = "Deporte Implemento";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(173, 133);
            txtAnio.Margin = new Padding(2);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(79, 23);
            txtAnio.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(268, 133);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(128, 23);
            txtDescripcion.TabIndex = 15;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(268, 106);
            lbDescripcion.Margin = new Padding(2, 0, 2, 0);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(69, 15);
            lbDescripcion.TabIndex = 16;
            lbDescripcion.Text = "Descripcion";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(574, 152);
            btnRefrescar.Margin = new Padding(2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(84, 30);
            btnRefrescar.TabIndex = 17;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // FormImplementos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 394);
            Controls.Add(btnRefrescar);
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
            Margin = new Padding(2);
            Name = "FormImplementos";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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
        private Button btnRefrescar;
    }
}
