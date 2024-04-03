using System;
using System.Collections.Generic;
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
            Motocicleta cuatrimoto = new Motocicleta();
            cuatrimoto.año = 2025;
            cuatrimoto.llantas = 4;
            Console.WriteLine("El modelo de la moto es : {0}",cuatrimoto.año);
            cuatrimoto.frenar();
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
