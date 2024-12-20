using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_cs.Interfaces;

namespace Hotel_cs.Models
{
    public class Hotel
    {
        public string Nome{get; set;}

        public Endereco Endereco{get; set;}

        public List<Recepcionista> Recepcionistas {get; set;}

        public List<Camareira> Camareiras {get; set;}

        public IGerente Gerente {get; set;}

    }
}