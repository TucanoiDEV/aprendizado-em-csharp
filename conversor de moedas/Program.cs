class Program
{
    static void Main()
    {
        float valor = 0;
        float valorConvertido = 0;
        int escolha = 0;
        string moeda = "";

        while(escolha != 5)
        {
            Console.WriteLine("Escolha para qual moeda quer conveter o valor\n( 1 ) Dólar\n( 2 ) Euro\n( 3 ) Libra\n( 4 ) Peso\n( 5 ) Sair do programa");
            int.TryParse(Console.ReadLine(), out escolha);
            Console.Clear();

            if (escolha == 5)
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }
            else if(escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4)
            {
                Console.WriteLine("Opção inválida, tente novamente...");
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            Console.Write("Digite o valor (em reais) que deverá ser convertido: ");
            if (float.TryParse(Console.ReadLine(), out valor))
            {
                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        valorConvertido = valor * 0.19f;
                        moeda = "Dólar";
                        break;

                    case 2:
                        valorConvertido = valor * 0.16f;
                        moeda = "Euro";
                        break;

                    case 3:
                        valorConvertido = valor * 0.14f;
                        moeda = "Libra";
                        break;

                    case 4:
                        valorConvertido = valor * 264.58f;
                        moeda = "Peso";
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

            Console.WriteLine($"{valor} em reais corresponde a {valorConvertido:F2} em {moeda}");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}