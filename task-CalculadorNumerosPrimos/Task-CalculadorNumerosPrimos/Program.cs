using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_CalculadorNumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor, numDivisores = 0; 

            for (numero = 2; numero <= 100;numero++) {
                for(divisor = 1; divisor <= numero; divisor++)
                {
                    if(numero %divisor == 0)
                    {
                        numDivisores += 1; //asignación compuesta
                    }
                }   
                //verificamos que los divisores sean iguales a dos
                if(numDivisores <= 2)
                {
                    Console.WriteLine(numero);
                }
                //reiniciamos conteo de numero de divisores
                numDivisores = 0;
            
            }
            Console.ReadKey();
        }
    }
}
