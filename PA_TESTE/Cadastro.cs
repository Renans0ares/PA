using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using TesteBancoDados;

namespace PA_TESTE
{
    class Cadastro
    {
        private static SqlCommand cmd = new SqlCommand();
        private static Conexao con = new Conexao();
        public static string msguser { get; protected set; }
        public static string msgfazenda { get; protected set; }
        public static string msg { get; protected set; }

        public static void Addfazenda(string nome, string rua, string bairro, int numero, string cidade, string estado, int cep, int dono)
        {
            cmd.CommandText = $"insert into fazenda (nome, rua, bairro, numero, cidade, estado, cep, id_user) values('{nome}', '{rua}', '{bairro}',{numero}, '{cidade}', '{estado}', {cep}, {dono})";

            try
            {
                cmd.Connection = con.Conectar();

                cmd.ExecuteNonQuery();

                msgfazenda = "Sucesso";
            }
            catch (SqlException e)
            {

                MessageBox.Show($"Erro ao se conectar com o banco\n{e}");
            }
            finally
            {
                con.Desconectar();
            }
        }

        public static void AddUser(string nome, string cpf, string email, string senha)
        {
            cmd.CommandText = $"insert into usuario (nome, cpf, pass, email) values('{nome}', '{cpf}', '{senha}', '{email}')";

            try
            {
                cmd.Connection = con.Conectar();

                cmd.ExecuteNonQuery();

                msguser = "Sucesso";
            }
            catch (SqlException e)
            {

                MessageBox.Show($"Erro ao se conectar com o banco\n{e}");
            }
            finally
            {
                con.Desconectar();
            }
        }

        public static int SelectPerNome( string nome)
        {
            int aux = 0;

            cmd.CommandText = $"select id_user from usuario where nome = '{nome}'";

            try
            {
                cmd.Connection = con.Conectar();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aux = int.Parse(reader["id_user"].ToString());
               }
                reader.Close();
            }
            catch (SqlException e)
            {

                MessageBox.Show($"Erro ao se conectar com o banco\n{e}");
            }
            finally
            {
                con.Desconectar();
            }

            return aux;
        }

        public static bool ValdaçãoCpf(string cpf)
        {
            int soma = 0, mod1 = 0, mod2 = 0, aux = 0;

            //Validação de cpf

            //para validar um cpf temos que fazer um calcula da seguinte forma
            //cpf de exemplo: 123.456.789-09
            //numeros do cpf(123456789) digitos validadores(09)
            //para validar fazemos o seguite calculo pegamos os numeros do cpf e multiplicamos por 10 até 2 de forma decresente e somando tudo no final assim
            //(1*10)+(2*9)+(3*8)+(4*7)+(5*6)+(6*5)+(7*4)+(8*3)+(9*2) = 210
            // agora multiplicamos por 10 e fazemos o resto da divisão inteira por 11 assim
            //(210*10)%11 = 10 se o resto da divisão for 10 ou 11 o valor muda altomaticamente para 0 assim
            //10 > 0 esse e o primeiro digito verificador
            // agora vamos fazer o calcula para o segundo digito verificador
            //seguimos da mesma forma somente que agora vamos usar todos os numero menos o ultimo digito verificador e começaremos a multiplicação do 11 ao em vez do 10 assim
            //(1*11)+(2*10)+(3*9)+(4*8)+(5*7)+(6*6)+(7*5)+(8*4)+(9*3)+(0*2) = 255
            //agora  a multiplicação por 10 e o resto por 11
            //(255*10)%11 = 9
            //assim validamos o cpf

            // para um cpf ser valido ele n pode ter todos os numeros iguais então temos o codigo a seguir que tira essa possibilidade
            for (int i = 0; i < 11; i++)
            {
                if (cpf.Substring(0, 1) == cpf.Substring(i, 1))
                {
                    aux++;
                }
            }

            if (aux == 10)
                return false;
            // fim da verificação de digitos iguais

            aux = 0;

            // aqui fazemos o calculo de validação
            for (int i = 1; i <= 9; i++)
            {
                aux = int.Parse(cpf.Substring(i - 1, 1));
                soma += aux * (11 - i);
            }

            mod1 = (soma * 10) % 11;

            // aqui verificamos se o resto n deu 10 ou 11 assim substituindo o valor pelo correto
            if (mod1 == 10 || mod1 == 11)
                mod1 = 0;

            //calculo para validar o cpf com o segundo digito verificador
            soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                aux = int.Parse(cpf.Substring(i - 1, 1));
                soma += aux * (12 - i);
            }

            mod2 = (soma * 10) % 11;

            //denovo a verificação pra garantir que o segundo digito esteja correto
            if (mod2 == 10 || mod2 == 11)
                mod2 = 0;

            // aqui retornamos se é valido ou n o cpf
            if ((mod1 == int.Parse(cpf.Substring(9, 1))) && (mod2 == int.Parse(cpf.Substring(10, 1))))
                return true;
            else
                return false;
        }

        public static List<Usuario> SelectAllUser()
        {
            List<Usuario> aux = new List<Usuario>();

            cmd.CommandText = "select * from usuario";

            try
            {
                cmd.Connection = con.Conectar();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aux.Add(new Usuario(int.Parse(reader["id_user"].ToString()), reader["nome"].ToString(), reader["cpf"].ToString(), reader["email"].ToString(), reader["pass"].ToString()));
                }
                reader.Close();
            }
            catch (SqlException e)
            {

                MessageBox.Show($"Erro ao se conectar com o banco\n{e}");
            }
            finally
            {
                con.Desconectar();
            }
            
            return aux;
        }

        public static Usuario SelectUserById(int id)
        {
            Usuario aux = null;

            cmd.CommandText = $"select * from usuario where id_user = {id}";

            try
            {
                cmd.Connection = con.Conectar();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aux = new Usuario(int.Parse(reader["id_user"].ToString()), reader["nome"].ToString(), reader["cpf"].ToString(), reader["email"].ToString(), reader["pass"].ToString());
                }
                reader.Close();
            }
            catch (SqlException e)
            {

                MessageBox.Show($"Erro ao se conectar com o banco\n{e}");
            }
            finally
            {
                con.Desconectar();
            }

            return aux;
        }

        public static Fazenda SelectFarmByIdUser(int iduser)
        {
            Fazenda aux = null;

            cmd.CommandText = $"select f.* from fazenda f inner join usuario u on (f.id_user = u.id_user) where u.id_user = {iduser}";

            try
            {
                cmd.Connection = con.Conectar();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aux = new Fazenda(int.Parse(reader["id_farm"].ToString()), reader["nome"].ToString(), reader["id_farm"].ToString(), int.Parse(reader["numero"].ToString()), reader["bairro"].ToString(), reader["cidade"].ToString(), reader["estado"].ToString(), int.Parse(reader["cep"].ToString()), int.Parse(reader["id_user"].ToString()));
                }

                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show($"Erro com o banco\n{e}");
            }
            finally
            {
                con.Desconectar();
            }

            return aux;
        }


        public static Praga SelectPragaById(int idpraga)
        {
            Praga aux = null;

            cmd.CommandText = $"select * from praga where id_prag = {idpraga}";

            try
            {
                cmd.Connection = con.Conectar();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aux = new Praga(int.Parse(reader["id_prag"].ToString()), reader["nome"].ToString(), reader["nomesci"].ToString(), reader["ataque"].ToString(), reader["combate"].ToString(), reader["descricao"].ToString(), reader["foto"].ToString());
                }

                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show($"Erro com o banco de dados\n{e}");
            }
            finally
            {
                con.Desconectar();
            }

            return aux;
        }
    }
}
