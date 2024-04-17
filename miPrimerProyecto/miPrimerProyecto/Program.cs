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
            //clasificar la edad introducida por el usuario.
            int edad = 0;

            Console.Write("Dime tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if( edad<=2 ){
                Console.WriteLine("Eres un bebe");
            }else if( edad<12){
                Console.WriteLine("Eres un niño");
            }else if( edad<18){
                Console.WriteLine("Eres un adolescente");
            }else if( edad<=65){
                Console.WriteLine("Eres un adulto");
            }else {
                Console.WriteLine("Larga vida");
            }
            //Me permite hacer una pausa
            Console.ReadKey();
        }
    }
}
