namespace Proyecto_dAE_DATABASE
{
    partial class IngresoMaterialNuevo
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            nudFactura = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            nudImplemento = new NumericUpDown();
            nudCantidad = new NumericUpDown();
            label4 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            cmbParametro = new ComboBox();
            txtbBusqueda = new TextBox();
            btnBuscar = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtbImplemento = new TextBox();
            txtbDeporte = new TextBox();
            btnRefrescar = new Button();
            btnGenerarFactura = new Button();
            label5 = new Label();
            rtbDescripcion = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudImplemento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 28);
            label1.Name = "label1";
            label1.Size = new Size(486, 32);
            label1.TabIndex = 0;
            label1.Text = "INGRESO DE MATERIAL NUEVO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 543);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(887, 239);
            dataGridView1.TabIndex = 1;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // nudFactura
            // 
            nudFactura.Location = new Point(61, 229);
            nudFactura.Margin = new Padding(3, 4, 3, 4);
            nudFactura.Name = "nudFactura";
            nudFactura.Size = new Size(137, 27);
            nudFactura.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 205);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 4;
            label2.Text = "Número de Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 112);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Implemento Id";
            // 
            // nudImplemento
            // 
            nudImplemento.Location = new Point(61, 136);
            nudImplemento.Margin = new Padding(3, 4, 3, 4);
            nudImplemento.Name = "nudImplemento";
            nudImplemento.Size = new Size(137, 27);
            nudImplemento.TabIndex = 6;
            nudImplemento.ValueChanged += nudImplemento_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(248, 229);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(137, 27);
            nudCantidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 205);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 8;
            label4.Text = "Cantidad Entrante";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 480);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(153, 480);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(270, 480);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbParametro
            // 
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "Número de Factura", "ID del Implemento" });
            cmbParametro.Location = new Point(704, 481);
            cmbParametro.Margin = new Padding(3, 4, 3, 4);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(178, 28);
            cmbParametro.TabIndex = 14;
            // 
            // txtbBusqueda
            // 
            txtbBusqueda.Location = new Point(496, 481);
            txtbBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbBusqueda.Name = "txtbBusqueda";
            txtbBusqueda.Size = new Size(185, 27);
            txtbBusqueda.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(496, 443);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(709, 444);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 17;
            label6.Text = "Parámetro de Búsqueda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 112);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 18;
            label7.Text = "Nombre Implemento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(475, 112);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 19;
            label8.Text = "Deporte Implemento";
            // 
            // txtbImplemento
            // 
            txtbImplemento.Location = new Point(248, 136);
            txtbImplemento.Margin = new Padding(3, 4, 3, 4);
            txtbImplemento.Name = "txtbImplemento";
            txtbImplemento.ReadOnly = true;
            txtbImplemento.Size = new Size(180, 27);
            txtbImplemento.TabIndex = 20;
            // 
            // txtbDeporte
            // 
            txtbDeporte.Location = new Point(475, 136);
            txtbDeporte.Margin = new Padding(3, 4, 3, 4);
            txtbDeporte.Name = "txtbDeporte";
            txtbDeporte.ReadOnly = true;
            txtbDeporte.Size = new Size(180, 27);
            txtbDeporte.TabIndex = 21;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(496, 404);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(86, 31);
            btnRefrescar.TabIndex = 22;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(41, 439);
            btnGenerarFactura.Margin = new Padding(3, 4, 3, 4);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(127, 31);
            btnGenerarFactura.TabIndex = 23;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 205);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 24;
            label5.Text = "Cantidad Entrante";
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(448, 229);
            rtbDescripcion.Margin = new Padding(3, 4, 3, 4);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(338, 99);
            rtbDescripcion.TabIndex = 25;
            rtbDescripcion.Text = "";
            // 
            // IngresoMaterialNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 963);
            Controls.Add(rtbDescripcion);
            Controls.Add(label5);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnRefrescar);
            Controls.Add(txtbDeporte);
            Controls.Add(txtbImplemento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnBuscar);
            Controls.Add(txtbBusqueda);
            Controls.Add(cmbParametro);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(nudCantidad);
            Controls.Add(nudImplemento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudFactura);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IngresoMaterialNuevo";
            Text = "IngresoMaterialNuevo";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudImplemento).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private NumericUpDown nudFactura;
        private Label label2;
        private Label label3;
        private NumericUpDown nudImplemento;
        private NumericUpDown nudCantidad;
        private Label label4;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ComboBox cmbParametro;
        private TextBox txtbBusqueda;
        private Button btnBuscar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtbImplemento;
        private TextBox txtbDeporte;
        private Button btnRefrescar;
        private Button btnGenerarFactura;
        private Label label5;
        private RichTextBox rtbDescripcion;
    }
}