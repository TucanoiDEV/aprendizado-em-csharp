class Program
{
    static void Main()
    {
        soma("Olá", "Mundo", "C#", "12.0");
    }
    static void soma(params string[] palavras)
    {
        foreach (var palavra in palavras)
        {
            Console.WriteLine(palavra);
        }
    }
}