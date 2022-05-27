using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Ejercicio
{
    internal class ejercicio__1
    {
         
        public ejercicio__1()
        {

        }
        public void funcion()
        {
            Console.WriteLine("inserte el primer numero");
            String numero = Console.ReadLine();
            int var1 = Convert.ToInt32(numero);
            Console.WriteLine("inserte el segundo numero");
            String num1 = Console.ReadLine();
            int var2 = Convert.ToInt32(num1);
            if (var1 > var2)
            {
                Console.WriteLine(numero + " es mayor");
            }
            else
            {
                Console.WriteLine(num1 + " es mayor");
            }
        }
    }
}
    

