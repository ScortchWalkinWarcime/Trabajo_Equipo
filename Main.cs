using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1. Sumar dos números.");
            Console.WriteLine("2. Restar dos números.");
            Console.WriteLine("3. Multiplicar dos números.");
            Console.WriteLine("4. Salir del programa.");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 3)
            {
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {Sumar(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {Resta(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                        break;
                }
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

            if (opcion != 4)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }

    public static float Resta(float num1, float num2)
    {
        return num1 - num2;
    }

    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }
}
