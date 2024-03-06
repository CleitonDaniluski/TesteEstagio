using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada = "Teste para Estágio Ribeirão Preto!";

        string invertida = InverterString(entrada);

        Console.WriteLine("String original: " + entrada);
        Console.WriteLine("String invertida: " + invertida);
    }

    static string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray();

        string invertida = "";

        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            invertida += caracteres[i];
        }

        return invertida;
    }
}