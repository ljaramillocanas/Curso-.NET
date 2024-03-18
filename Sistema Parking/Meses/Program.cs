using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc1, opc2;
            Console.WriteLine("**** BIENVENIDO ****");
            Console.WriteLine("Digite su nombre por favor");
            string name = Console.ReadLine();
            do {
                Console.WriteLine("{0} Seleccione una opcion:",name);
                Console.WriteLine("1. Para iniciar programa de meses ", name);
                Console.WriteLine("2. Para iniciar programa par / impar ", name);
                Console.WriteLine("3. Para iniciar programa parking  ", name);
                Console.WriteLine("4. para cerrar el programa",name);
                opc1 = Convert.ToInt32(Console.ReadLine());

                switch (opc1)
                {
                    case 1:

                        Console.WriteLine("*** BIENVENIDO AL INFORMADOR DE MESES ***");
                        Console.WriteLine("{0} Digite el numero de mes que desea consultar", name);
                        opc2 = Convert.ToInt32(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1:
                                Console.WriteLine(" El mes que corresponde a su selección es Enero ");
                                break;
                            case 2:
                                Console.WriteLine(" El mes que corresponde a su selección es Febrero ");
                                break;
                            case 3:
                                Console.WriteLine(" El mes que corresponde a su selección es Marzo ");
                                break;
                            case 4:
                                Console.WriteLine(" El mes que corresponde a su selección es Abril ");
                                break;
                            case 5:
                                Console.WriteLine(" El mes que corresponde a su selección es Mayo ");
                                break;
                            case 6:
                                Console.WriteLine(" El mes que corresponde a su selección es Junio ");
                                break;
                            case 7:
                                Console.WriteLine(" El mes que corresponde a su selección es Julio "); ;
                                break;
                            case 8:
                                Console.WriteLine(" El mes que corresponde a su selección es Agosto ");
                                break;
                            case 9:
                                Console.WriteLine(" El mes que corresponde a su selección es Septiembre ");
                                break;
                            case 10:
                                Console.WriteLine(" El mes que corresponde a su selección es Octubre ");
                                break;
                            case 11:
                                Console.WriteLine(" El mes que corresponde a su selección es Noviembre  ");
                                break;
                            case 12:
                                Console.WriteLine(" El mes que corresponde a su selección es Diciembre  ");
                                break;
                            default:
                                Console.WriteLine("{0] el mes {1} no existe, intente de nuevo", name, opc2);
                                break;
                        }
                        break;
                    case 2:
                        int num;
                        Console.WriteLine("*** BIENVENIDO AL VERIFICADOR DE NUMERO PAR / IMPAR ***");
                        Console.WriteLine("{0} digite el número que desea conocer si es par o impar");
                        num = Convert.ToInt32(Console.ReadLine());
                        if ((num % 2) == 0)
                        {
                            Console.WriteLine("El numero es par");

                        }
                        else
                        {
                            Console.WriteLine("El numero es impar");
                        }
                        break;

                    case 3:
                        double total_pagar;
                        int tiempo;
                        string placa; 
                        Console.WriteLine("*** BIENVENIDO AL SYSTEMA DE PARKEO ***");
                        Console.WriteLine("Digita la placa del vehiculo");
                        placa = Console.ReadLine();
                        Console.WriteLine("INFORME EL TIEMPO EN MINUTOS QUE ESTUVO PARQUEADO EL VEHICULO");
                        tiempo = Convert.ToInt32(Console.ReadLine());

                        if (tiempo < 60)
                        {
                            total_pagar = 5.00;
                            Console.WriteLine("El valor a pagar del vehiculo {1} es de {0} dolares", total_pagar, placa);
                        }else if (tiempo < 120 )
                        {
                            total_pagar = 15.00;
                            Console.WriteLine("El valor a pagar del vehiculo {1} es de {0} dolares", total_pagar, placa);
                        }
                        else if (tiempo > 120)
                        {
                            total_pagar = 40.00;
                            Console.WriteLine("El valor a pagar del vehiculo {1} es de {0} dolares", total_pagar, placa);
                        }
                        break;

                }

            }while(opc1 != 4);


        }
    }
}
