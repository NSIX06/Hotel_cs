using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_cs.Interfaces
{
    public interface IRecepcionista : IPessoa
    {
        void Atender_Telefone();
        void Ingles_Basico();
    }
}