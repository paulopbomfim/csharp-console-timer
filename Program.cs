using System;

namespace Counter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o tempo do cronometro no formato 00:00:00");
            string? ConsoleEntry = Console.ReadLine();

            if (ConsoleEntry == null)
            {
                throw new Exception("Houve algum erro");
            }

            var instance = new Counter(ConsoleEntry);

            instance.SecondCounter();

            Console.WriteLine("Contador finalizado");
        }
    }
}
