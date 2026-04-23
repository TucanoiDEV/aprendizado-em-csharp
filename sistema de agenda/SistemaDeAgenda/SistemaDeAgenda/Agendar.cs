using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAgendamento
{
    internal class Agendar
    {
        public static void FazerAgendamento()
        {
            string nome;
            string horario;
            string observacoes;

            Console.WriteLine("Qual será o nome do agendamento?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual será o horário do agendamento?");
            horario = Console.ReadLine();

            Console.WriteLine("Tem alguma observação à acrescentar?");
            observacoes = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Agendamento Confirmado!");
        }
    }
}
