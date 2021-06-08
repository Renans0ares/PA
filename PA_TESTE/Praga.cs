using System;
using System.Collections.Generic;
using System.Text;

namespace PA_TESTE
{
    class Praga
    {
        public int idpraga { get; protected set; }
        public string nome { get; protected set; }
        public string nomesci { get; protected set; }
        public string ataque { get; protected set; }
        public string conbate { get; protected set; }
        public string descricao { get; protected set; }
        public string img { get; protected set; }

        public Praga(int idpraga, string nome, string nomesci, string ataque, string conbate, string descricao, string img)
        {
            this.idpraga = idpraga;
            this.nome = nome;
            this.nomesci = nomesci;
            this.ataque = ataque;
            this.conbate = conbate;
            this.descricao = descricao;
            this.img = img;
        }

        public string Imprimir()
        {
            return $"Nome: {this.nome}\nNome Ciêntifico:{this.nomesci}\nAtaca: {this.ataque}\nComo Combater: {this.conbate}\nDescrição: {this.descricao}\n";
        }
    }
}
