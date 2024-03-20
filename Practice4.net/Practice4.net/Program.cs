using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grados;
            double radianes;
            Console.WriteLine("Ingresa los grados que deseas convertir a radianes");
            grados = Convert.ToInt32(Console.ReadLine());
            radianes = CenaRad(grados);
            Console.WriteLine("{0} grados son igual a {1} radianes",grados,radianes);

        }

        static double CenaRad(int grados)
        {
            double radianes;

             radianes = grados* Math.PI / 180;
            

            return radianes;
        }
    }
}
