using System;

class Program
{
    static void Main(string[] args)
    {
        // Cadastro fixo
        string emailCadastro = "anavaz@email.com";
        string nomeUsuario = "Ana";
        string senha = "2323";

        // Entrada do usuário
        Console.Write("Digite seu email: ");
        string registroEmail = Console.ReadLine() ?? "";

        Console.Write("Digite sua senha: ");
        string registroSenha = Console.ReadLine() ?? "";

        // Verificação
        if (registroEmail == emailCadastro && registroSenha == senha)
        {
            Console.WriteLine("Login realizado com sucesso!");
            Console.WriteLine($"Bem-vindo(a), {nomeUsuario}!");
        }
        else
        {
            Console.WriteLine("Email ou senha incorretos.");
        }
    }
}
