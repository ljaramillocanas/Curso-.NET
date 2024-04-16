using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            int opc,pos;

            List<string> personas = new List<string>();

            // agregar obj en lista

            do
            {
                Console.WriteLine("BIENVENIDO AL ADMINISTRADOR DE LISTAS \n");
                Console.WriteLine("1. Agregar elementos en orden");
                Console.WriteLine("2. Agregar elementos por posicion");
                Console.WriteLine("3. Quitar elemento por posición ");
                Console.WriteLine("4. Mostrar elementos por selección");
                Console.WriteLine("5. Mostrar todos los elementos");
                Console.WriteLine("6. Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese el elemento a almacenar: ");
                        elem = Console.ReadLine();  
                        personas.Add(elem);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese en que posición desea ingresar el elemento");
                        pos = Convert.ToInt32(Console.ReadLine())-1;
                        Console.WriteLine("Ingrese el elemento a almacenar: ");
                        elem = Console.ReadLine();
                        personas.Insert(pos, elem);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese de que posición desea quitar el elemento");
                        pos = Convert.ToInt32(Console.ReadLine())-1;
                        personas.RemoveAt(pos);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el elemento a mostrar: ");
                        elemns = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(personas[elemns]);
                        break;
                    case 5:
                        Console.WriteLine("Todos los elementos son: ");
                        for (int i = 0; i < personas.Count; i++)
                        {
                            Console.WriteLine("Elemento {0} : {1}",i+1,personas[i]);
                        }
                        Console.WriteLine("Todos los elementos con foreach son: ");
                        foreach (string elemento in personas)
                        {
                            Console.WriteLine(elemento);
                        }
                        break;

                        
                }
            }while (opc!=6);
           
        }
       
    }
}
