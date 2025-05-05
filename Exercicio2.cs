using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver sua tabuada: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Inválido! Digite um número inteiro.");
            Console.Write("Digite um número para ver sua tabuada: ");
        }
        Console.WriteLine($"\n🔢 Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}