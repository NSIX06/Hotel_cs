using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_cs.Interfaces;

namespace Hotel_cs.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente() : base()
        {

        }

        public Gerente(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void Arrumar_Cama()
        {
        
        Console.WriteLine("Eu sou o gerente e sei arrumar a cama.");
        Console.WriteLine();

        }

        public void Atender_Telefone()
        {
            Console.WriteLine("Eu sou o gerente e sei atender o telefone.");
            Console.WriteLine(); 
        }

        public void Conhecer_Hotel()
        {
            Console.WriteLine("Eu sou o gerente e conheço tudo do hotel.");
            Console.WriteLine(); 
        }

        public void Ingles_Basico()
        {
            Console.WriteLine("Eu sou o gerente e sei inglês avançado.");
            Console.WriteLine(); 
        }

        public void Limpar_Quarto()
        {
        
        Console.WriteLine("Eu sou o gerente e sei limpar os quartos.");
        Console.WriteLine();
        }

        public override void Se_Apresentar()
        {
            
        Console.WriteLine("Prazer, sou o gerente do Hotel_Cs " + Nome);
        Console.WriteLine();
        }
    }
}