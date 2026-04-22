using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class MenuPrincipal
    {
        public static void menuInicial()
        {
            while (true)
            {
                int opcaoEscolhida;
                string opcaoEscolhidaTryParse;

                Console.WriteLine("==================================================\nSEJA BEM VINDO AO SEU SISTEMA DE AGENDA PESSOAL!!!\n==================================================");
                Console.Write("\nO que deseja?\n\n1 - Agendar algo\n2 - Mostrarlista de Agendamentos\n3 - SAIR\n\nResposta Selecionada: ");
                opcaoEscolhidaTryParse = Console.ReadLine();
                if (int.TryParse(opcaoEscolhidaTryParse, out opcaoEscolhida) && opcaoEscolhida > 0 && opcaoEscolhida < 4) ;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção não identificada, por favor tente novamente\n[Pressione qualquer tecla]");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
