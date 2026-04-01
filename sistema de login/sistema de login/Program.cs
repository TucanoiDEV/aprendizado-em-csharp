using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string nome;
        string senha;
        string opcaoEscolhida;
        bool finalizarCodigo = false;

        List<string> usuariosNome = new List<string>();
        List<string> usuariosSenha = new List<string>();

        while (finalizarCodigo == false)
        {
            Console.Clear();
            Console.WriteLine("==========\nBem vindo ao sistema de login!!!\n==========".ToUpper());
            Console.WriteLine("\n\nO que deseja fazer?\n1 - Cadastrar\n2 - Logar\n3 - Conferir lista de usuários\n4 - Sair");
            Console.Write("\nDigite o número da opção escolhida: ");
            opcaoEscolhida = Console.ReadLine();
            if (opcaoEscolhida == "1")
            {
                Console.Clear();

                Console.Write("Digite seu nome de usuário: ");
                nome = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\nCadastro realizado com sucesso!!!");
                Console.ReadKey();

                usuariosNome.Add(nome);
                usuariosSenha.Add(senha);

                continue;
            }
            else if(opcaoEscolhida == "2")
            {
                Console.Clear();

                Console.Write("Digite seu nome de usuário: ");
                nome = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                Console.Clear();

                // Verificar se o nome de usuário existe e se a senha corresponde a esse nome de usuário a partir de suas posições nas listas
                int indexUsuario = usuariosNome.IndexOf(nome);

                if(indexUsuario != -1 && usuariosNome.IndexOf(nome) == usuariosSenha.IndexOf(senha))
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
                    continue;
                }

            }
            else if (opcaoEscolhida == "3")
            {
                Console.Clear();
                foreach (string usuario in usuariosNome)
                {
                    Console.WriteLine(usuario);
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
            else if(opcaoEscolhida == "4")
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o sistema de login!!!");
                Console.ReadKey();
                finalizarCodigo = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida, tente novamente!!!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();

                continue;
            }
        }
    }
}
