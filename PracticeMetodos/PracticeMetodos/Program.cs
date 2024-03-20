using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numAr;
            string saludoAr;
            int numPrimoAr;
            

            prueba(out numAr, out saludoAr,out numPrimoAr);

            Console.WriteLine(numAr+saludoAr+numPrimoAr);

        }

        static void prueba (out byte numPa, out string saludoPa, out int numPrimoPa)
        {
            numPa = 20;
            saludoPa = " Hello World, its methods ";
            numPrimoPa = 70;
        }
    }
}
