using System;
namespace Uppgift_3._16
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine(" Hur lång är din låt. minimum  2 minuter och 45 second, maximalt 4 minuter och 20 sekunder ");
            int Längdminut = int.Parse(Console.ReadLine());
            int sek = int.Parse(Console.ReadLine());
            int m = Längdminut + 60;
            int total = sek + m;

            if (total <= 165 || total >=265)
            {
                Console.WriteLine(" Din låt får spelas på radiostationen");
            }
            else
            {
                Console.WriteLine("Din låt får inte spelas på raduiostationen");
            }
        }
    }
}
