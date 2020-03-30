using System;

namespace FlowersFlourishFromFrance_1140
{
    class Program
    {

        static char verificaTautograma(string Frase)
        {
            char referencia = char.ToUpper(Frase[0]);
            for (int i = 0; i < Frase.Length - 1; i++)
            {
                if (Frase[i] == ' ' && char.ToUpper(Frase[i + 1]) != referencia)
                    return 'N';
            }
            return 'Y';
        }

        static void Main(string[] args)
        {
            string frase;

            while (true)
            {
                frase = Console.ReadLine();
                if (frase == "*") break;
                Console.WriteLine(verificaTautograma(frase));
            }
        }
    }
}