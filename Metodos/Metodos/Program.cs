using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            decimal r; //almacena el valor del metodo restar
            decimal num1Ar, num2Ar; //almacena datos para enviar a metodo multiplicar y dividir
            (decimal num1, decimal num2, decimal resultado) numeros; // declaramos tupla

            

            do
            {
                Console.WriteLine("SELECCIONE UNA OPCION");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                opcion= Convert.ToByte(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4 )  );
            
            switch ( opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    numeros=resta(); // se asigna tupla a la resta por medio de return
                    Console.WriteLine("{0} - {1} = {2}", numeros.num1, numeros.num2, numeros.resultado); // se muestran datos con tupla

                    break;
                case 3:
                    num1Ar = numero("Ingresa el primer número");
                    num2Ar = numero("Ingresa el segundo número");
                    
                    //invocación de metodo
                    Multiplicar(num1Ar,num2Ar);

                    break;
                case 4:
                    num1Ar = numero("Ingresa el primer número");
                    num2Ar = numero("Ingresa el segundo número");
                    r = dividir(num1Ar,num2Ar);
                    break;
            }
        }

        //Metodo que no devuelve ni tipo ni parametros
        static void Suma()
        {
            decimal num1, num2, resultado;
            Console.WriteLine("Ingresa el primer número");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingresa el primer número");
            num2 = Convert.ToDecimal(Console.ReadLine());
            
            resultado = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }

        //Metodo que no devuelve  tipo sin parametros
        static (decimal,decimal,decimal) resta ()
        {
            decimal num1, num2, resultado;
            Console.WriteLine("Ingresa el primer número");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingresa el primer número");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;
            
            //devolvemos multiples tipos al autor de llamado
            return (num1,num2,resultado);
        }

        //Metodo que no devuelve  tipo pero si parametros
        static void Multiplicar(decimal num1Ar, decimal num2Ar)
        {
            decimal resultado;

            resultado = num1Ar * num2Ar;
            Console.WriteLine("{0} * {1} = {2}", num1Ar, num2Ar, resultado);
        }
        
        //Metodo que  devuelve tipo y parametros
        static decimal dividir(decimal num1Ar,  decimal num2Ar)
        {
            decimal resultado =0;

            if (num2Ar != 0) { 
                resultado = num1Ar / num2Ar;
                Console.WriteLine("{0} % {1} = {2}", num1Ar, num2Ar, resultado);
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
            }

            return resultado;
        }

        //metodo para tomar numero
        static decimal numero(string peticion) {

            decimal numero;
            Console.WriteLine(peticion);
            numero = Convert.ToDecimal(Console.ReadLine());
           
            return numero;
        }

    }
}
