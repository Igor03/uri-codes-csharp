using System;

namespace _1249
{
    class Program
    {

        static char[] alphabet = {'a', 'b', 'c', 'd',
                            'e', 'f', 'g', 'h', 'i',
                            'j', 'k', 'l', 'm',
                            'n', 'o', 'p', 'q',
                            'r', 's', 't', 'u',
                            'v', 'w', 'x', 'y', 'z'};

        static char Shift13(char inputChar)
        {
            int startIndex = Array.IndexOf(alphabet, char.ToLower(inputChar));
            if (char.IsLower(inputChar))
            {
                if (startIndex + 13 <= alphabet.Length-1)
                    return alphabet[startIndex + 13];
                return alphabet[(startIndex + 13) - alphabet.Length];
            }
            
            if (startIndex + 13 <= alphabet.Length-1)
                return char.ToUpper(alphabet[startIndex + 13]);
            return char.ToUpper(alphabet[(startIndex + 13) - alphabet.Length]);


        }

        static void Main(string[] args)
        {
            char[] input, output;
            int index;
            while (true)
            {
                index = 0;
                try
                {
                    input = Console.ReadLine().ToCharArray();
                    output = new char[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (char.IsLetter(input[i]))
                        {
                            output[i] = Shift13(input[i]);
                        } else
                        {
                            output[i] = input[i];
                        }
                        index = i;
                    }
                    Console.WriteLine(new string(output));
                } catch(Exception e)
                {
                    Console.WriteLine(index);
                    Console.WriteLine(alphabet.Length);
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    //break;
                }                
            }
        }
    }
}
