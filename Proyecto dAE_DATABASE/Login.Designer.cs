namespace Proyecto_dAE_DATABASE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            txtbUsuario = new TextBox();
            txtbContrasenia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 28.2F, FontStyle.Bold);
            label1.Location = new Point(6, 179);
            label1.Name = "label1";
            label1.Size = new Size(211, 47);
            label1.TabIndex = 0;
            label1.Text = "ACCESO A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 346);
            label2.Name = "label2";
            label2.Size = new Size(251, 31);
            label2.TabIndex = 1;
            label2.Text = "CARNET DE USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.2F, FontStyle.Bold);
            label3.Location = new Point(141, 439);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(86, 499);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(245, 499);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 51);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(120, 315);
            txtbUsuario.Margin = new Padding(3, 4, 3, 4);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(228, 27);
            txtbUsuario.TabIndex = 5;
            txtbUsuario.TextChanged += txtbUsuario_TextChanged;
            // 
            // txtbContrasenia
            // 
            txtbContrasenia.Location = new Point(120, 408);
            txtbContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtbContrasenia.Name = "txtbContrasenia";
            txtbContrasenia.PasswordChar = '*';
            txtbContrasenia.Size = new Size(228, 27);
            txtbContrasenia.TabIndex = 6;
            txtbContrasenia.TextChanged += txtbContrasenia_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 28.2F, FontStyle.Bold);
            label4.Location = new Point(223, 179);
            label4.Name = "label4";
            label4.Size = new Size(240, 47);
            label4.TabIndex = 7;
            label4.Text = "INVENTARIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Fluent Icons", 28.2F, FontStyle.Bold);
            label5.Location = new Point(108, 226);
            label5.Name = "label5";
            label5.Size = new Size(239, 47);
            label5.TabIndex = 8;
            label5.Text = "DE BODEGA";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.Location = new Point(74, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(314, 138);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(464, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtbContrasenia);
            Controls.Add(txtbUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnSalir;
        private TextBox txtbUsuario;
        private TextBox txtbContrasenia;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}