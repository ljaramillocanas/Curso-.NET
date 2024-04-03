using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MetodosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Los valores de la matriz unidimensional son :");

            ImprimirMatriz(matriz);

            double[,] matriz2D = { { 1,4,7 },
                                    {5,8,9 },
                                    {7,5,10 } };

            Console.WriteLine("Los valores de la matriz multidimensional  son :");
            ImprimirMatriz2D(matriz2D);
            Console.WriteLine(matriz2D.GetLength(1));

        }

        //Metodo para imprimir matriz 

        static void ImprimirMatriz(int[] matrizPa)
        {
            for (int i = 0; i < matrizPa.Length; i++)
            {
                Console.WriteLine(matrizPa[i]);
            }
        }
        static void ImprimirMatriz2D(double[,] matriz2DPa)
        {
            for (int i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2DPa.GetLength(1); j++) 
                { 
                Console.WriteLine(matriz2DPa[i,j]);
                }
            }
        }
    }
}
