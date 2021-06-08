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
    public partial class Aplicação : MetroFramework.Forms.MetroForm
    {
        private Thread nt;
        private Usuario user;

        public Aplicação(int user)
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

        private void botao_Click(object sender, EventArgs e)
        {
            double CustoC = double.Parse(txtCustoC.Text);
            double ValorC = double.Parse(txtValorC.Text);

            double Resultado = (CustoC / ValorC) * 100;
            res.Text = $"{Resultado.ToString("N2")}%";
            res.Visible = true;
            Informacoes.Visible = true;
        }
    }
}
