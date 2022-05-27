using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Ejercicio
{
    internal class ejercicio_6
    {
        public ejercicio_6()
        {

        }
        public void sumar()
        {
            int num;
            int total = 0;
            do
            {
                Console.WriteLine("Escriba un numero (para finalizar ingrese un cero) ");
                String valor = Console.ReadLine();
                num = Convert.ToInt32(valor);
                total = num + total;
            } while (num != 0);
            Console.WriteLine("El resultado de la suma es: " + total);
        }
    }
}
    