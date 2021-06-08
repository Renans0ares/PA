using System;
using System.Collections.Generic;
using System.Text;

namespace PA_TESTE
{
    class Fazenda
    {
        public int idfazenda { get; protected set; }
        public string nome { get; protected set; }
        public string rua { get; protected set; }
        public int numero { get; protected set; }
        public string bairro { get; protected set; }
        public string cidade { get; protected set; }
        public string estado { get; protected set; }
        public int cep { get; protected set; }
        public int iduser { get; protected set; }

        public Fazenda(int idfazenda, string nome, string rua, int numero, string bairro, string cidade, string estado, int cep, int iduser)
        {
            this.idfazenda = idfazenda;
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.iduser = iduser;
        }

        public string Imprimir()
        {
            return $"Nome Da Fazenda: {this.nome}\nRua: {this.nome}\nNumero: {this.numero}\nBairro: {this.bairro}\nCidade: {this.cidade} - {this.estado}\n";
        }
    }
}
