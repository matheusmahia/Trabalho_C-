using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSec = random.Next(1, 101);
        int tentativa = 0;
        int tentativasFeitas = 0;

        Console.WriteLine("Jogo da Adivinhação");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("\nDigite seu palpite: ");
            while (!int.TryParse(Console.ReadLine(), out tentativa) || tentativa < 1 || tentativa > 100)
            {
                Console.WriteLine("Entrada inválida! Digite um número entre 1 e 100.");
                Console.Write("Digite seu palpite: ");
            }
            tentativasFeitas++;

            if (tentativa < numeroSec)
                Console.WriteLine("O número secreto é maior!");
            else if (tentativa > numeroSec)
                Console.WriteLine(" O número secreto é menor!");
            else
                Console.WriteLine($"Você acertou em {tentativasFeitas} tentativas.");

        } while (tentativa != numeroSec);
    }
}