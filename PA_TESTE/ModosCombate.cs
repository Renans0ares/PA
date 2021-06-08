using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PA_TESTE
{
    public partial class ModosCombate : MetroFramework.Forms.MetroForm
    {
        private int id_praga;
        private Thread nt;
        private Usuario user;

        public ModosCombate(int user)
        {
            InitializeComponent();
            this.user = Cadastro.SelectUserById(user);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltaMenu);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void voltaMenu(object obj)
        {
            Application.Run(new MenuOpções(this.user.iduser));
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    id_praga = 1;
                    break;
                case "Feijão":
                    id_praga = 5;
                    break;
                case "Milho":
                    id_praga = 10;
                    break;
                case "Soja":
                    id_praga = 15;
                    break;
            }

            this.Close();
            nt = new Thread(iniciaDesc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    id_praga = 2;
                    break;
                case "Feijão":
                    id_praga = 6;
                    break;
                case "Milho":
                    id_praga = 11;
                    break;
                case "Soja":
                    id_praga = 16;
                    break;
            }

            this.Close();
            nt = new Thread(iniciaDesc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    id_praga = 4;
                    break;
                case "Feijão":
                    id_praga = 8;
                    break;
                case "Milho":
                    id_praga = 12;
                    break;
                case "Soja":
                    id_praga = 18;
                    break;
            }

            this.Close();
            nt = new Thread(iniciaDesc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    id_praga = 3;
                    break;
                case "Feijão":
                    id_praga = 7;
                    break;
                case "Milho":
                    id_praga = 5;
                    break;
                case "Soja":
                    id_praga = 17;
                    break;
            }

            this.Close();
            nt = new Thread(iniciaDesc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    id_praga = 0;
                    break;
                case "Feijão":
                    id_praga = 2;
                    break;
                case "Milho":
                    id_praga = 13;
                    break;
                case "Soja":
                    id_praga = 6;
                    break;
            }

            this.Close();
            nt = new Thread(iniciaDesc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    id_praga = 0;
                    break;
                case "Feijão":
                    id_praga = 9;
                    break;
                case "Milho":
                    id_praga = 14;
                    break;
                case "Soja":
                    id_praga = 0;
                    break;
            }

            this.Close();
            nt = new Thread(iniciaDesc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void iniciaDesc(object obj)
        {
            Application.Run(new PragraDesc(id_praga, user.iduser));
        }

        private void comboPlantacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboPlantacao.Text)
            {
                case "Algodão":
                    imagem1.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Bicudo-adulto.jpg";
                    button1.Text = "Bicudo-do-Algodoeiro";
                    imagem2.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/mosca-branca.jpg";
                    button2.Text = "Mosca-Branca";
                    imagem3.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/pulgao do algodoeiro.jpg";
                    button3.Text = "Pulgao do Algodoeiro";
                    imagem4.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/percevejo-castanha.jpg";
                    button4.Text = "Percevejo-Castanha";

                    imagem1.Visible = true;
                    button1.Visible = true;
                    imagem2.Visible = true;
                    button2.Visible = true;
                    imagem3.Visible = true;
                    button3.Visible = true;
                    imagem4.Visible = true;
                    button4.Visible = true;
                    imagem5.Visible = false;
                    button5.Visible = false;
                    imagem6.Visible = false;
                    button6.Visible = false;
                    break;

                case "Feijão":
                    imagem1.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/lagarta-rosca.jpg";
                    button1.Text = "Lagarta-Rosca";
                    imagem2.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/lagarta-polífagas.jpg";
                    button2.Text = "Lagarta-Elasmo";
                    imagem3.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/1503603186.jpg";
                    button3.Text = "Vaquinha";
                    imagem4.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Lagarta Falsa.png";
                    button4.Text = "Lagarta Falsa";
                    imagem5.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/mosca-branca.jpg";
                    button5.Text = "Mosca-Branca";
                    imagem6.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/acaro-rajado.jpg";
                    button6.Text = "Acaro - Rajado";

                    imagem1.Visible = true;
                    button1.Visible = true;
                    imagem2.Visible = true;
                    button2.Visible = true;
                    imagem3.Visible = true;
                    button3.Visible = true;
                    imagem4.Visible = true;
                    button4.Visible = true;
                    imagem5.Visible = true;
                    button5.Visible = true;
                    imagem6.Visible = true;
                    button6.Visible = true;
                    break;

                case "Milho":
                    imagem1.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Coros.jpg";
                    button1.Text = "Coros";
                    imagem2.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Larva-Arame.jpg";
                    button2.Text = "Larva-Arame";
                    imagem3.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/lagarta-rosca.jpg";
                    button3.Text = "Lagarta-Rosca";
                    imagem4.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Larva-alfinete.jpg";
                    button4.Text = "Larva-Alfinete";
                    imagem5.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/590fe-Milho_SemAutor_01--1-.jpg";
                    button5.Text = "Lagarta-Espiga";
                    imagem6.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Broca-da-cana-de-acucar-min.png";
                    button6.Text = "Broca-da-Cana";

                    imagem1.Visible = true;
                    button1.Visible = true;
                    imagem2.Visible = true;
                    button2.Visible = true;
                    imagem3.Visible = true;
                    button3.Visible = true;
                    imagem4.Visible = true;
                    button4.Visible = true;
                    imagem5.Visible = true;
                    button5.Visible = true;
                    imagem6.Visible = true;
                    button6.Visible = true;
                    break;

                case "Soja":
                    imagem1.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/Percevejo Marrom da Soja - Euschistus Heros.png";
                    button1.Text = "Percevejo Marrom";
                    imagem2.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/f82951a36046fe2715142c2b2e9712ac.png";
                    button2.Text = "Lagarta-Helicoverpa ";
                    imagem3.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/lagartasoja.jpg";
                    button3.Text = "Lagarta-Soja";
                    imagem4.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/lagarta-do-cartucho.jpg";
                    button4.Text = "Lagarta-Cartucho";
                    imagem5.ImageLocation = "E:/PA_TESTE/PA_TESTE/Images/elasmo.jpg";
                    button5.Text = "Lagarta-Elasmo";

                    imagem1.Visible = true;
                    button1.Visible = true;
                    imagem2.Visible = true;
                    button2.Visible = true;
                    imagem3.Visible = true;
                    button3.Visible = true;
                    imagem4.Visible = true;
                    button4.Visible = true;
                    imagem5.Visible = true;
                    button5.Visible = true;
                    imagem6.Visible = false;
                    button6.Visible = false;
                    break;
            }
            
        }

    }
}
