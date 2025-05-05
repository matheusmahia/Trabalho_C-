using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int somaPares = 0;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                Console.Write($"Número {i + 1}: ");
            }
            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
        }
        Console.WriteLine($"\nA soma dos números pares é: {somaPares}");
    }
}