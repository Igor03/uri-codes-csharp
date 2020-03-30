using System;
using System.Collections.Generic;


namespace CompleteSentence_1551
{
    class Program
    {
        static int verificaOcorrencias(string Frase)
        {

            List<char> Encontrados = new List<char>();
            List<char> alfabeto = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char l in Frase)
                if (!Encontrados.Contains(char.ToLower(l)) && char.IsLetter(l)) Encontrados.Add(char.ToLower(l));
            return Encontrados.Count;
        }

        static void Main(string[] args)
        {
            int casos = int.Parse(Console.ReadLine());
            int matches = 0;

            for (int i = 0; i < casos; i++)
            {
                matches = verificaOcorrencias(Console.ReadLine());
                if (matches == 26) Console.WriteLine("frase completa");
                else if (matches >= 13) Console.WriteLine("frase quase completa");
                else Console.WriteLine("frase mal elaborada");
            }
    }
}
