using System;
using System.Collections.Generic;
using System.Text;

namespace PA_TESTE
{
    class Usuario
    {
        public int iduser { get; protected set; }
        public string nome { get; protected set; }
        public string cpf { get; protected set; }
        public string email { get; protected set; }
        public string senha { get; protected set; }

        public Usuario(int id, string nome, string cpf, string email, string senha)
        {
            this.iduser = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.senha = senha;
        }

        public string Imprimir()
        {
            string cpfp1 = this.cpf.Substring(0,9);
            string cpfp2 = this.cpf.Substring(9, 2);

            return $"Nome Usuário: {nome}\nCPF: {cpfp1} - {cpfp2}\nE-mail: {email}\n";
        }

    }
}
