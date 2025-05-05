using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase para verificar: ");
        string entrada = Console.ReadLine();

        string entradaLimpa = RemoverCaracteresEspeciais(entrada);

        if (Palindromo(entradaLimpa))
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine(" Não é um palíndromo.");
        }
    }
    static string RemoverCaracteresEspeciais(string texto)
    {
        texto = Regex.Replace(texto, @"\s+", "");
        texto = Regex.Replace(texto, @"[^a-zA-Z0-9]", "");
        return texto.ToLower();
    }
    static bool Palindromo(string texto)
    {
        char[] arr = texto.ToCharArray();
        Array.Reverse(arr);
        return texto == new string(arr);
    }
}