using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_cs.Interfaces
{
    public interface ICamareira : IPessoa
    {
        void Arrumar_Cama();
        void Limpar_Quarto();
        
    }
}