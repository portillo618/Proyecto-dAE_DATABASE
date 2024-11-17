namespace Proyecto_dAE_DATABASE
{
    partial class Deportes
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
            btnRefrescar = new Button();
            btnBuscar = new Button();
            txtbBusqueda = new TextBox();
            cmbParametro = new ComboBox();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtbNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(617, 253);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(86, 31);
            btnRefrescar.TabIndex = 21;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(525, 253);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbBusqueda
            // 
            txtbBusqueda.Location = new Point(525, 292);
            txtbBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbBusqueda.Name = "txtbBusqueda";
            txtbBusqueda.Size = new Size(164, 27);
            txtbBusqueda.TabIndex = 19;
            // 
            // cmbParametro
            // 
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "ID", "Nombre" });
            cmbParametro.Location = new Point(709, 292);
            cmbParametro.Margin = new Padding(3, 4, 3, 4);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(138, 28);
            cmbParametro.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 348);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(855, 223);
            dataGridView1.TabIndex = 17;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(334, 291);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(206, 291);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(86, 291);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(154, 137);
            txtbNombre.Margin = new Padding(3, 4, 3, 4);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(198, 27);
            txtbNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 141);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 11;
            label1.Text = "DEPORTES";
            // 
            // Deportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(txtbBusqueda);
            Controls.Add(cmbParametro);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Deportes";
            Text = "Roles";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        private Button btnBuscar;
        private TextBox txtbBusqueda;
        private ComboBox cmbParametro;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtbNombre;
        private Label label2;
        private Label label1;
    }
}