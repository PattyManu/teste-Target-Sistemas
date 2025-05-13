//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

using System;

class Program
{
    static void Main()
    {
        string original = "exemplo de string";
        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }

        Console.WriteLine("String original: " + original);
        Console.WriteLine("String invertida: " + invertida);
    }
}

