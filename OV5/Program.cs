using System;

namespace Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Mata in tal {i}: ");
                double tal = double.Parse(Console.ReadLine());
                summa += tal;
            }

            
            double medelvarde = summa / 10;
            Console.WriteLine($"Medelvärdet är {medelvarde}");

            
            Console.WriteLine("Tryck på en tangent för att avsluta...");
            
        }
    }
}
