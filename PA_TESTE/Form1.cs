using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TesteBancoDados;
using System.Threading;

namespace PA_TESTE
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int CPF { get; private set; }
        public int CEP { get; private set; }

        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            errorNome.Clear();//Limpa a caixa de erro
            if (txtNome.Text.Trim().Equals("")) //Se tiver o valor de vázio o erro vai exibir o alerta com a mensagem a frente
            {
                errorNome.SetError(txtNome, "Insira seu nome completo!");
                txtNome.Focus();
                return;
            }

           errorCPF.Clear();//Limpa a caixa de erro
            if (txtCPF.Text.Trim().Equals(""))//Se tiver o valor de vázio o erro vai exibir o alerta com a mensagem a frente
            {
                errorCPF.SetError(txtCPF, "Insira um CPF!");
                txtCPF.Focus();
                return;
            }
            else
            {
                if (Cadastro.ValdaçãoCpf(txtCPF.Text) == false){
                    errorCPF.SetError(txtCPF, "Insira um CPF Valido!");
                    txtCPF.Focus();
                }
            }

            errorEmail.Clear();//Limpa a caixa de erro
            if (txtEmail.Text.Trim().Equals(""))//Se tiver o valor de vázio o erro vai exibir o alerta com a mensagem a frente
            {
                errorEmail.SetError(txtEmail, "Insira seu E-mail!");
                txtEmail.Focus();
                return;
            }
            
            errorSenha.Clear();//Limpa a caixa de erro
            if (txtSenha.Text.Trim().Equals(""))
            {
                errorSenha.SetError(txtSenha, "Insira uma senha!");
                txtSenha.Focus();
                return;
            }

            errorCsenha.Clear();//Limpa a caixa de erro
            if (txtSenha.Text.Trim() != txtCsenha.Text.Trim())
            {
                errorCsenha.SetError(txtCsenha, "As senhas estão diferentes, insira a mesma senha!");
                txtCsenha.Focus();
                return;
            }

            errorNomef.Clear();//Limpa a caixa de erro
            if (txtNomef.Text.Trim().Equals(""))
            {
                errorNomef.SetError(txtNomef, "Digite um Nome de Fazenda válido! ");
                txtNomef.Focus();
                return;
            }

            errorEndereco.Clear();//Limpa a caixa de erro
            if (txtRua.Text.Trim().Equals(""))
            {
                errorEndereco.SetError(txtRua, "Digite uma Rua válida! ");
                txtRua.Focus();
                return;
            }

            errorNumero.Clear();//Limpa a caixa de erro
            if (txtNendereco.Text.Trim().Equals(""))
            {
                errorNumero.SetError(txtNendereco, "Digite um Número válido! ");
                txtNendereco.Focus();
                return;
            }

            errorBairro.Clear();//Limpa a caixa de erro
            if (txtBairro.Text.Trim().Equals(""))
            {
                errorBairro.SetError(txtBairro, "Digite um Bairro válido! ");
                txtBairro.Focus();
                return;
            }

            errorCidade.Clear();//Limpa a caixa de erro
            if (txtCidade.Text.Trim().Equals(""))
            {
                errorCidade.SetError(txtCidade, "Digite uma Cidade válida! ");
                txtCidade.Focus();
                return;
            }

            errorEstado.Clear();//Limpa a caixa de erro
            if (txtEstado.Text.Trim().Equals("") || txtEstado.Text.Length > 2)
            {
                errorEstado.SetError(txtEstado, "Digite um Estado Válido! ");
                txtEstado.Focus();
                return;
            }

            errorCEP.Clear();//Limpa a caixa de erro
            if (txtCep.Text.Trim().Equals("") || txtCep.Text.Length > 8)
            {
                errorCEP.SetError(txtCep, "Digite um nome CEP Válido! ");
                txtCep.Focus();
                return;
            }

            errorTermos.Clear();
            if (!TermosDeUso.Checked)
            {
                errorTermos.SetError(TermosDeUso, "Necessário aceitar os termos de uso! ");
                TermosDeUso.Focus();
                return;
            }

            Cadastro.AddUser(txtNome.Text, txtCPF.Text, txtEmail.Text, txtSenha.Text);
            Cadastro.Addfazenda(txtNomef.Text,txtRua.Text,txtBairro.Text,int.Parse(txtNendereco.Text),txtCidade.Text,txtEstado.Text,int.Parse(txtCep.Text),Cadastro.SelectPerNome(txtNome.Text));

            MessageBox.Show("Cadastarado com sucesso");

            this.Close();
            nt = new Thread(voltaLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void voltaLogin(object obj)
        {
            Application.Run(new Login());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
