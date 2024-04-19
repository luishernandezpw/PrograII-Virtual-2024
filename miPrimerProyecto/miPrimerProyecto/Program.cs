using System;
using System.Collections.Generic;
using System.Data;
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
                Console.WriteLine("::.. MENU ..::");
                Console.WriteLine("1. Tabla de multiplicar");
                Console.WriteLine("2. Serie de Fibonacci");
                Console.WriteLine("3. Clasificación de edad");
                Console.WriteLine("4. Par o impar");
                Console.WriteLine("5. Determinar primo");
                Console.WriteLine("Salir cualquier otro numero");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        Console.Clear();
                        tablaMultiplicar();
                        break;
                    case 2:
                        Console.Clear();
                        fibonacci();
                        break;
                    case 3:
                        Console.Clear();
                        clasificacionEdad();
                        break;
                    case 4:
                        Console.Clear();
                        parImpar();
                        break;
                    case 5:
                        Console.Clear();
                        determinarPrimo();
                        break;
                    default:
                        continuar = false;
                        break;
                }
            }
        }
        static void determinarPrimo() {
            Console.Write("Numero: ");
            int num = int.Parse(Console.ReadLine());
            int i = 1, acum=0;
            while (i <= num) {
                if( num%i==0) {
                    acum++; //acum = acum + 1;
                }
                if( acum>2 ) {
                    i = num + 1;
                }
                i++;
            }
            if( acum<=2) {
                Console.WriteLine("{0} es primo", num);
            } else {
                Console.WriteLine("{0} NO es primo", num);
            }
        }
        static void parImpar() {
            Console.Write("Numero: ");
            int num = int.Parse(Console.ReadLine());

            if( num%2 == 0) {
                Console.WriteLine("{0} es par", num);
            } else {
                Console.WriteLine("{0} es impar", num);
            }
        }
        static void tablaMultiplicar() {
            Console.Write("Tabla: ");
            int tabla = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("{0}x{1}={2}", tabla, i, tabla * i);
            }
        }
        static void fibonacci() {
            int a = 1, b = 0, c = 0;
            do {
                c = a + b;
                Console.WriteLine("{0}+{1}={2}", a, b, c);
                b = a;
                a = c;
            } while (c < 1000);
        }
        static void clasificacionEdad() {
            int edad = 0;
            Console.Write("Dime tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad <= 2) {
                Console.WriteLine("Eres un bebe");
            } else if (edad < 12) {
                Console.WriteLine("Eres un niño");
            } else if (edad < 18) {
                Console.WriteLine("Eres un adolescente");
            } else if (edad <= 65) {
                Console.WriteLine("Eres un adulto");
            } else {
                Console.WriteLine("Larga vida");
            }
        }
    }
}
