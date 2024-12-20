using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_cs.Models
{
    public abstract class Pessoa
    {
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public abstract void Se_Apresentar();
    }
}