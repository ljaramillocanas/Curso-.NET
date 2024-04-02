using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesEscalonadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo [][] nombre = new tipo [filas][];
            double totalVenSem = 0;
            double totalVentas = 0;
            byte sem, day,semAct,venPorSem;
            int i, j;

            Console.WriteLine("Ingrese la cantidad de semanas que estuvo activo ");
            semAct = Convert.ToByte(Console.ReadLine());
            // Creación del arreglo bidimensional para almacenar las ventas
            double[][] ventas = new double[semAct][];
            // Registro de las ventas por semana
            for ( i = 0; i < semAct; i++)
            {
                Console.WriteLine("Ingrese la cantidad de ventas realizadas en la semana {0} ", i + 1);
                venPorSem = Convert.ToByte(Console.ReadLine());
                ventas[i]=new double[venPorSem];
            }
            

            for (i = 0;i < ventas.Length; i++)
            {
                for( j=0;j < ventas[i].Length;j++){
                    Console.WriteLine("ingrese la venta #{0} de la semana #{1}",j+1,i+1);
                    ventas[i][j] = Convert.ToDouble(Console.ReadLine());
                    totalVenSem += ventas[i][j];
                    
                }
                Console.WriteLine("El total vendido en la semana {0} es {1}$",i+1,totalVenSem);
                totalVentas += totalVenSem;
                totalVenSem = 0;
            
            }
            Console.WriteLine("El valor total del lo vendido es {0}$", totalVentas);
            Console.WriteLine("ingrese la semana de la venta que desea consultar");
            sem = Convert.ToByte(Console.ReadLine());   
            Console.WriteLine("ingrese el número de la venta que desea consultar");
            day = Convert.ToByte(Console.ReadLine());
            // Validación de la semana y el número de venta
            if (sem <= 0 || sem > semAct || day <= 0 || day > ventas[sem - 1].Length)
            {
                Console.WriteLine("Error: Semana o número de venta inválido.");
            }
            else
            {
                Console.WriteLine("Venta {0} de la semana {1}: ${2}", day, sem, ventas[sem - 1][day - 1]);
            }
        }
        
    }
}
