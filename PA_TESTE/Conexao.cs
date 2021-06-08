using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TesteBancoDados
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-IOTIA5I\SQLEXPRESS;Initial Catalog=PA;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            //Verificando se o estado da conexão estiver fechada, aí sim será conectado
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        
        //Verificando se o estado da conexão estiver aberto
        public void Desconectar()
        {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
