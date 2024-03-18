using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**** BIENVENIDO AL CALCULADOR DE .NET *****");
            Console.WriteLine("Escriba su nombre");
            string name = Console.ReadLine();

            Console.WriteLine("{0} Seleccione el calculo que desea realizar ",name);
            Console.WriteLine("1. Calcular área y perimetro del rectangulo");
            Console.WriteLine("2. Calcular  perimetro de un poligono regular");
            Console.WriteLine("3. pasar de centrigrado a grados Farenheit");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    double altura, ancho, area, perimetro;
                    Console.WriteLine("** AREA Y PERIMETRO DEL RECTANGULO **");
                    Console.WriteLine("Dame la altura del rectangulo");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dame la base del rectangulo");
                    ancho = Convert.ToDouble(Console.ReadLine());
                    area = altura * ancho;
                    perimetro = 2 * (altura + ancho);
                    Console.WriteLine("El area del rectangulo es de {0} CM", area);
                    Console.WriteLine("El perimetro del rectangulo es de {0} CM ", perimetro);
                    break;
                case 2:
                    int tip;
                    double longitud, per;
                    Console.WriteLine("** PERIMETRO DE POLIGONo REGULAR **");
                    Console.WriteLine("Seleccione 1. Si es un pentagono");
                    Console.WriteLine("Seleccione 2. Si es un Hexagono");
                    tip = Convert.ToInt32(Console.ReadLine());
                    if (tip == 1)
                    {
                        Console.WriteLine("{0} brindame la logintud de uno de los lados en CM ", name);
                        longitud = Convert.ToDouble(Console.ReadLine());
                        per = 5 * longitud;
                        Console.WriteLine("El perimtero del poligono pentagono regular es de {0} CM ", per);

                    }
                    if (tip == 2)
                    {
                        Console.WriteLine("{0} brindame la logintud de uno de los lados en CM ", name);
                        longitud = Convert.ToDouble(Console.ReadLine());
                        per = 6 * longitud;
                        Console.WriteLine("El perimtero del poligono hexagonal regular es de {0} CM ", per);
                    }
                    break;
                case 3:
                    double celcius, fah;
                    Console.WriteLine("** Convertidor C° a F° **");
                    Console.WriteLine("Brindame los grados centigrados ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    fah = (celcius * 9) / 5 + 32;
                    Console.WriteLine("Los grados {0} C° son igual a {1} F°", celcius, fah);
                    break;


            }   }
    }
}
