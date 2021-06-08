
namespace PA_TESTE
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
            this.emailLogin = new System.Windows.Forms.Label();
            this.senhaLogin = new System.Windows.Forms.Label();
            this.textEmailLogin = new System.Windows.Forms.TextBox();
            this.textSenhaLogin = new System.Windows.Forms.TextBox();
            this.linkCadastro = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Slogan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLogin
            // 
            this.emailLogin.AutoSize = true;
            this.emailLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLogin.Location = new System.Drawing.Point(39, 185);
            this.emailLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.Size = new System.Drawing.Size(91, 30);
            this.emailLogin.TabIndex = 1;
            this.emailLogin.Text = "EMAIL :";
            // 
            // senhaLogin
            // 
            this.senhaLogin.AutoSize = true;
            this.senhaLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senhaLogin.Location = new System.Drawing.Point(39, 270);
            this.senhaLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senhaLogin.Name = "senhaLogin";
            this.senhaLogin.Size = new System.Drawing.Size(98, 30);
            this.senhaLogin.TabIndex = 2;
            this.senhaLogin.Text = "SENHA :";
            // 
            // textEmailLogin
            // 
            this.textEmailLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmailLogin.Location = new System.Drawing.Point(39, 218);
            this.textEmailLogin.Name = "textEmailLogin";
            this.textEmailLogin.Size = new System.Drawing.Size(260, 31);
            this.textEmailLogin.TabIndex = 3;
            this.textEmailLogin.TabStop = false;
            this.textEmailLogin.TextChanged += new System.EventHandler(this.textEmailLogin_TextChanged);
            // 
            // textSenhaLogin
            // 
            this.textSenhaLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSenhaLogin.Location = new System.Drawing.Point(39, 303);
            this.textSenhaLogin.Name = "textSenhaLogin";
            this.textSenhaLogin.PasswordChar = '*';
            this.textSenhaLogin.Size = new System.Drawing.Size(260, 31);
            this.textSenhaLogin.TabIndex = 4;
            this.textSenhaLogin.TabStop = false;
            // 
            // linkCadastro
            // 
            this.linkCadastro.Location = new System.Drawing.Point(91, 403);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(91, 23);
            this.linkCadastro.TabIndex = 5;
            this.linkCadastro.Text = "AQUI";
            this.linkCadastro.UseSelectable = true;
            this.linkCadastro.Click += new System.EventHandler(this.linkCadastro_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 403);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 38);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Cadastra-se\n";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(39, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 35);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(508, 584);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(501, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Software Desenvolvido pelos Estudantes de Sistemas de Informação da FHO @ 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Slogan.Location = new System.Drawing.Point(439, 381);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(493, 19);
            this.Slogan.TabIndex = 10;
            this.Slogan.Text = "\"O Melhor Software para  Controle de Pragas\"\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 602);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.textSenhaLogin);
            this.Controls.Add(this.textEmailLogin);
            this.Controls.Add(this.senhaLogin);
            this.Controls.Add(this.emailLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "LOGIN DE ACESSO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLogin;
        private System.Windows.Forms.Label senhaLogin;
        private System.Windows.Forms.TextBox textEmailLogin;
        private System.Windows.Forms.TextBox textSenhaLogin;
        private MetroFramework.Controls.MetroLink linkCadastro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Slogan;
    }
}