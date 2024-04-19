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
                //Desarrollar el ejercicio de la secuencia fibonacci
                int a = 1, b = 0, c = 0;
                do {
                    c = a + b;
                    Console.WriteLine("{0}+{1}={2}", a, b, c);
                    b = a;
                    a = c;
                }while (c < 1000);

                Console.Write("Cualquier tecla para continuar, 's' para salir: ");
                continuar = !Console.ReadLine().Equals("s");
            }
        }

    }
}
