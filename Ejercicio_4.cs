using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Ejercicio
{
    internal class ejercicio_4
    {
        public ejercicio_4()
        {

        }
        public void leer()
        {
            int num;
            do
            {
                Console.WriteLine("Digite un numero");
                String valor = Console.ReadLine();
                num = Convert.ToInt32(valor);
            } while (num != 0);

        }
    }
}
    

