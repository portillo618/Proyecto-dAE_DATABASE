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
            btnConfirmar = new Button();
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
            cmbDeporte = new ComboBox();
            txtbNombre = new TextBox();
            txtbCarrera = new TextBox();
            txtbEscuela = new TextBox();
            label5 = new Label();
            txtbDescripcion = new RichTextBox();
            label6 = new Label();
            label9 = new Label();
            dtPrestamo = new DateTimePicker();
            dtDevolucion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataGridPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(26, 157);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 22);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Usuario";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(66, 483);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 22);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Prestamo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(275, 483);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 22);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(498, 483);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 22);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Registro";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(721, 483);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(190, 22);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar Modificacion";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 6;
            label1.Text = "PRESTAMOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese Carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(761, 238);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 8;
            label3.Text = "ID de encargado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(285, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre de Usuario";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(475, 100);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 10;
            lblCarrera.Text = "Carrera";
            // 
            // lblEscuela
            // 
            lblEscuela.AutoSize = true;
            lblEscuela.Location = new Point(665, 100);
            lblEscuela.Name = "lblEscuela";
            lblEscuela.Size = new Size(46, 15);
            lblEscuela.TabIndex = 11;
            lblEscuela.Text = "Escuela";
            // 
            // DataGridPrestamos
            // 
            DataGridPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPrestamos.Location = new Point(12, 534);
            DataGridPrestamos.Margin = new Padding(3, 2, 3, 2);
            DataGridPrestamos.Name = "DataGridPrestamos";
            DataGridPrestamos.RowHeadersWidth = 51;
            DataGridPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridPrestamos.Size = new Size(972, 165);
            DataGridPrestamos.TabIndex = 12;
            DataGridPrestamos.CellContentClick += DataGridPrestamos_CellContentClick;
            DataGridPrestamos.Click += DataGridPrestamos_Click;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(132, 126);
            txtCarnet.Margin = new Padding(3, 2, 3, 2);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(110, 23);
            txtCarnet.TabIndex = 13;
            // 
            // txtEcargado
            // 
            txtEcargado.Location = new Point(860, 235);
            txtEcargado.Margin = new Padding(3, 2, 3, 2);
            txtEcargado.Name = "txtEcargado";
            txtEcargado.Size = new Size(110, 23);
            txtEcargado.TabIndex = 14;
            // 
            // cbTipoImplemento
            // 
            cbTipoImplemento.FormattingEnabled = true;
            cbTipoImplemento.Items.AddRange(new object[] { "Red de Voleibol", "Raqueta", "Cronometro" });
            cbTipoImplemento.Location = new Point(146, 235);
            cbTipoImplemento.Margin = new Padding(3, 2, 3, 2);
            cbTipoImplemento.Name = "cbTipoImplemento";
            cbTipoImplemento.Size = new Size(133, 23);
            cbTipoImplemento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 238);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 16;
            label7.Text = "Tipo de Implemento";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(596, 235);
            numCantidad.Margin = new Padding(3, 2, 3, 2);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(131, 23);
            numCantidad.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 238);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 18;
            label8.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 238);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 19;
            label4.Text = "Deporte";
            // 
            // cmbDeporte
            // 
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Items.AddRange(new object[] { "Red de Voleibol", "Raqueta", "Cronometro" });
            cmbDeporte.Location = new Point(365, 235);
            cmbDeporte.Margin = new Padding(3, 2, 3, 2);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(133, 23);
            cmbDeporte.TabIndex = 20;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(285, 126);
            txtbNombre.Margin = new Padding(3, 2, 3, 2);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.ReadOnly = true;
            txtbNombre.Size = new Size(184, 23);
            txtbNombre.TabIndex = 21;
            // 
            // txtbCarrera
            // 
            txtbCarrera.Location = new Point(475, 126);
            txtbCarrera.Margin = new Padding(3, 2, 3, 2);
            txtbCarrera.Name = "txtbCarrera";
            txtbCarrera.ReadOnly = true;
            txtbCarrera.Size = new Size(184, 23);
            txtbCarrera.TabIndex = 22;
            // 
            // txtbEscuela
            // 
            txtbEscuela.Location = new Point(665, 126);
            txtbEscuela.Margin = new Padding(3, 2, 3, 2);
            txtbEscuela.Name = "txtbEscuela";
            txtbEscuela.ReadOnly = true;
            txtbEscuela.Size = new Size(305, 23);
            txtbEscuela.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 290);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 24;
            label5.Text = "Descripción";
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(146, 287);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(352, 148);
            txtbDescripcion.TabIndex = 25;
            txtbDescripcion.Text = "";
            txtbDescripcion.TextChanged += richTextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 290);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 26;
            label6.Text = "FechaPrestamo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(535, 345);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 27;
            label9.Text = "FechaDevolucion";
            // 
            // dtPrestamo
            // 
            dtPrestamo.Location = new Point(535, 308);
            dtPrestamo.Name = "dtPrestamo";
            dtPrestamo.Size = new Size(220, 23);
            dtPrestamo.TabIndex = 28;
            // 
            // dtDevolucion
            // 
            dtDevolucion.Location = new Point(535, 363);
            dtDevolucion.Name = "dtDevolucion";
            dtDevolucion.Size = new Size(220, 23);
            dtDevolucion.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 710);
            Controls.Add(dtDevolucion);
            Controls.Add(dtPrestamo);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(txtbDescripcion);
            Controls.Add(label5);
            Controls.Add(txtbEscuela);
            Controls.Add(txtbCarrera);
            Controls.Add(txtbNombre);
            Controls.Add(cmbDeporte);
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
            Controls.Add(btnConfirmar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
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
        private Button btnConfirmar;
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
        private ComboBox cmbDeporte;
        private TextBox txtbNombre;
        private TextBox txtbCarrera;
        private TextBox txtbEscuela;
        private Label label5;
        private RichTextBox txtbDescripcion;
        private Label label6;
        private Label label9;
        private DateTimePicker dtPrestamo;
        private DateTimePicker dtDevolucion;
    }
}
