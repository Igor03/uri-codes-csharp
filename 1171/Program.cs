using System;
using System.Collections.Generic;
using System.Linq;

namespace _1171
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;            
            int[]_numbers = new int[int.Parse(Console.ReadLine())];
            Dictionary<int, int> Numbers = new Dictionary<int, int>();

            for (int i = 0; i < _numbers.Length; i++)
            { 
                input = int.Parse(Console.ReadLine());
                _numbers[i] = input;
                if (!Numbers.ContainsKey(input))
                    Numbers.Add(input, 1);
                else
                    Numbers[input]++;
            }
            _numbers = _numbers.Distinct().ToArray();
            Array.Sort(_numbers);

            foreach (int key in _numbers)
                Console.WriteLine($"{key} aparece {Numbers[key]} vez(es)");
           
            //Console.ReadLine();
        }
    }
}
