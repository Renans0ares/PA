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
    public partial class PragraDesc : MetroFramework.Forms.MetroForm
    {
        private Thread nt;
        private Praga bicho;
        private int id_user;

        public PragraDesc(int bicho, int id_user)
        {
            InitializeComponent();

            this.bicho = Cadastro.SelectPragaById(bicho);

            this.id_user = id_user;
            label1.Text = this.bicho.Imprimir();
            pictureBox1.ImageLocation = this.bicho.img;
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
            Application.Run(new ModosCombate(id_user));
        }
    }
}
