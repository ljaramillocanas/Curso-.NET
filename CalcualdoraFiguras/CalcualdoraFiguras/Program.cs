using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalcualdoraFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radioAr, baseAr, alturaAr, ladoAr, area;
            byte opcion;

            Console.WriteLine("SELECCIONA LA FIGURA A LA QUE DESEAS CALCULAR AREA");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Trianglo");
            Console.WriteLine("3. CUadrado");
            opcion = Convert.ToByte(Console.ReadLine());    

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Dame el valor del radio de tu circulo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());
                    area = Circulo(radioAr);
                    Console.WriteLine("El área del cicurlo es de : {0} CM ",area);
                    break;

                case 2:
                    Console.WriteLine("Dame el valor de la base del triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dame el valor de la altura del triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());
                    area=Triangulo(baseAr, alturaAr);
                    Console.WriteLine("El área del triangulo es de {0} CM ", area);

                    break;
                case 3:
                    Console.WriteLine("Dame el valor du uno de los lados de tu cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());
                    area=Cuadrado(ladoAr);
                    Console.WriteLine("El área del cuadrado es {0} CM ", area);

                    break;
            }

           
        }
        static double Circulo(double radioPa)
        {
            double area;
            area = Math.PI * (radioPa * radioPa);
            return area;

        }
        static double Triangulo(double basePa,double alturaPa)
        {
            double area;
            area = (basePa * alturaPa)/2;
            return area;

        }
        static double Cuadrado(double LadoPa)
        {
            double area;
            area = LadoPa* LadoPa;
            return area;

        }


    }
}
