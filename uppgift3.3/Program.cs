using System;
namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;
            if (kostnad > 950)
             
            {
                kostnad = 950;
            }
            Console.WriteLine($"Kostnaden för att hyra bilen i {timmar} timmar är {kostnad} kr.");
            Console.ReadKey();
        }
    }
}





