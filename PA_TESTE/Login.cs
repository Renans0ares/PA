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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
       Usuario user = null;
        private Thread nt, nt2;

        public Login()
        {
            InitializeComponent();
        }

        private void textEmailLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Essa condição é responsável por procurar o email e a senha no Banco de Dados
            if(textEmailLogin.Text.Trim().Equals("") || textSenhaLogin.Text.Trim().Equals(""))
                MessageBox.Show("Preencha os campos por Favor!!");

            List<Usuario> c = Cadastro.SelectAllUser();

            foreach (var i in c)
            {
                if (i.email == textEmailLogin.Text && i.senha == textSenhaLogin.Text)
                {
                    this.user = i;
                    break;
                }
            }

            if (this.user == null)
            {
                MessageBox.Show("Cadastro não encontrado.");
            }
            else
            {
                this.Close();
                nt2 = new Thread(chamaAplicacao);
                nt2.SetApartmentState(ApartmentState.STA);
                nt2.Start();
            }
        }

        private void chamaAplicacao(object obj)
        {
            Application.Run(new MenuOpções(this.user.iduser));
        }

        private void linkCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(chamaCadastrar);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void chamaCadastrar(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
