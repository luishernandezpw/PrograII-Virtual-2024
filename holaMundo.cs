using System;

public class holaMundo {
    public static void Main(string[] args){
        Console.WriteLine("Calcular la Edad Promedio");
        int suma=0;
        for(int i=1; i<=15; i++){
            Console.Write("Edad {0}: ", i);
            int edad = int.Parse(Console.ReadLine());
            suma += edad;
        }
        double edadProm = suma/15;
        Console.WriteLine("Edad Promedio: {0}", edadProm);
    }
}