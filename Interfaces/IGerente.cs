using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_cs.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista, IPessoa
    {
        void Conhecer_Hotel();
    }
}