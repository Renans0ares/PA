
namespace PA_TESTE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCsenha = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.errorNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCPF = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCsenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.TermosDeUso = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.errorNomef = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEndereco = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumero = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBairro = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContribuinte = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTermos = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCsenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContribuinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTermos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 103);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 29);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF *";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(58, 165);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(207, 29);
            this.txtCPF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 231);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 29);
            this.txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha *";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(59, 298);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(207, 29);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirmar Senha *";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCsenha
            // 
            this.txtCsenha.Location = new System.Drawing.Point(59, 370);
            this.txtCsenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtCsenha.Name = "txtCsenha";
            this.txtCsenha.PasswordChar = '*';
            this.txtCsenha.Size = new System.Drawing.Size(207, 29);
            this.txtCsenha.TabIndex = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(591, 526);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 43);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "CADASTRAR";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // errorNome
            // 
            this.errorNome.ContainerControl = this;
            // 
            // errorCPF
            // 
            this.errorCPF.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorSenha
            // 
            this.errorSenha.ContainerControl = this;
            // 
            // errorCsenha
            // 
            this.errorCsenha.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(478, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome da Fazenda *";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNomef
            // 
            this.txtNomef.Location = new System.Drawing.Point(478, 103);
            this.txtNomef.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomef.Name = "txtNomef";
            this.txtNomef.Size = new System.Drawing.Size(207, 29);
            this.txtNomef.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(478, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rua *";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(478, 165);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(207, 29);
            this.txtRua.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(478, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Número *";
            // 
            // txtNendereco
            // 
            this.txtNendereco.Location = new System.Drawing.Point(478, 231);
            this.txtNendereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtNendereco.Name = "txtNendereco";
            this.txtNendereco.Size = new System.Drawing.Size(207, 29);
            this.txtNendereco.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(478, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bairro *";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(478, 298);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(207, 29);
            this.txtBairro.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(478, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cidade *";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(478, 369);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(207, 29);
            this.txtCidade.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(478, 418);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "UF *";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(478, 441);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(41, 29);
            this.txtEstado.TabIndex = 24;
            // 
            // TermosDeUso
            // 
            this.TermosDeUso.AutoSize = true;
            this.TermosDeUso.Location = new System.Drawing.Point(478, 485);
            this.TermosDeUso.Name = "TermosDeUso";
            this.TermosDeUso.Size = new System.Drawing.Size(198, 25);
            this.TermosDeUso.TabIndex = 25;
            this.TermosDeUso.Text = "Aceito os Termos de Uso";
            this.TermosDeUso.UseVisualStyleBackColor = true;
            this.TermosDeUso.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(539, 418);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "CEP *";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(539, 441);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(146, 29);
            this.txtCep.TabIndex = 27;
            // 
            // errorNomef
            // 
            this.errorNomef.ContainerControl = this;
            // 
            // errorEndereco
            // 
            this.errorEndereco.ContainerControl = this;
            // 
            // errorNumero
            // 
            this.errorNumero.ContainerControl = this;
            // 
            // errorBairro
            // 
            this.errorBairro.ContainerControl = this;
            // 
            // errorCidade
            // 
            this.errorCidade.ContainerControl = this;
            // 
            // errorEstado
            // 
            this.errorEstado.ContainerControl = this;
            // 
            // errorCEP
            // 
            this.errorCEP.ContainerControl = this;
            // 
            // errorContribuinte
            // 
            this.errorContribuinte.ContainerControl = this;
            // 
            // errorTermos
            // 
            this.errorTermos.ContainerControl = this;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(509, 582);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(501, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Software Desenvolvido pelos Estudantes de Sistemas de Informação da FHO @ 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 602);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TermosDeUso);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNendereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNomef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtCsenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CADASTRAR";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCsenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContribuinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTermos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCsenha;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ErrorProvider errorNome;
        private System.Windows.Forms.ErrorProvider errorCPF;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorSenha;
        private System.Windows.Forms.ErrorProvider errorCsenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox TermosDeUso;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNendereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomef;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorNomef;
        private System.Windows.Forms.ErrorProvider errorEndereco;
        private System.Windows.Forms.ErrorProvider errorNumero;
        private System.Windows.Forms.ErrorProvider errorBairro;
        private System.Windows.Forms.ErrorProvider errorCidade;
        private System.Windows.Forms.ErrorProvider errorEstado;
        private System.Windows.Forms.ErrorProvider errorCEP;
        private System.Windows.Forms.ErrorProvider errorContribuinte;
        private System.Windows.Forms.ErrorProvider errorTermos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

