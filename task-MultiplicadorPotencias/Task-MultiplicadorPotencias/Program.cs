using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_MultiplicadorPotencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos aplicativo de consola el cual permita multiplicar un número dado por teclado por una potencia dada por teclado

            // Declaramos variables

            int numero, exponente, i;
            double resultado = 1, resultadoNegativo;

            //Solicitamos números
            Console.WriteLine("Digita el número base que desea potenciar");
            numero = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digita la potencia");
            exponente = Convert.ToInt32(Console.ReadLine());

            //Iniciamos proceso validando exponente 
            if(exponente < 0)
            {
                exponente *= -1; //convertimos a positivo
                for (i = 1; i <= exponente; i++)
                {
                    resultado *= numero; 
                }
                resultadoNegativo = 1/resultado;
                Console.WriteLine("{0}^{1} = {2} ", numero, exponente, resultadoNegativo);
            }else
            {
                for (i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }
                Console.WriteLine("{0}^{1} = {2} ", numero, exponente, resultado);
            }


        }
    }
}
