using Hotel_cs.Interfaces;
using Hotel_cs.Models;

Console.WriteLine("*******************");
Console.WriteLine("***** Hotel Cs *****");
Console.WriteLine("*******************");
Console.WriteLine();

//*Contratação

ICamareira camareira1 = new Camareira("Nicole", "12345678901", "12345678");

ICamareira camareira2 = new Camareira("Tiffany", "123456789011", "123456789");


IRecepcionista recepcionista1 = new Recepcionista("Eduarda", "98765432101", "87654321");


IRecepcionista recepcionista2 = new Recepcionista("Jéssica", "98765432101112", "87654321234");

//?Administrou vários hoteis(atualmente empregado) 
IGerente gerente1 = new Gerente("Caiox", "24681012", "109876543");

//?Administrou poucos hoteis(atualmente desempregado) 
IGerente gerente2 = new Gerente("Castrin", "2468101213", "10987654321");

//*Inauguração 

Hotel hotel = new Hotel("Hotel Cs", new Endereco()
{
    CEP = "123456",
    Rua = "Rua da Loud",
    Numero = 69,
    Complemento = "Apto 244",
    Bairro = "Jacinto",
    Cidade = "BC"    
}
);

//*Contratando camareiras:
hotel.Contratar_Camereia(camareira1);
hotel.Contratar_Camereia(camareira2);

//*Contratando recepcionistas:
hotel.Contratar_Recepcionista(recepcionista1);
hotel.Contratar_Recepcionista(recepcionista2);

//*Contratando gerente:

hotel.Contratar_Gerente(gerente1);

//*Contratando o faz tudo:

hotel.Contratar_Camereia(gerente2);
hotel.Contratar_Recepcionista(gerente2);

//*Gerente:

hotel.Gerente.Se_Apresentar();
hotel.Gerente.Arrumar_Cama();
hotel.Gerente.Arrumar_Cama();
hotel.Gerente.Atender_Telefone();
hotel.Gerente.Ingles_Basico();

foreach (var camareira in hotel.Camareiras)
{
    camareira.Se_Apresentar();
    camareira.Arrumar_Cama();
    camareira.Limpar_Quarto();
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.Se_Apresentar();
    recepcionista.Atender_Telefone();
    recepcionista.Ingles_Basico();

}

Console.WriteLine();