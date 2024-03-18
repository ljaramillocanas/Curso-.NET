using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre");
            string name = Console.ReadLine();   
            Console.WriteLine("Hola " + name + "Gracias por estar aqui");
            Console.WriteLine("Bienvenido a la primera gestión realizada en .NET");
            Console.ReadKey();
        }
    }
}
