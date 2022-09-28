using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numero;

            Console.WriteLine("Dame el numero y te dire si es par o impar");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");

            }
            else
            {
                Console.WriteLine("El numero es impar");

            }
        }
    }
}
