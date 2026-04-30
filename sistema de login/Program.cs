using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string opcaoEscolhida = string.Empty;

        List<string> usuariosNome = new List<string>();
        List<string> usuariosSenha = new List<string>();

        while (true)
        {
            Menu(ref opcaoEscolhida);

            switch (opcaoEscolhida)
            {
                case "1":
                    Cadastrar(usuariosNome, usuariosSenha);
                    break;

                case "2":
                    Logar(usuariosNome, usuariosSenha);
                    break;

                case "3":
                    ListarUsuarios(usuariosNome);
                    break;

                case "4":
                    Sair();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida, tente novamente!!!");
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();

                    continue;
            }
        }
    }

    static string Menu(ref string opcaoEscolhida)
    {
        Console.Clear();
        Console.WriteLine("==========\nBem vindo ao sistema de login!!!\n==========".ToUpper());
        Console.WriteLine("\n\nO que deseja fazer?\n1 - Cadastrar\n2 - Logar\n3 - Conferir lista de usuários\n4 - Sair");
        Console.Write("\nDigite o número da opção escolhida: ");
        opcaoEscolhida = Console.ReadLine();
        return opcaoEscolhida;
    }

    static void Cadastrar(List<string> usuariosNome, List<string> usuariosSenha)
    {
        string nome = string.Empty;
        string senha = string.Empty;

        Console.Clear();

        Console.Write("Digite seu nome de usuário: ");
        nome = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        senha = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Cadastro realizado com sucesso!!!");
        Console.ReadKey();

        usuariosNome.Add(nome);
        usuariosSenha.Add(senha);
    }

    static void Logar(List<string> usuariosNome, List<string> usuariosSenha)
    {
        string nome = string.Empty;
        string senha = string.Empty;

        Console.Clear();

        Console.Write("Digite seu nome de usuário: ");
        nome = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        senha = Console.ReadLine();

        Console.Clear();

        int posicaoNome = usuariosNome.IndexOf(nome);

        if (posicaoNome != -1 && usuariosSenha[posicaoNome] == senha)
        {
            Console.WriteLine($"Login realizado com sucesso!!!\nBem vindo {nome}!!!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorretos, tente novamente!!!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
    static void ListarUsuarios(List<string> usuariosNome)
    {
        Console.Clear();
        foreach (string usuario in usuariosNome)
        {
            Console.WriteLine(usuario);
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    static void Sair()
    {
        Console.Clear();
        Console.WriteLine("Saindo do programa...");
        Environment.Exit(0);
    }
}
