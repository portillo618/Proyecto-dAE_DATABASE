namespace Proyecto_dAE_DATABASE
{
    partial class EncargadosBodega
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
            label2 = new Label();
            txtbNombre = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            txtbBusqueda = new TextBox();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            cmbParametro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 36);
            label1.Name = "label1";
            label1.Size = new Size(317, 25);
            label1.TabIndex = 0;
            label1.Text = "ENCARGADOS DE BODEGA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 119);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(134, 116);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(174, 23);
            txtbNombre.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(74, 231);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(179, 231);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(291, 231);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(748, 167);
            dataGridView1.TabIndex = 6;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // txtbBusqueda
            // 
            txtbBusqueda.Location = new Point(458, 232);
            txtbBusqueda.Name = "txtbBusqueda";
            txtbBusqueda.Size = new Size(144, 23);
            txtbBusqueda.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(458, 203);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(539, 203);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(75, 23);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // cmbParametro
            // 
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "ID", "Nombre" });
            cmbParametro.Location = new Point(619, 232);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(121, 23);
            cmbParametro.TabIndex = 7;
            // 
            // EncargadosBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
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
            Name = "EncargadosBodega";
            Text = "EncargadosBodega";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbNombre;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtbBusqueda;
        private Button btnBuscar;
        private Button btnRefrescar;
        private ComboBox cmbParametro;
    }
}