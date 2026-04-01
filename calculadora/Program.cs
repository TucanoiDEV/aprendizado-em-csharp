class Program
{
    static void Main()
    {
        float num1 = 0;
        float num2 = 0;
        float res;

        string operadorString;
        string entradaTryParse;

        bool entradaValida = false;

        int operador = Menu();

        while (operador != 5)
        {
            while(entradaValida == false)
            {
                Console.Write("Digite o primeiro número: ");
                entradaTryParse = Console.ReadLine();
                if (float.TryParse(entradaTryParse, out num1)) ;
                else
                {
                    Console.WriteLine("Entrada inválida, pressione qualquer tecla para refazer o cálculo");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.Write("Digite o segundo número: ");
                entradaTryParse = Console.ReadLine();
                if (float.TryParse(entradaTryParse, out num2));
                else
                {
                    Console.WriteLine("Entrada inválida, pressione qualquer tecla para refazer o cálculo");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                break;
                Console.Clear();
            }

            switch (operador)
            {
                case 1:
                    res = num1 + num2;
                    operadorString = "+";
                    break;

                case 2:
                    res = num1 - num2;
                    operadorString = "-";
                    break;

                case 3:
                    res = num1 * num2;
                    operadorString = "*";
                    break;

                case 4:
                    res = num1 / num2;
                    operadorString = "/";
                    break;

                default:
                    Console.WriteLine("Opção inválida, pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
            }

            if(operador == 4 && (num1 == 0 || num2 == 0))
            {
                Console.WriteLine("Não é possível dividir por zero, pressione qualquer tecla para retornar ao Menu");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            Console.WriteLine($"{num1} {operadorString} {num2} = {res}");
            Console.WriteLine("================================");
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu.");
            Console.ReadKey();
            continue;
        }
    }
    static int Menu()
    {
        int operador = 1;
        string entradaTryParse;

        while(true)
        {
            Console.Clear();
            Console.WriteLine("Digite o número da opção que preferir:\n( 1 ) - SOMA\n( 2 ) - SUBTRAÇÃO\n( 3 ) - MULTIPLICAÇÃO\n( 4 ) - DIVISÃO\n( 5 ) - SAIR");
            Console.Write("\nOpção escolhida: ");
            entradaTryParse = Console.ReadLine();
            int.TryParse(entradaTryParse, out operador);
            Console.Clear();

            if (operador == 5)
            {
                Console.WriteLine("Muito Obrigado!!!\n\n");
                return operador;
            }
            else if (operador < 1 || operador > 5)
            {
                Console.WriteLine("Opção inválida, pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                continue;
            }
            break;
        }
        return operador;
    }
}