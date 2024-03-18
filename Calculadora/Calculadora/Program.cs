using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA, numB, opc, resultado;
            Console.WriteLine("BIENVENIDO A LA PRIMERA CALCULADORA EN .NET");
            Console.WriteLine("DIJE SU NOMBRE POR FAVOR");
            string name = Console.ReadLine();
            
          
            do { 
                Console.WriteLine("Sr.Seleccione el tipo de operación que desea realizar : ");
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACIÓN");
                Console.WriteLine("4. DIVISIÓN");
                Console.WriteLine("5. FINALIZAR");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} Digite el primer número : ", name);
                numA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} Digite el segundo número", name);
                numB = Convert.ToInt32(Console.ReadLine());


                switch (opc)
                {
                    case 1:
                        resultado = numA + numB;
                        Console.WriteLine("El resultado de su suma es : " + resultado);
                        break;

                    case 2:
                        resultado = numA - numB;
                        Console.WriteLine("El resultado de su resta es : " + resultado);
                        break;

                    case 3:
                        resultado = numA * numB;
                        Console.WriteLine("El resultado de la multiplicación es :" + resultado);
                        break;

                    case 4:
                        if (numB == 0)
                        {
                            Console.WriteLine("No se puede realizar división ya que el denominador es cero");
                        }
                        else
                        {
                            resultado = (numA / numB);
                            Console.WriteLine("El resultado de la división es : " + resultado);
                        }
                        break;
                   
                }

            }while (opc!=5);
        }
    }
}
