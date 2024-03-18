using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password, confi_password;

            Console.WriteLine("Escribe contraseña");
            password = Console.ReadLine();
            Console.WriteLine("Confirma contraseña ");
            confi_password = Console.ReadLine();
            while (password !=confi_password) {
                Console.WriteLine("Contraseña no coincide");
                Console.WriteLine("Confirma de nuevo contraseña");
                confi_password = Console.ReadLine();
            }
            Console.WriteLine("Se guarda exitosamente");
        }
    }
}
