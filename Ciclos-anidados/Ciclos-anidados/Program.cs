using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declaramos variables 
             * i para bucle exterior
             * j para bucle interno
            */

            int i, j, resultado;
            
            for(i=1; i <= 10; i++)
            {
                Console.WriteLine("Tabla multiplicar del {0}",i);
                for(j=1; j <= 10; j++)
                {
                    resultado = i*j;
                    Console.WriteLine("{0} * {1} = {2} ",i,j,resultado);
                }

            }

        }
    }
}
