using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma senha:");
        string senha = Console.ReadLine();

        if (ValidarSenha(senha))
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha fraca! Certifique-se de que ela tenha:");
            Console.WriteLine("-> Mínimo de 8 caracteres");
            Console.WriteLine("-> Pelo menos uma letra maiúscula");
            Console.WriteLine("-> Pelo menos um número");
            Console.WriteLine("-> Pelo menos um caractere especial (!, @, #, etc.)");
        }
    }
    static bool ValidarSenha(string senha)
    {
        if (senha.Length < 8) return false;

        bool temMaiuscula = false, temNumero = false, temEspecial = false;
        foreach (char c in senha)
        {
            if (char.IsUpper(c)) temMaiuscula = true;
            if (char.IsDigit(c)) temNumero = true;
            if (!char.IsLetterOrDigit(c)) temEspecial = true;
        }
        return temMaiuscula && temNumero && temEspecial;
    }
}