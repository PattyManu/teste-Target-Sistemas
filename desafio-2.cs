//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
// escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e 
// retorne uma mensagem avisando se o número informado pertence ou não a sequência.

using System;

class Program
{
    static void Main()
    {
        int numero = 62;
        int a = 0;
        int b = 1;
        bool pertence = false;

        while (a <= numero)
        {
            if (a == numero)
            {
                pertence = true;
                break;
            }

            int proximo = a + b;
            a = b;
            b = proximo;
        }

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }
}

