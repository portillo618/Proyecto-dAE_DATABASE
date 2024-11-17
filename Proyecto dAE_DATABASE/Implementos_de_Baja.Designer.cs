namespace Proyecto_dAE_DATABASE
{
    partial class Implementos_de_Baja
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
            txtbDeporte = new TextBox();
            txtbImplemento = new TextBox();
            label8 = new Label();
            label7 = new Label();
            nudImplemento = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudImplemento).BeginInit();
            SuspendLayout();
            // 
            // txtbDeporte
            // 
            txtbDeporte.Location = new Point(416, 107);
            txtbDeporte.Name = "txtbDeporte";
            txtbDeporte.ReadOnly = true;
            txtbDeporte.Size = new Size(158, 23);
            txtbDeporte.TabIndex = 28;
            // 
            // txtbImplemento
            // 
            txtbImplemento.Location = new Point(217, 107);
            txtbImplemento.Name = "txtbImplemento";
            txtbImplemento.ReadOnly = true;
            txtbImplemento.Size = new Size(158, 23);
            txtbImplemento.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 89);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 26;
            label8.Text = "Deporte Implemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 89);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 25;
            label7.Text = "Nombre Implemento";
            // 
            // nudImplemento
            // 
            nudImplemento.Location = new Point(53, 107);
            nudImplemento.Name = "nudImplemento";
            nudImplemento.Size = new Size(120, 23);
            nudImplemento.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 89);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 23;
            label3.Text = "Implemento Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 23);
            label1.Name = "label1";
            label1.Size = new Size(531, 25);
            label1.TabIndex = 22;
            label1.Text = "GESTIÓN DE IMPLEMENTOS DADOS DE BAJA";
            // 
            // Implementos_de_Baja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbDeporte);
            Controls.Add(txtbImplemento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(nudImplemento);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Implementos_de_Baja";
            Text = "Implementos_de_Baja";
            ((System.ComponentModel.ISupportInitialize)nudImplemento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbDeporte;
        private TextBox txtbImplemento;
        private Label label8;
        private Label label7;
        private NumericUpDown nudImplemento;
        private Label label3;
        private Label label1;
    }
}