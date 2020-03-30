using System;

namespace _1332
{
    class Program
    {

        public static int CorrectNumber(string number)
        {
            char[] auxNumber;
            
            if (number.Length==3)
            {
                for (int i = 0; i < 3; i++)
                {
                    auxNumber = number.ToCharArray();                    
                    if (i == 0) auxNumber[i] = 'o';
                    else if (i == 1) auxNumber[i] = 'n';
                    else auxNumber[i] = 'e';
                    if (new string(auxNumber).Equals("one"))
                        return 1; 
                }
                for (int i = 0; i < 3; i++)
                {
                    auxNumber = number.ToCharArray();
                    if (i == 0) auxNumber[i] = 't';
                    else if (i == 1) auxNumber[i] = 'w';
                    else auxNumber[i] = 'o';
                    if (new string(auxNumber).Equals("two"))
                        return 2;
                }
            }
            return 3;
        }

        static void Main(string[] args)
        {
            string inputNumber;
            int cases = int.Parse(Console.ReadLine());


            for (int i = 0; i < cases; i++)
            {
                inputNumber = Console.ReadLine();
                Console.WriteLine(CorrectNumber(inputNumber));
            }
            Console.ReadLine();
        }
    }
}
