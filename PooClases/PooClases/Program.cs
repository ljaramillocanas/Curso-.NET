using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PooClases
{
     class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Seleccione el VH que desea consultar");
            Console.WriteLine("1. Cuatrimoto");
            Console.WriteLine("2. Enduro ");

            int sel = Convert.ToInt32(Console.ReadLine());  
            if(sel == 1) { 

                Motocicleta cuatrimoto = new Motocicleta();
                cuatrimoto.año = 2025;
                cuatrimoto.llantas = 4;
                cuatrimoto.combustible = "ACP";
                Console.WriteLine("*** CUATRIMOTO *** ");
                Console.WriteLine("El modelo de la cuatrimoto es : {0}", cuatrimoto.año);
                Console.WriteLine("El combustible de la cuatrimoto es : {0}", cuatrimoto.combustible);
                cuatrimoto.frenar();
                Console.WriteLine("La cantidad de llantas del VH : {0}", cuatrimoto.llantas);
            }
            if (sel == 2 ) {  
                Motocicleta Enduro = new Motocicleta();
                Enduro.año = 2024;
                Enduro.llantas = 2;
                Enduro.combustible = "Extra";
            
                Console.WriteLine("*** ENDURO *** ");
                Enduro.acelar();
                Console.WriteLine("El modelo de la enduro  es : {0}", Enduro.año);
                Console.WriteLine("El combustible de la enduro es : {0}", Enduro.combustible);
                Console.WriteLine("La cantidad de llantas de la enduro  es : {0}", Enduro.llantas);
            }
        }
        
    }
    
    
    // Se crea clase Motocicleta
    public class Motocicleta
    {
        //Campos
        public string color, modelo, combustible;
        public int año, numPuertas, ccMotor, llantas;
       
        //Métodos

        public bool acelar()
        {
            bool acelerar = true;
            Console.WriteLine("Estamosa acelerando");
            return acelerar;
        }
        public bool frenar()
        {
            bool acelerar = true;
            Console.WriteLine("Estamos frenando");
            return acelerar;
        }
        public bool estacionando()
        {
            bool acelerar = true;
            Console.WriteLine("Estamosa estacionando");
            return acelerar;
        }
        public void velocidades(ref byte velocidadesPa)
        {
            velocidadesPa++;
            Console.WriteLine("Cambiando la velocidad");
        }

    }


}
