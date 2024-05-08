using System;

public class holaMundo{
    public static void Main(string[] args){
        
        Console.Write("Num 1: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("Num 2: ");
        double num2 = double.Parse(Console.ReadLine());
        
        double resp = num1 + num2;

        Console.WriteLine("La Suma es: {0}", resp);
    }
}