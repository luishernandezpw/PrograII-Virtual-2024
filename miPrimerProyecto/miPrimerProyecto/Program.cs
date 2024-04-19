using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while (continuar) {
                Console.Clear();//Limpia la consola
                //Desarrollar el ejercicio de una tabla de multiplicar.
                Console.Write("Tabla: ");
                int tabla = int.Parse(Console.ReadLine());
                for(int i=1; i<=10; i++) {
                    Console.WriteLine("{0}x{1}={2}", tabla, i, tabla*i);
                }
                Console.Write("Cualquier tecla para continuar, 's' para salir: ");
                continuar = !Console.ReadLine().Equals("s");
            }
        }
    }
}
