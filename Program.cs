using DIO.Models;

int quantidade = 10;

int quantidadecompra = 1;
bool podeVender = quantidade >= quantidadecompra;

Console.WriteLine($"Quantidade em estoque: {quantidade}");
Console.WriteLine($"Quantidade solicitada: {quantidadecompra}");
Console.WriteLine($"É possivel realizar a venda? {podeVender}");
if (podeVender)
{
    Console.WriteLine("Venda realizada com sucesso!");
}
else
{
    Console.WriteLine("Desculpe, não temos estoque suficiente para realizar a venda.");
}









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
