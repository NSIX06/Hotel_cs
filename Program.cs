using Hotel_cs.Models;

Console.WriteLine("*******************");
Console.WriteLine("***** Hotel Cs *****");
Console.WriteLine("*******************");
Console.WriteLine();

//*Contratação

var camareira = new Camareira("Nicole", "12345678901", "12345678");
camareira.Se_Apresentar();
camareira.Arrumar_Cama();
camareira.Limpar_Quarto();



var recepcionista = new Recepcionista("Eduarda", "98765432101", "87654321");
recepcionista.Se_Apresentar();
recepcionista.Atender_Telefone();
recepcionista.Ingles_Basico();



var gerente = new Gerente("Caiox", "24681012", "109876543");
gerente.Se_Apresentar();
gerente.Arrumar_Cama();
gerente.Limpar_Quarto();
gerente.Atender_Telefone();
gerente.Ingles_Basico();