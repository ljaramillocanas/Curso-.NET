using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesMultidemensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo[,] name = new tipo [filas,columnas]
            double[,] ventas = new double[4, 3]
            {
                {100,120,205 },
                {115,196,300 },
                {157,172,245 },
                {130,180,281}
            };

            //Console.WriteLine(ventas[3, 2]);

            // Imprimir la matriz en orden ascendente por filas y columnas
            for (int i = 0; i < 4; i++) // Iterar sobre las filas de la matriz
            {
                Console.WriteLine(""); // Imprimir una línea en blanco para separar las filas

                // Imprimir el número de fila actual
                Console.WriteLine("Fila{0}", i);

                for (int j = 0; j < 3; j++) // Iterar sobre las columnas de la matriz
                {
                    // Imprimir el valor actual de la matriz seguido de una coma
                    Console.Write(ventas[i, j] + ",");
                }
            }

            // Imprimir la matriz en orden descendente por filas
            for (int i = 3; i >= 0; i--) // Iterar sobre las filas de la matriz en orden inverso
            {
                Console.WriteLine("");
                Console.WriteLine("Fila{0}", i);

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ventas[i, j] + ",");
                }
            }

                // Imprimir la matriz en orden descendente por filas y columnas
                for (int i = 3; i >= 0; i--) // Iterar sobre las filas de la matriz en orden inverso
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fila{0}", i);

                    for (int j = 2; j >= 0; j--) // Iterar sobre las columnas de la matriz en orden inverso
                    {
                        // Imprimir el valor actual de la matriz en una nueva línea
                        Console.Write(ventas[i, j] + ",");
                    }
                }

            //// Declaración de matriz de < 3
            
            int[,,] matriz3D = new int[2, 2, 3]
            {{{1,2,3}, {4,5,6 }   },
                { {7,8,9 },{10,11,12} }
            };
            Console.WriteLine(matriz3D[1, 1, 1]);
        }
        }
    }

