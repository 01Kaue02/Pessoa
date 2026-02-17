using DIO.Models;
Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine("Vogal");
    break;
    default:
    Console.WriteLine("Não é vogal");
    break;

     }

























//int quantidade = 10;
//int quantidadecompra = 09;
//bool podeVender = quantidadecompra > 0 && quantidade >= quantidadecompra;
//
//Console.WriteLine($"Quantidade em estoque: {quantidade}");
//Console.WriteLine($"Quantidade solicitada: {quantidadecompra}");
//Console.WriteLine($"É possivel realizar a venda? {podeVender}");
//if(quantidadecompra == 0)
//{
//    Console.WriteLine("A quantidade solicitada deve ser maior que zero.");
//}
//
//else if (podeVender)
//{
//    Console.WriteLine("Venda realizada com sucesso!");
//}
//
//else
//{
//    Console.WriteLine("Desculpe, não temos estoque suficiente para realizar a venda.");
//}









//string Apresentar= "Olá, seja bem-vindo ao curso de C# da DIO!";
//int tentativa = 10;
//decimal Valor = 10.5m;
//double valor2 = 10.5;
//bool estaChovendo = false;
//
//Console.WriteLine("kaue " + Apresentar);
//Console.WriteLine("essa é a tentativa numero " + tentativa);
//Console.WriteLine("valor do curso foi " + valor2);
//Console.WriteLine("está chovendo? " + estaChovendo);
//Console.WriteLine("minha altura é " + Valor);
