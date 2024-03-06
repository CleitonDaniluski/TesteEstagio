using System;

class Program
{
    static void Main(string[] args)
    {
       
        int numero = 34; // Você pode alterar este valor para testar outros números

        bool pertence = PertenceFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
      
        int a = 0;
        int b = 1;

        while (b < numero)
        {
            int proximo = a + b;

            a = b;
            b = proximo;
        }

        return b == numero;
    }
}