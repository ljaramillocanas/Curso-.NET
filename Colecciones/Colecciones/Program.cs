using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno valorElemento;
            string valorDocumento;
            

            GuardaObjetos<Alumno> objetos = new GuardaObjetos<Alumno>(3);

            Alumno alumno1 = new Alumno(5);
            Alumno alumno2 = new Alumno(4.5);
            Alumno alumno3 = new Alumno(3.5);

            objetos.AgregarElementos(alumno1);
            objetos.AgregarElementos(alumno2);
            objetos.AgregarElementos(alumno3);

            valorElemento = objetos.ObtenerElemento(0);
            Console.WriteLine(valorElemento.Calificacion);

            GuardaObjetos<string> objString = new GuardaObjetos<string>(2);
            objString.AgregarElementos("Luis");
            objString.AgregarElementos("Luis Jaramillo ");
            valorDocumento = objString.ObtenerElemento(1);
            Console.WriteLine(valorDocumento);
            
        }
    }

    class GuardaObjetos<T>
    {

        private int i = 0;
        private T[] matrizElementos;

        public GuardaObjetos(int elementosPa)
        {
            matrizElementos = new T[elementosPa];  
        }

        public void AgregarElementos(T elementoPa)
        {
            matrizElementos[i] = elementoPa;    
            i++;
        }
        public T ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }
    }
    class Alumno
    {
        double calificacion;

        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }
        public double Calificacion
        {
            get { return calificacion; }
        }
    }
  
}
