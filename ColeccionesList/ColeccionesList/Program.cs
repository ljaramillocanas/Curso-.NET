using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string elem;
            int elemns;
            int opc;

            List<string> personas = new List<string>();

            // agregar obj en lista

            do
            {
                Console.WriteLine("1. Agregar elementos");
                Console.WriteLine("2. Mostrar elementos por selección");
                Console.WriteLine("3. Mostrar todos los elementos");
                Console.WriteLine("4. Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese el elemento a almacenar: ");
                        elem = Console.ReadLine();  
                        personas.Add(elem);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el elemento a mostrar: ");
                        elemns = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(personas[elemns]);
                        break;
                    case 3:
                        Console.WriteLine("Todos los elementos son: ");
                        for (int i = 0; i < personas.Count; i++)
                        {
                            Console.WriteLine("Elemento {0} : {1}",i+1,personas[i]);
                        }
                        break;
                }
            }while (opc!=);

        }
    }
}
