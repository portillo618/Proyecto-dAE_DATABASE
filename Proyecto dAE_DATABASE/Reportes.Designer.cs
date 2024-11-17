namespace Proyecto_dAE_DATABASE
{
    partial class Reportes
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
            label3 = new Label();
            label4 = new Label();
            cmbR1 = new ComboBox();
            btnReportes = new Button();
            button1 = new Button();
            btnReportesIII = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 28);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 0;
            label1.Text = "REPORTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 105);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 1;
            label2.Text = "Listado de artículos préstados ordenados por";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 162);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuarios con artículos préstados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 216);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 3;
            label4.Text = "Artículos dados de baja";
            // 
            // cmbR1
            // 
            cmbR1.FormattingEnabled = true;
            cmbR1.Items.AddRange(new object[] { "usuario", "fecha", "deporte" });
            cmbR1.Location = new Point(356, 102);
            cmbR1.Name = "cmbR1";
            cmbR1.Size = new Size(121, 23);
            cmbR1.TabIndex = 4;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(535, 105);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 23);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reporte";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // button1
            // 
            button1.Location = new Point(535, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Reporte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReportesIII
            // 
            btnReportesIII.Location = new Point(535, 216);
            btnReportesIII.Name = "btnReportesIII";
            btnReportesIII.Size = new Size(75, 23);
            btnReportesIII.TabIndex = 7;
            btnReportesIII.Text = "Reporte";
            btnReportesIII.UseVisualStyleBackColor = true;
            btnReportesIII.Click += btnReportesIII_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportesIII);
            Controls.Add(button1);
            Controls.Add(btnReportes);
            Controls.Add(cmbR1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reportes";
            Text = "Reportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbR1;
        private Button btnReportes;
        private Button button1;
        private Button btnReportesIII;
    }
}