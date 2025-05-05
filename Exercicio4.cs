using System;
class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n Conversor de Temperaturas");
            Console.WriteLine("1 | Celsius -> Fahrenheit");
            Console.WriteLine("2 |Fahrenheit -> Celsius");
            Console.WriteLine("3 | Sair");
            Console.Write("Escolha uma opção: ");

            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Inválido! Digite um número de 1 a 3.");
                Console.Write("Escolha uma opção: ");
            }
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius))
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"🌡 {celsius}°C = {fahrenheit:F2}°F");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! Digite um valor numérico.");
                    }
                    break;

                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out double fahrenheitInput))
                    {
                        double celsiusConvertido = (fahrenheitInput - 32) * 5 / 9;
                        Console.WriteLine($"🌡 {fahrenheitInput}°F = {celsiusConvertido:F2}°C");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! Digite um valor numérico.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Saindo do programa.");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Escolha um número entre 1 e 3.");
                    break;
            }
        } while (opcao != 3);
    }
}