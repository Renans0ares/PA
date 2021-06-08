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
    public partial class SaibaMais : MetroFramework.Forms.MetroForm
    {
        private Thread nt;
        private Usuario user;

        public SaibaMais(int user)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
