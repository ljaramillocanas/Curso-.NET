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
            byte cantidadCal,cantidadAlumnos;
            double  promedio, acomulador=0;
            Console.WriteLine("Ingrese la cantidad de alumnos a promediar");
            cantidadAlumnos = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de calificaciones a promediar");
            cantidadCal = Convert.ToByte(Console.ReadLine());
            //Estructura de matriz
            // tipo [] nombre = new tipo [tamaño]
            // Creamos un arreglo de calificaciones con el tamaño especificado por el usuario
            double[,] calificaciones = new double[cantidadAlumnos,cantidadCal];
            // Solicitamos al usuario que ingrese las calificaciones
            for (int i=0; i < cantidadAlumnos; i++) { 
                for (int j=0; j < cantidadCal; j++) { 
            Console.WriteLine("ingrese la calificación {0} del estudiante #{1}",j+1, i + 1);
                calificaciones[i,j]= Convert.ToDouble(Console.ReadLine());
                acomulador += calificaciones[i,j];
        }
            } 
            // Mostramos las calificaciones ingresadas por el usuario
            Console.WriteLine("Calificaciones ingresadas:");
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                for (int j=0;j < cantidadCal; j++) { 
                Console.WriteLine("Calificación #{2} del estudiante #{0}: {1}", i + 1, calificaciones[i,j],j+1);
                }
            }
            promedio = acomulador / ( cantidadAlumnos * cantidadCal);
            Console.WriteLine("EL promedio de los estudiante es {0}",promedio);
            
        }
    }
}
