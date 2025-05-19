using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double suma = numero1 + numero2;

        Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}");
    }
}
