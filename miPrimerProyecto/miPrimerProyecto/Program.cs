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
            //Ejercicio de sumar dos numeros introducidos por el usuario
            int num1 = 0, num2 = 0, respuesta = 0;
            Console.Write("Num 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            num2 = int.Parse(Console.ReadLine());

            respuesta = num1 + num2;
            Console.WriteLine("La suma es: "+ respuesta);//WriteLine permite imprimir en consola una cadena
                                                         // y da un salto de linea
            
            //Me permite hacer una pausa
            Console.ReadKey();
        }
    }
}
