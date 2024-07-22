using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumaraOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NubmerGame();

            }
            catch (Exception)
            {
                NubmerGame();
              
            }
    
            Console.ReadLine();
        }
        static void NubmerGame()
        {
            int number = new Random().Next(1, 51);

            int KalanHak = 10;
            Console.WriteLine("İsminiz");
            string name = Console.ReadLine();

            Console.WriteLine("Tahminizini giriniz:");
            int userNumber = int.Parse(Console.ReadLine());

            while (userNumber != number)
            {
                KalanHak--;
                if (Math.Abs(number - userNumber) < 5)
                {
                    Console.WriteLine("Sıcak");
                }
                else
                {
                    Console.WriteLine("Soğuk");

                }
                userNumber = int.Parse(Console.ReadLine());
                if (KalanHak == 0)
                {
                    Console.WriteLine("Hakkınız bitti :(" + name + ".Mallesef bulamadınız. Rakam: " + number);
                    break;
                }
            }
            if (userNumber == number)
            {
                Console.WriteLine("Tebrikler");
            }
        }
    }
}
