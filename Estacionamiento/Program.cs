using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            double min;

            Console.WriteLine("Dame los minutos:");
            min = Convert.ToDouble(Console.ReadLine());

            if (min <= 60)
            {
                Console.WriteLine("Pagas $5 pesos");

            }
            if (min >= 61 & min <= 120)
            {
                Console.WriteLine("Pagas $15 pesos");

            }
            if (min > 121)
            {
                Console.WriteLine("Pagas $40 pesos");

            }
        }
    }
}
