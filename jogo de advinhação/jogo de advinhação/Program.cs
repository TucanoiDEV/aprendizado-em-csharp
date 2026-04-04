class Program
{
    static void Main()
    {
        int chances = 3;

        while (true)
        {
            string charadaSorteada = SortearCharada();

            Console.WriteLine("==========\nBem-vindo ao jogo de adivinhação!\n==========\n");

            VerificarResposta(ref chances, charadaSorteada);

            FimDeJogo(ref chances, charadaSorteada);

        }
    }

    static void VerificarResposta(ref int chances, string charadaSorteada)
    {
        string resposta;
        while (chances > 0)
        {
            switch (charadaSorteada)
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
            if (charadaSorteada == resposta.ToLower())
            {
                Console.Clear();
                Console.WriteLine("Parabéns, você acertou!");
                Console.WriteLine("Gostaria de tentar novamente? Digite 'sim' ou qualquer outra coisa para 'não'");
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
    }

    static void FimDeJogo(ref int chances, string charadaSorteada)
    {
        string continuarJogo;

        if (chances <= 0)
        {
            Console.WriteLine($"Suas chances acabaram! A resposta era: {charadaSorteada}");
            Console.WriteLine("Gostaria de tentar novamente? Digite 'sim' ou qualquer outra coisa para 'não'");
        }
        continuarJogo = Console.ReadLine();
        if (continuarJogo.ToLower() == "sim")
        {
            Console.Clear();
            chances = 3;
        }
        else
        {
            Console.WriteLine("Obrigado por jogar! Até a próxima!");
            Environment.Exit(0);
        }
    }

    static string SortearCharada()
    {
        Random random = new Random();
        string[] charadas = { "silêncio", "ser-humano", "buraco" };
        string charadaSorteada = string.Empty;

        charadaSorteada = charadas[random.Next(charadas.Length)];
        return charadaSorteada;
    }
}