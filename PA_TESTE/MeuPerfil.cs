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
    public partial class MeuPerfil : MetroFramework.Forms.MetroForm
    {
        Fazenda farm = null;
        Usuario user = null;
        private Thread nt;

        public MeuPerfil(int user)
        {
            InitializeComponent();

            this.user = Cadastro.SelectUserById(user);
            this.farm = Cadastro.SelectFarmByIdUser(user);

            label1.Text = this.user.Imprimir();
            label2.Text = this.farm.Imprimir();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
