using System;

namespace _1728
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression, auxExpression;
            int n1, n2, result;
            char[] _expressionToArray;

            while (true)
            {
                expression = Console.ReadLine();
                auxExpression = expression;
                
                _expressionToArray = expression.ToCharArray();
                Array.Reverse(_expressionToArray);
                
                expression = new string(_expressionToArray);
                // A little messy but... :)
                result = int.Parse(expression.Split('=')[0]);
                n1 = int.Parse(expression.Split('=')[1].Split('+')[0]);
                n2 = int.Parse(expression.Split('=')[1].Split('+')[1]);

                if (n1 + n2 == result)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                if (auxExpression == "0+0=0")
                    break;
            }            
        }
    }
}
