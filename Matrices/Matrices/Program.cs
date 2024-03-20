using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte tamaño;
            double promedio, acomulador=0;
            Console.WriteLine("Ingrese la cantidad de calificaciones a promediar");
            tamaño = Convert.ToByte(Console.ReadLine());
            //Estructura de matriz
            // tipo [] nombre = new tipo [tamaño]
            // Creamos un arreglo de calificaciones con el tamaño especificado por el usuario
            double[] calificaciones = new double[tamaño];
            // Solicitamos al usuario que ingrese las calificaciones
            for (int i=0; i < calificaciones.Length; i++) { 
            Console.WriteLine("ingrese la calificación #{0}", i + 1);
                calificaciones[i]= Convert.ToDouble(Console.ReadLine());
                acomulador += calificaciones[i];
        }
            // Mostramos las calificaciones ingresadas por el usuario
            Console.WriteLine("Calificaciones ingresadas:");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Calificación #{0}: {1}", i + 1, calificaciones[i]);
            }
            promedio = acomulador / tamaño;
            Console.WriteLine("EL promedio del estudiante es {0}",promedio);
            
        }
    }
}
