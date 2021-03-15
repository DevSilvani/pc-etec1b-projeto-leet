using System;

namespace pc_etec1b_projeto_leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            Console.Write("Digite uma Frase:");
            frase = Console.ReadLine();
            frase = frase.Replace("a", "4");
            frase = frase.Replace("A", "4");
            frase = frase.Replace("e", "3");
            frase = frase.Replace("E", "3");
            frase = frase.Replace("i", "1");
            frase = frase.Replace("I", "1");
            frase = frase.Replace("L", "1");
            frase = frase.Replace("l", "1");
            frase = frase.Replace("t", "7");
            frase = frase.Replace("T", "7");
            frase = frase.Replace("s", "5");
            frase = frase.Replace("S", "5");
            frase = frase.Replace("o", "0");
            frase = frase.Replace("O", "0");
            Console.Clear();
            Console.WriteLine(frase);
            Console.ReadKey();
        }
    }
}
