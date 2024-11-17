namespace Proyecto_dAE_DATABASE
{
    partial class frmUsuario
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtbNombre = new TextBox();
            txtbCarne = new TextBox();
            txtbTelefono = new TextBox();
            txtbContrasenia = new TextBox();
            txtbId = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cmbbCarrera = new ComboBox();
            cmbbRol = new ComboBox();
            txtbDireccion = new TextBox();
            txtbEscuela = new TextBox();
            txtbBuscar = new TextBox();
            label11 = new Label();
            cmbbBuscar = new ComboBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 36);
            label1.Name = "label1";
            label1.Size = new Size(372, 32);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE USUARIOS";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(619, 367);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(737, 367);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 31);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(861, 367);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 171);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(343, 136);
            txtbNombre.Margin = new Padding(3, 4, 3, 4);
            txtbNombre.MaxLength = 12;
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(114, 27);
            txtbNombre.TabIndex = 6;
            // 
            // txtbCarne
            // 
            txtbCarne.Location = new Point(485, 136);
            txtbCarne.Margin = new Padding(3, 4, 3, 4);
            txtbCarne.MaxLength = 4;
            txtbCarne.Name = "txtbCarne";
            txtbCarne.Size = new Size(114, 27);
            txtbCarne.TabIndex = 7;
            // 
            // txtbTelefono
            // 
            txtbTelefono.Location = new Point(574, 236);
            txtbTelefono.Margin = new Padding(3, 4, 3, 4);
            txtbTelefono.MaxLength = 8;
            txtbTelefono.Name = "txtbTelefono";
            txtbTelefono.Size = new Size(114, 27);
            txtbTelefono.TabIndex = 12;
            // 
            // txtbContrasenia
            // 
            txtbContrasenia.Location = new Point(720, 236);
            txtbContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtbContrasenia.MaxLength = 8;
            txtbContrasenia.Name = "txtbContrasenia";
            txtbContrasenia.Size = new Size(114, 27);
            txtbContrasenia.TabIndex = 13;
            // 
            // txtbId
            // 
            txtbId.Location = new Point(187, 136);
            txtbId.Margin = new Padding(3, 4, 3, 4);
            txtbId.Name = "txtbId";
            txtbId.ReadOnly = true;
            txtbId.Size = new Size(114, 27);
            txtbId.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 433);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1122, 335);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 171);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 16;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 171);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 17;
            label4.Text = "CARNÉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(681, 171);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 18;
            label5.Text = "CARRERA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(905, 171);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 19;
            label6.Text = "ESCUELA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 271);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 20;
            label7.Text = "DIRECCION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 271);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 21;
            label8.Text = "ROL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(591, 271);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 22;
            label9.Text = "TELEFONO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(720, 271);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 23;
            label10.Text = "CONTRASEÑA";
            // 
            // cmbbCarrera
            // 
            cmbbCarrera.FormattingEnabled = true;
            cmbbCarrera.Items.AddRange(new object[] { "" });
            cmbbCarrera.Location = new Point(619, 136);
            cmbbCarrera.Margin = new Padding(3, 4, 3, 4);
            cmbbCarrera.Name = "cmbbCarrera";
            cmbbCarrera.Size = new Size(187, 28);
            cmbbCarrera.TabIndex = 24;
            // 
            // cmbbRol
            // 
            cmbbRol.FormattingEnabled = true;
            cmbbRol.Location = new Point(401, 236);
            cmbbRol.Margin = new Padding(3, 4, 3, 4);
            cmbbRol.Name = "cmbbRol";
            cmbbRol.Size = new Size(138, 28);
            cmbbRol.TabIndex = 26;
            // 
            // txtbDireccion
            // 
            txtbDireccion.Location = new Point(255, 236);
            txtbDireccion.Margin = new Padding(3, 4, 3, 4);
            txtbDireccion.Name = "txtbDireccion";
            txtbDireccion.Size = new Size(114, 27);
            txtbDireccion.TabIndex = 27;
            // 
            // txtbEscuela
            // 
            txtbEscuela.Location = new Point(839, 136);
            txtbEscuela.Margin = new Padding(3, 4, 3, 4);
            txtbEscuela.Name = "txtbEscuela";
            txtbEscuela.ReadOnly = true;
            txtbEscuela.Size = new Size(187, 27);
            txtbEscuela.TabIndex = 28;
            // 
            // txtbBuscar
            // 
            txtbBuscar.Location = new Point(223, 368);
            txtbBuscar.Margin = new Padding(3, 4, 3, 4);
            txtbBuscar.Name = "txtbBuscar";
            txtbBuscar.Size = new Size(263, 27);
            txtbBuscar.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(223, 344);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 30;
            label11.Text = "Buscar";
            // 
            // cmbbBuscar
            // 
            cmbbBuscar.FormattingEnabled = true;
            cmbbBuscar.Items.AddRange(new object[] { "ID", "NOMBRE", "CARNÉ", "CARRERA", "ESCUELA", "ROL", "TELÉFONO" });
            cmbbBuscar.Location = new Point(78, 369);
            cmbbBuscar.Margin = new Padding(3, 4, 3, 4);
            cmbbBuscar.Name = "cmbbBuscar";
            cmbbBuscar.Size = new Size(138, 28);
            cmbbBuscar.TabIndex = 31;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(504, 368);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(78, 331);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 787);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbbBuscar);
            Controls.Add(label11);
            Controls.Add(txtbBuscar);
            Controls.Add(txtbEscuela);
            Controls.Add(txtbDireccion);
            Controls.Add(cmbbRol);
            Controls.Add(cmbbCarrera);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtbId);
            Controls.Add(txtbContrasenia);
            Controls.Add(txtbTelefono);
            Controls.Add(txtbCarne);
            Controls.Add(txtbNombre);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuario";
            Text = "frmUsuario";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtbNombre;
        private TextBox txtbCarne;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox txtbTelefono;
        private TextBox txtbContrasenia;
        private TextBox txtbId;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cmbbCarrera;
        private ComboBox cmbbRol;
        private TextBox txtbDireccion;
        private TextBox txtbEscuela;
        private TextBox txtbBuscar;
        private Label label11;
        private ComboBox cmbbBuscar;
        private Button btnBuscar;
        private Button btnLimpiar;
    }
}