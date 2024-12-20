using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_cs.Models
{
    public class Endereco
    {
        public string CEP{get; set;}
        public string Rua{get; set;}
        public int Numero{get; set;}
        public string Complemento{get; set;}
        public string Bairro{get; set;}
        public string Cidade{get; set;}
    }
}