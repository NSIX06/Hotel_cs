using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_cs.Interfaces;

namespace Hotel_cs.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista() : base()
        {

        }

        public Recepcionista(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void Atender_Telefone()
        {
            
            Console.WriteLine("Eu sei atender o telefone.");
            Console.WriteLine(); 
        }

        public void Ingles_Basico()
        {
            Console.WriteLine("Eu sei falar o básico de inglês. ");
            Console.WriteLine();
        }

        public override void Se_Apresentar()
        {
            
            Console.WriteLine("Prazer, eu sou a recepcionista " + Nome);
            Console.WriteLine();
        }
    }
}