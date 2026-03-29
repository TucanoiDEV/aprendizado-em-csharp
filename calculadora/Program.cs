class Program
{
    static void Main()
    {
        float num1 = 0;
        float num2 = 0;
        int operador = 1;
        float res;
        string operadorString;

        while (operador != 5)
        {
            Console.Clear();
            Console.WriteLine("Digite o número da opção que preferir:\n( 1 ) - SOMA\n( 2 ) - SUBTRAÇÃO\n( 3 ) - MULTIPLICAÇÃO\n( 4 ) - DIVISÃO\n( 5 ) - SAIR");
            Console.Write("\nOpção escolhida: ");
            operador = int.Parse(Console.ReadLine());
            Console.Clear();

            if (operador == 5)
            {
                Console.WriteLine("Muito Obrigado!!!");
                break;
            }

            else if (operador != 1 && operador != 2 && operador != 3 && operador != 4)
            {
                Console.WriteLine("Opção inválida, pressione 'Enter' para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            Console.Write("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Clear();

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
                    Console.WriteLine("Opção inválida, pressione 'Enter' para tentar novamente.");
                    Console.ReadLine();
                    continue;
            }

            Console.WriteLine($"{num1} {operadorString} {num2} = {res}");
            Console.WriteLine("================================");
            Console.WriteLine("Pressione 'Enter' para continuar.");
            Console.ReadLine();
            continue;
        }
    }
}