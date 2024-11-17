namespace Prestaform
{
    partial class Form1
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
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNombre = new Label();
            lblCarrera = new Label();
            lblEscuela = new Label();
            DataGridPrestamos = new DataGridView();
            txtCarnet = new TextBox();
            txtEcargado = new TextBox();
            cbTipoImplemento = new ComboBox();
            label7 = new Label();
            numCantidad = new NumericUpDown();
            label8 = new Label();
            label4 = new Label();
            txtbNombre = new TextBox();
            txtbCarrera = new TextBox();
            txtbEscuela = new TextBox();
            label5 = new Label();
            txtbDescripcion = new RichTextBox();
            label6 = new Label();
            label9 = new Label();
            dtPrestamo = new DateTimePicker();
            dtDevolucion = new DateTimePicker();
            cmbDeporte = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(30, 209);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Usuario";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(75, 644);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Prestamo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(314, 644);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(569, 644);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(171, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Registro";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 12);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 6;
            label1.Text = "PRESTAMOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 168);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingrese Carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(870, 317);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 8;
            label3.Text = "ID de encargado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(326, 133);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(139, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre de Usuario";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(543, 133);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 10;
            lblCarrera.Text = "Carrera";
            // 
            // lblEscuela
            // 
            lblEscuela.AutoSize = true;
            lblEscuela.Location = new Point(760, 133);
            lblEscuela.Name = "lblEscuela";
            lblEscuela.Size = new Size(58, 20);
            lblEscuela.TabIndex = 11;
            lblEscuela.Text = "Escuela";
            // 
            // DataGridPrestamos
            // 
            DataGridPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPrestamos.Location = new Point(14, 712);
            DataGridPrestamos.Name = "DataGridPrestamos";
            DataGridPrestamos.RowHeadersWidth = 51;
            DataGridPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridPrestamos.Size = new Size(1111, 220);
            DataGridPrestamos.TabIndex = 12;
            DataGridPrestamos.CellContentClick += DataGridPrestamos_CellContentClick;
            DataGridPrestamos.Click += DataGridPrestamos_Click;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(151, 168);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(125, 27);
            txtCarnet.TabIndex = 13;
            // 
            // txtEcargado
            // 
            txtEcargado.Location = new Point(983, 313);
            txtEcargado.Name = "txtEcargado";
            txtEcargado.Size = new Size(125, 27);
            txtEcargado.TabIndex = 14;
            // 
            // cbTipoImplemento
            // 
            cbTipoImplemento.FormattingEnabled = true;
            cbTipoImplemento.Items.AddRange(new object[] { "Red de Voleibol", "Raqueta", "Cronometro" });
            cbTipoImplemento.Location = new Point(167, 313);
            cbTipoImplemento.Name = "cbTipoImplemento";
            cbTipoImplemento.Size = new Size(151, 28);
            cbTipoImplemento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 317);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 16;
            label7.Text = "Tipo de Implemento";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(681, 313);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
            numCantidad.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(611, 317);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 18;
            label8.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 317);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 19;
            label4.Text = "Deporte";
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(326, 168);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.ReadOnly = true;
            txtbNombre.Size = new Size(210, 27);
            txtbNombre.TabIndex = 21;
            // 
            // txtbCarrera
            // 
            txtbCarrera.Location = new Point(543, 168);
            txtbCarrera.Name = "txtbCarrera";
            txtbCarrera.ReadOnly = true;
            txtbCarrera.Size = new Size(210, 27);
            txtbCarrera.TabIndex = 22;
            // 
            // txtbEscuela
            // 
            txtbEscuela.Location = new Point(760, 168);
            txtbEscuela.Name = "txtbEscuela";
            txtbEscuela.ReadOnly = true;
            txtbEscuela.Size = new Size(348, 27);
            txtbEscuela.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 387);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 24;
            label5.Text = "Descripción";
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(167, 383);
            txtbDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(402, 196);
            txtbDescripcion.TabIndex = 25;
            txtbDescripcion.Text = "";
            txtbDescripcion.TextChanged += richTextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 387);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 26;
            label6.Text = "FechaPrestamo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(611, 460);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 27;
            label9.Text = "FechaDevolucion";
            // 
            // dtPrestamo
            // 
            dtPrestamo.Location = new Point(611, 411);
            dtPrestamo.Margin = new Padding(3, 4, 3, 4);
            dtPrestamo.Name = "dtPrestamo";
            dtPrestamo.Size = new Size(251, 27);
            dtPrestamo.TabIndex = 28;
            // 
            // dtDevolucion
            // 
            dtDevolucion.Location = new Point(611, 484);
            dtDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtDevolucion.Name = "dtDevolucion";
            dtDevolucion.Size = new Size(251, 27);
            dtDevolucion.TabIndex = 29;
            // 
            // cmbDeporte
            // 
            cmbDeporte.Location = new Point(417, 313);
            cmbDeporte.Margin = new Padding(3, 4, 3, 4);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.ReadOnly = true;
            cmbDeporte.Size = new Size(151, 27);
            cmbDeporte.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 947);
            Controls.Add(cmbDeporte);
            Controls.Add(dtDevolucion);
            Controls.Add(dtPrestamo);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(txtbDescripcion);
            Controls.Add(label5);
            Controls.Add(txtbEscuela);
            Controls.Add(txtbCarrera);
            Controls.Add(txtbNombre);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(numCantidad);
            Controls.Add(label7);
            Controls.Add(cbTipoImplemento);
            Controls.Add(txtEcargado);
            Controls.Add(txtCarnet);
            Controls.Add(DataGridPrestamos);
            Controls.Add(lblEscuela);
            Controls.Add(lblCarrera);
            Controls.Add(lblNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "PRESTAMOS";
            ((System.ComponentModel.ISupportInitialize)DataGridPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNombre;
        private Label lblCarrera;
        private Label lblEscuela;
        private DataGridView DataGridPrestamos;
        private TextBox txtCarnet;
        private TextBox txtEcargado;
        private ComboBox cbTipoImplemento;
        private Label label7;
        private NumericUpDown numCantidad;
        private Label label8;
        private Label label4;
        private TextBox txtbNombre;
        private TextBox txtbCarrera;
        private TextBox txtbEscuela;
        private Label label5;
        private RichTextBox txtbDescripcion;
        private Label label6;
        private Label label9;
        private DateTimePicker dtPrestamo;
        private DateTimePicker dtDevolucion;
        private TextBox cmbDeporte;
    }
}
