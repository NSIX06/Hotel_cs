using Hotel_cs.Interfaces;

namespace Hotel_cs.Models
{
    public class Hotel
    {
        public string Nome{get; set;}

        public Endereco Endereco{get; set;}

        public List<IRecepcionista> Recepcionistas {get; private set;}

        public List<ICamareira> Camareiras {get; private set;}

        public IGerente Gerente {get; private set;}

        public Hotel(string nome)
        {
            Nome = nome;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        }
        public Hotel(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        }

        public void Contratar_Gerente(IGerente gerente)
        {
            Gerente = gerente;
        }
        public void Contratar_Camereia(ICamareira camareira)
        {
            Camareiras.Add(camareira);
        }

        public void Contratar_Recepcionista(IRecepcionista recepcionista)
        {
            Recepcionistas.Add(recepcionista);
        }
    }
}