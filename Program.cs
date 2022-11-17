using System;

namespace Timer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem vindo ao Timer!");
            Console.WriteLine("Digite o tempo do cronometro no formato 00:00:00");
            string? ConsoleEntry = Console.ReadLine();

            if (ConsoleEntry == null)
            {
                throw new Exception("Houve algum erro");
            }

            var instance = new Timer(ConsoleEntry);

            instance.SecondCounter();

            Console.WriteLine("Timer finalizado");
        }
    }
}
