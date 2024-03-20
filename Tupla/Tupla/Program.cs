using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Luis";
            byte edad = 50;
            long numero = 1152214857;
            int dirPostal = 05001;

            //sintaxis tupla
            // (tipo) identificador = (valor);
            // Creamos tuplas

            var Persona1 = (nombre: "Luis", edad: 80,pasaporte: 8152214857,postal: 05001); //identificamos items ni tipo de variables dentro de tupla
            var Persona2 = ("Edgar", 80, 8152214857, 05001); //Sin identificar items ni tipo de variables dentro de tupla
            (string nombre, byte edad, long pasaport ,int postal) Persona3 = ("Juan", 80, 8152214857, 05001); //Identificamos items pero con tipos de variable de tupla
            (string, byte, long, int) Persona4 = ("Riqui", 80, 8152214857, 05001); //Sin identificar items con tipos de variable de tupla

            //Mostrar datos de tupla

            Console.WriteLine("El nombre de la persona 1 es {0} ",Persona1.nombre);
            Console.WriteLine("la edad de la persona 2 es {0} años y el número de su pasaporte es ", Persona2.Item2,Persona2.Item3);
            Console.WriteLine("El pasaporte de la persona 3 es {0} y su nombre es {1} ", Persona3.pasaport,Persona3.nombre);
            Console.WriteLine("El codigo postal  de la persona 4 es  ", Persona4.Item4);
        }
    }
}
