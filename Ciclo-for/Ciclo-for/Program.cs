using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessinThree
{
    internal class Program
    {
        static void Main(string[] args)

        {
            byte num_alumnos;
            double cal1, promedio=0;

            Console.WriteLine("ingrese la cantidad de alumnos");
            num_alumnos = Convert.ToByte(Console.ReadLine());
           

            for (int i = 1; i <= num_alumnos ; i++) {
                Console.WriteLine("Dame la calificación del {0} alumno",i);
                cal1 = Convert.ToDouble(Console.ReadLine()) ;
                promedio += cal1 ;
                
            }
            promedio /= num_alumnos;
            Console.WriteLine("El promedio es : " + promedio);
            
        }
    }
}
