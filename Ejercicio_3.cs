using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Ejercicio
{
    internal class clase_3
    {
        internal class ejercicio3
        {
            public ejercicio3()
            {

            }
            public void analizar()
            {
                Console.WriteLine("Digite un numero");
                String num1 = Console.ReadLine();
                int valor1 = Convert.ToInt32(num1);
                if (valor1 % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es par");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es inpar");
                }
            }

        }
    }
}







