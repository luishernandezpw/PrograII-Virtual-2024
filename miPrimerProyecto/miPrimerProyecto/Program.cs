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
            //Ejercicio de sumar dos numeros.
            int num1 = 5, num2 = 2, respuesta = 0;
            respuesta = num1 + num2;
            Console.WriteLine("La suma es: "+ respuesta);//WriteLine permite imprimir en consola una cadena
                                                         // y da un salto de linea
            

            //Me permite hacer una pausa
            Console.ReadKey();
        }
    }
}
