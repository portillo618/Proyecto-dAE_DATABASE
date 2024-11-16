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
            label1.Location = new Point(206, 21);
            label1.Name = "label1";
            label1.Size = new Size(376, 25);
            label1.TabIndex = 0;
            label1.Text = "INGRESO DE MATERIAL NUEVO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 407);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 179);
            dataGridView1.TabIndex = 1;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // nudFactura
            // 
            nudFactura.Location = new Point(53, 172);
            nudFactura.Name = "nudFactura";
            nudFactura.Size = new Size(120, 23);
            nudFactura.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 154);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 4;
            label2.Text = "Número de Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 84);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Implemento Id";
            // 
            // nudImplemento
            // 
            nudImplemento.Location = new Point(53, 102);
            nudImplemento.Name = "nudImplemento";
            nudImplemento.Size = new Size(120, 23);
            nudImplemento.TabIndex = 6;
            nudImplemento.ValueChanged += nudImplemento_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(217, 172);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 154);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "Cantidad Entrante";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(36, 360);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(134, 360);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(236, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbParametro
            // 
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "Número de Factura", "ID del Implemento" });
            cmbParametro.Location = new Point(616, 361);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(156, 23);
            cmbParametro.TabIndex = 14;
            // 
            // txtbBusqueda
            // 
            txtbBusqueda.Location = new Point(434, 361);
            txtbBusqueda.Name = "txtbBusqueda";
            txtbBusqueda.Size = new Size(162, 23);
            txtbBusqueda.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(434, 332);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(620, 333);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 17;
            label6.Text = "Parámetro de Búsqueda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 84);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 18;
            label7.Text = "Nombre Implemento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 84);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 19;
            label8.Text = "Deporte Implemento";
            // 
            // txtbImplemento
            // 
            txtbImplemento.Location = new Point(217, 102);
            txtbImplemento.Name = "txtbImplemento";
            txtbImplemento.ReadOnly = true;
            txtbImplemento.Size = new Size(158, 23);
            txtbImplemento.TabIndex = 20;
            // 
            // txtbDeporte
            // 
            txtbDeporte.Location = new Point(416, 102);
            txtbDeporte.Name = "txtbDeporte";
            txtbDeporte.ReadOnly = true;
            txtbDeporte.Size = new Size(158, 23);
            txtbDeporte.TabIndex = 21;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(434, 303);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(75, 23);
            btnRefrescar.TabIndex = 22;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(36, 329);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(111, 23);
            btnGenerarFactura.TabIndex = 23;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 154);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 24;
            label5.Text = "Cantidad Entrante";
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(392, 172);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(296, 75);
            rtbDescripcion.TabIndex = 25;
            rtbDescripcion.Text = "";
            // 
            // IngresoMaterialNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 722);
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
            Name = "IngresoMaterialNuevo";
            Text = "IngresoMaterialNuevo";
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