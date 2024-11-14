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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            txtbUsuario = new TextBox();
            txtbContrasenia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 48);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 134);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "CARNET USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 201);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(138, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(219, 314);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(163, 108);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(100, 23);
            txtbUsuario.TabIndex = 5;
            txtbUsuario.TextChanged += txtbUsuario_TextChanged;
            // 
            // txtbContrasenia
            // 
            txtbContrasenia.Location = new Point(163, 175);
            txtbContrasenia.Name = "txtbContrasenia";
            txtbContrasenia.PasswordChar = '*';
            txtbContrasenia.Size = new Size(100, 23);
            txtbContrasenia.TabIndex = 6;
            txtbContrasenia.TextChanged += txtbContrasenia_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(txtbContrasenia);
            Controls.Add(txtbUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}