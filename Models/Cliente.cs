using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_cs.Models
{
    public class Cliente : Pessoa
    {
        public Cliente() : base()
        {

        }

        public Cliente(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public override void Se_Apresentar()
        {
            throw new NotImplementedException();
        }
    }
}