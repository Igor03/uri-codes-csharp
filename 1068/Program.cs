using System;
using System.IO;


namespace _1068
{
    class Program
    {

        static string GetParenthesis(string expression)
        {
            string _expression = "";
            foreach (char chr in expression)
                if (chr == '(' || chr == ')')
                    _expression += char.ToString(chr);                                    
            return _expression;            
        }

        static bool VerifyExpression(string parenthesis)
        {
            int countP1 = 0, countP2 = 0;
            if (parenthesis.StartsWith(')') || parenthesis.EndsWith('('))
                return false;
            foreach (char chr in parenthesis)
            {
                if (chr == '(')
                    countP1++;
                else
                    countP2++;
            }            
            return countP2 == countP1 ? true: false;
        }
        static void Main(string[] args)
        {
            string expression;
            while (true)
            {
                try
                {
                    expression = Console.ReadLine();
                    if (string.IsNullOrEmpty(expression))
                        break;
                    if (VerifyExpression(GetParenthesis(expression)))
                        Console.WriteLine("correct");
                    else
                        Console.WriteLine("incorrect");
                }
                catch (EndOfStreamException) { break; }                
            }
        }
    }
}
