using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(" Cálculo do IMC");

        double peso, altura;

        Console.Write("Digite seu peso (kg): ");
        while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
        {
            Console.WriteLine("Entrada inválida! Digite um número positivo.");
            Console.Write("Digite seu peso (kg): ");
        }
        Console.Write("Digite sua altura (m): ");
        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.WriteLine("Entrada inválida! Digite um número positivo.");
            Console.Write("Digite sua altura (m): ");
        }
        double imc = peso / (altura * altura);

        string classificacao = "";
        if (imc < 18.5)
            classificacao = "Abaixo do peso";
        else if (imc < 24.9)
            classificacao = "Peso normal";
        else if (imc < 29.9)
            classificacao = "Sobrepeso";
        else
            classificacao = "Obesidade";

        Console.WriteLine($"\nSeu IMC é: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
}