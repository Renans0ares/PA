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
    public partial class MenuOpções : MetroFramework.Forms.MetroForm
    {
        private Thread nt;
        Usuario user = null;

        public MenuOpções(int user)
        {
            InitializeComponent();

            this.user = Cadastro.SelectUserById(user);
        }

        private void aplicacao_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(chamarAplicacao);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void chamarAplicacao(object obj)
        {
            Application.Run(new Aplicação(this.user.iduser));
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(chamarPerfil);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void chamarPerfil(object obj)
        {
            Application.Run(new MeuPerfil(this.user.iduser));
        }

        private void combates_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(chamarCombates);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void chamarCombates(object obj)
        {
            Application.Run(new ModosCombate(this.user.iduser));
        }

        private void informacao_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(chamarSaibaMais);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void chamarSaibaMais(object obj)
        {
            Application.Run(new SaibaMais(this.user.iduser));
        }
    }
}
