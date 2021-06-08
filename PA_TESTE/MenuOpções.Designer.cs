
namespace PA_TESTE
{
    partial class MenuOpções
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOpções));
            this.perfil = new MetroFramework.Controls.MetroTile();
            this.combates = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.aplicacao = new MetroFramework.Controls.MetroTile();
            this.informacao = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // perfil
            // 
            this.perfil.ActiveControl = null;
            this.perfil.Location = new System.Drawing.Point(231, 116);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(150, 142);
            this.perfil.TabIndex = 1;
            this.perfil.Text = "MEU PERFIL";
            this.perfil.UseSelectable = true;
            this.perfil.Click += new System.EventHandler(this.perfil_Click);
            // 
            // combates
            // 
            this.combates.ActiveControl = null;
            this.combates.Location = new System.Drawing.Point(424, 116);
            this.combates.Name = "combates";
            this.combates.Size = new System.Drawing.Size(150, 142);
            this.combates.TabIndex = 2;
            this.combates.Text = "MODOS DE \r\nCOMBATE";
            this.combates.UseSelectable = true;
            this.combates.Click += new System.EventHandler(this.combates_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(508, 583);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(501, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Software Desenvolvido pelos Estudantes de Sistemas de Informação da FHO @ 2021";
            // 
            // aplicacao
            // 
            this.aplicacao.ActiveControl = null;
            this.aplicacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aplicacao.ImageKey = "(nenhum)";
            this.aplicacao.Location = new System.Drawing.Point(51, 116);
            this.aplicacao.Name = "aplicacao";
            this.aplicacao.Size = new System.Drawing.Size(150, 142);
            this.aplicacao.TabIndex = 5;
            this.aplicacao.Text = "APLICAÇÃO";
            this.aplicacao.UseSelectable = true;
            this.aplicacao.Click += new System.EventHandler(this.aplicacao_Click);
            // 
            // informacao
            // 
            this.informacao.ActiveControl = null;
            this.informacao.Location = new System.Drawing.Point(615, 116);
            this.informacao.Name = "informacao";
            this.informacao.Size = new System.Drawing.Size(150, 142);
            this.informacao.TabIndex = 6;
            this.informacao.Text = "SAIBA MAIS";
            this.informacao.UseSelectable = true;
            this.informacao.Click += new System.EventHandler(this.informacao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuOpções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 602);
            this.Controls.Add(this.informacao);
            this.Controls.Add(this.aplicacao);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.combates);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuOpções";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile perfil;
        private MetroFramework.Controls.MetroTile combates;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile aplicacao;
        private MetroFramework.Controls.MetroTile informacao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}