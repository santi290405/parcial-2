using System;

class Program
{
    static string[] InvertirArray(string[] arr)
    {
       
        string[] invertido = new string[arr.Length];

        
        for (int i = 0; i < arr.Length; i++)
        {
            invertido[i] = arr[arr.Length - 1 - i];
        }

        return invertido;
    }

    static void Main()
    {
       
        Console.Write("Ingrese la cantidad de elementos del array: ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 0)
        {
            Console.WriteLine("Error: Debe ingresar un número positivo.");
            Console.Write("Ingrese la cantidad de elementos del array: ");
            n = int.Parse(Console.ReadLine());
        }

       
        string[] arrayOriginal = new string[n];

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            arrayOriginal[i] = Console.ReadLine();
        }

      
        string[] arrayInvertido = InvertirArray(arrayOriginal);

     
        Console.WriteLine("\nArray original: [" + string.Join(", ", arrayOriginal) + "]");
        Console.WriteLine("Array invertido: [" + string.Join(", ", arrayInvertido) + "]");
    }
}