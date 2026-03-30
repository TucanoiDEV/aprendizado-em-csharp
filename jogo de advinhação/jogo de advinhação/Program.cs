class Program
{
    static void Main()
    {
        string[] objetos = { "silêncio", "ser-humano", "buraco"};

        int chances = 3;
        string opcao;

        Random random = new Random();

        string objetoSorteado = objetos[random.Next(objetos.Length)];
        string resposta;

        Console.WriteLine("==========\nBem-vindo ao jogo de adivinhação!\n==========\n");

        while (chances > 0)
        {
            switch (objetoSorteado)
            {
                case "silêncio":
                    Console.WriteLine("O que é?, o que é? Quanto mais você o chama, menos ele aparece?\n");
                    break;

                case "ser-humano":
                    Console.WriteLine("O que é?, o que é? Na manhã tem 4 patas, na tarde tem 2 e na noite tem 3?\n");
                    break;

                case "buraco":
                    Console.WriteLine("O que é?, o que é? Quanto mais se tira, maior fica?\n");
                    break;
            }

            resposta = Console.ReadLine();
            if (objetoSorteado == resposta)
            {
                Console.WriteLine("Parabéns, você acertou!");
                break;
            }
            else
            {
                chances--;
                Console.WriteLine($"Resposta errada! Chances restantes: {chances}");
                Console.ReadKey();
                Console.Clear();
            }
        }
        if(chances <= 0)
        {
            Console.WriteLine($"Suas chances acabaram! O objeto era: {objetoSorteado}");
            Console.WriteLine("Gostaria de tentar novamente? Digite 'sim' ou qualquer outra coisa para 'não'");
        }
        opcao = Console.ReadLine();
        if(opcao.ToLower() == "sim")
        {
            Console.Clear();
            Main();
        }
        else
        {
            Console.WriteLine("Obrigado por jogar! Até a próxima!");
        }
    }
}