using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PooClases
{
     class Program
    {
        static void Main(string[] args)

        {
            Motocicleta motocicleta = new Motocicleta();
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su primer apellido");
            string apellido = Console.ReadLine();
            String NombreC = motocicleta.Concatenar(nombre, apellido);
            Console.WriteLine("Sr.(a) {0} Ingrese el VH que dese consultar",NombreC);
            Console.WriteLine("1. Cuatrimoto");
            Console.WriteLine("2. Enduro ");
            
            

            int sel = Convert.ToInt32(Console.ReadLine());  
            if(sel == 1) { 

                Motocicleta cuatrimoto = new Motocicleta();
                
                cuatrimoto.Año = "2025";
                cuatrimoto.Llantas = 4;
                cuatrimoto.Combustible = "ACPM";
                cuatrimoto.NumPuertas = "N/A";
                cuatrimoto.CCmotor = 1600;
                cuatrimoto.Color = "Rojo";
                cuatrimoto.Cajuela = true;
                
                Console.WriteLine(cuatrimoto.ToString());
            }
            if (sel == 2 ) {  
                Motocicleta Enduro = new Motocicleta();
                Enduro.Año = "2024";
                Enduro.Llantas = 2;
                Enduro.Combustible = "Extra";
                Enduro.NumPuertas = "N/A";
                Enduro.CCmotor = 100;
                Enduro.Color = "Blanco Perla";
                Console.WriteLine(Enduro.ToString());

            }
           
        }
        
    }


    // Se crea clase Motocicleta
    public class Motocicleta
    {
        //Campos
        private string color, combustible, año, numPuertas;
        private int ccMotor, llantas, nPasajeros;
        private bool cajuela;
        public bool Cajuela
        {
            get { return cajuela; }
            set { cajuela = value; }

        }
        public string Año
        {
            get => año;
            set => año = value;
        }
        public int Llantas
        {
            get { return llantas; }
            set { llantas = value; }
            
        }
        public string Combustible
        {
            get { return combustible; }
            set { combustible = value; }
        }
        public string Color
        {
            get => color;
            set => color = value;
        }
        public string NumPuertas
        {
            get => numPuertas;
            set => numPuertas = value;
        }
        public int CCmotor
        {
            get { return ccMotor; }
            set { ccMotor = value; }
        }

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

        //Contructor de la clase
        public Motocicleta()
        {

            nPasajeros = 2;
            cajuela = false;

        }

        //invalidando el metodo ToString
        public override string ToString()
        { 
           string mensaje = "[Modelo : " + año + "] [Color : " + color + "] [Puertas : "+ numPuertas + "] "+ "\n[Combustible : "+ combustible + "] [Llantas : "+llantas  +"] [cajuela: " + cajuela +"]" ;
            return mensaje;
        }

        //Metodo para concatenar nombres
        public string Concatenar(string name,string lastname)
        {
            string nombreCompleto = name + lastname;

            return nombreCompleto;
        }

        //Sobrecarga del metodo para concatenar nombres
        public string Concatenar(string name, string lastName, string lastName2)
        {
            string nombreCompleto = name + "" + lastName + "" + lastName2;

            return nombreCompleto;
        }

    }


}
