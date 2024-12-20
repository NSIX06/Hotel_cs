using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_cs.Interfaces;

namespace Hotel_cs.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira() : base()
        {

        }

        public Camareira(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void Arrumar_Cama()
        {
            Console.WriteLine("Eu sei arrumar a cama.");
            Console.WriteLine();
        }

        public void Limpar_Quarto()
        {
            Console.WriteLine("Eu sei limpar o quarto.");
            Console.WriteLine();
        }

        public override void Se_Apresentar()
        {
            Console.WriteLine("Prazer, eu sou a camareira " + Nome);
            Console.WriteLine();
        }
    }
}