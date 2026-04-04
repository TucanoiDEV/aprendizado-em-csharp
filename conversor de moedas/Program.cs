class Program
{
    static void Main()
    {
        float valorConvertido = 0;
        float valorEmReal = 0;
        int escolhaDeConversao = 0;
        string moedaConversora = string.Empty;

        while(true)
        {
            Menu(ref escolhaDeConversao);
            Conversao(valorEmReal, ref escolhaDeConversao, valorConvertido, moedaConversora);
        }
    }

    static void Menu(ref int escolhaDeConversao)
    {
        while (true)
        {
            Console.WriteLine("Escolha para qual moeda quer conveter o valor\n( 1 ) Dólar\n( 2 ) Euro\n( 3 ) Libra\n( 4 ) Peso\n( 5 ) Sair do programa");
            int.TryParse(Console.ReadLine(), out escolhaDeConversao);
            Console.Clear();

            if (escolhaDeConversao == 5)
            {
                Console.WriteLine("Saindo do programa...");
                Environment.Exit(0);
            }
            else if (escolhaDeConversao != 1 && escolhaDeConversao != 2 && escolhaDeConversao != 3 && escolhaDeConversao != 4)
            {
                Console.WriteLine("Opção inválida, tente novamente...");
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            break;
        }

    }

    static void Conversao(float valorEmReal, ref int escolhaDeConversao,float valorConvertido, string moedaConversora)
    {
        while (true)
        {
            Console.Write("Digite o valor (em reais) que deverá ser convertido: ");
            if (float.TryParse(Console.ReadLine(), out valorEmReal))
            {
                Console.Clear();

                switch (escolhaDeConversao)
                {
                    case 1:
                        valorConvertido = valorEmReal * 0.19f;
                        moedaConversora = "Dólar";
                        break;

                    case 2:
                        valorConvertido = valorEmReal * 0.16f;
                        moedaConversora = "Euro";
                        break;

                    case 3:
                        valorConvertido = valorEmReal * 0.14f;
                        moedaConversora = "Libra";
                        break;

                    case 4:
                        valorConvertido = valorEmReal * 264.58f;
                        moedaConversora = "Peso";
                        break;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido, pressione 'Enter' para tentar novamente");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            Console.WriteLine($"{valorEmReal:F2}R$ corresponde a {valorConvertido:F2} em {moedaConversora}");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            break;
        }
    }
}