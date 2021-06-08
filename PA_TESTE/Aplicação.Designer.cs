
namespace PA_TESTE
{
    partial class Aplicação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicação));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.Label();
            this.botao = new System.Windows.Forms.Button();
            this.Informacoes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(947, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(508, 583);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(501, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Software Desenvolvido pelos Estudantes de Sistemas de Informação da FHO @ 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(47, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Custo do Controle *";
            // 
            // txtCustoC
            // 
            this.txtCustoC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustoC.Location = new System.Drawing.Point(47, 125);
            this.txtCustoC.Name = "txtCustoC";
            this.txtCustoC.Size = new System.Drawing.Size(259, 35);
            this.txtCustoC.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(339, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 41;
            this.label1.Text = "Valor de Produção de Cultura *";
            // 
            // txtValorC
            // 
            this.txtValorC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorC.Location = new System.Drawing.Point(339, 125);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(299, 35);
            this.txtValorC.TabIndex = 42;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res.Location = new System.Drawing.Point(410, 201);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(119, 32);
            this.res.TabIndex = 43;
            this.res.Text = "Resultado";
            this.res.Visible = false;
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(674, 125);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(107, 35);
            this.botao.TabIndex = 44;
            this.botao.Text = "Calcule";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // Informacoes
            // 
            this.Informacoes.AutoSize = true;
            this.Informacoes.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Informacoes.Location = new System.Drawing.Point(47, 201);
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(357, 32);
            this.Informacoes.TabIndex = 45;
            this.Informacoes.Text = "Nível de Dano Economico(NDE):";
            this.Informacoes.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(47, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 96);
            this.label2.TabIndex = 46;
            this.label2.Text = "* É a menor densidade populacional da praga ou de \r\ndanos que causa prejuízos à c" +
    "ultura.\r\n\r\n";
            // 
            // Aplicação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Informacoes);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.res);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustoC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aplicação";
            this.Text = "Aplicação";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorC;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label Informacoes;
        private System.Windows.Forms.Label label2;
    }
}