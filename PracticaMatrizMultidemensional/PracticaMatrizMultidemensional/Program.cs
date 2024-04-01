using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    // Clase Program que contiene el método Main, punto de entrada del programa
    internal class Program
    {
        // Método principal del programa
        static void Main(string[] args)
        {
            // Declaración de variables para almacenar la cantidad de calificaciones y alumnos
            byte cantidadCal, cantidadAlumnos;
            double promedio, acumulador = 0; // Declara las variables para el promedio y la sumatoria de calificaciones

            // Solicita al usuario que ingrese la cantidad de alumnos a promediar
            Console.WriteLine("Ingrese la cantidad de alumnos a promediar");
            cantidadAlumnos = Convert.ToByte(Console.ReadLine());

            // Solicita al usuario que ingrese la cantidad de calificaciones a promediar
            Console.WriteLine("Ingrese la cantidad de calificaciones a promediar");
            cantidadCal = Convert.ToByte(Console.ReadLine());

            // Declara una matriz para almacenar las calificaciones de los alumnos
            double[,] calificaciones = new double[cantidadAlumnos, cantidadCal];

            // Solicita al usuario que ingrese las calificaciones
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                for (int j = 0; j < cantidadCal; j++)
                {
                    // Solicita al usuario que ingrese la calificación del estudiante
                    Console.WriteLine("Ingrese la calificación {0} del estudiante #{1}", j + 1, i + 1);
                    // Almacena la calificación ingresada por el usuario en la matriz de calificaciones
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                    // Calcula la sumatoria de calificaciones
                    acumulador += calificaciones[i, j];
                }
            }

            // Muestra las calificaciones ingresadas por el usuario
            Console.WriteLine("Calificaciones ingresadas:");
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                for (int j = 0; j < cantidadCal; j++)
                {
                    // Muestra la calificación de cada estudiante
                    Console.WriteLine("Calificación #{2} del estudiante #{0}: {1}", i + 1, calificaciones[i, j], j + 1);
                }
            }

            // Calcula el promedio de todas las calificaciones ingresadas
            promedio = acumulador / (cantidadAlumnos * cantidadCal);
            // Muestra el promedio de los estudiantes
            Console.WriteLine("El promedio de los estudiantes es {0}", promedio);
        }
    }
}
