using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Inválida! Digite um número inteiro.");
            Console.Write("Digite um número inteiro para calcular o fatorial: ");
        }
        long fatorial = 1;
        int contador = numero;

        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }
        Console.WriteLine($"🔢 O fatorial de {numero} é {fatorial}.");
    }
}