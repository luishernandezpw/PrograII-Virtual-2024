using System;

public class holaMundo {
    public static void Main(string[] args){
        Console.Write("Tabla de Multiplicar: ");
        int ntabla = int.Parse(Console.ReadLine());

        for(int i=1; i<=10; i++){
            Console.WriteLine("{0}X{1}={2}", ntabla, i, ntabla*i);
        }
    }
}