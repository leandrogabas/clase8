using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificarprimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("ingrese un numero:");
            
            string vartex=Console.ReadLine();

            num = Convert.ToInt32(vartex);

            int contador_divisible = 0;

            for (int i = 1; i <= num; i++) 
            {
               if (num % i == 0)
                    contador_divisible++;
           
            }

            if (contador_divisible > 2) 
            {
                 Console.WriteLine("el numero no es primo");
            }  else
            {
              Console.WriteLine("el numero es primo");
            }
             Console.ReadKey();
        }
    }
}
