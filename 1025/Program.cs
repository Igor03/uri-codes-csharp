using System;
using System.Linq;

namespace _1025.py
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int tent, _case = 0;
                string results = "", line = Console.ReadLine();
                int[] marbles = new int[int.Parse(line.Split(' ')[0])];

                if (line == "0 0")
                    break;

                for (int i = 0; i < marbles.Length; i++)
                    marbles[i] = int.Parse(Console.ReadLine());
                Array.Sort(marbles);

                for (int i = 0; i < int.Parse(line.Split(' ')[1]); i++)
                {
                    tent = int.Parse(Console.ReadLine());
                    if (marbles.Contains(tent))
                        results += $"#{tent} found at {Array.IndexOf(marbles, tent)+1}";
                    else
                        results += $"{tent} not found";
                }
                results = results[0] == '#' ? results.Substring(1, results.Length - 1) : results;

                Console.WriteLine($"CASE# {++_case}");
                foreach (string result in results.Split("#"))                      
                    Console.WriteLine(result);
            }
        }
    }
}


//case = 1
//while True:
//    marbles = []
//results = ''
//    line = input()
//    N = int (line.split()[0])
//    Q = int (line.split()[1])    
//    if Q == N == 0:
//        break
//    for i in range(N) :
//        marbles.append(int(input()))
//    marbles.sort(reverse = False)
//    for i in range(Q) :
//        tent = int (input())
//        if tent in marbles:
//            results += '#{} found at {}'.format(tent, marbles.index(tent)+1)
//            continue
//        results += '{} not found'.format(tent)
//    results = results[1:] if results[0]=='#' else results
//    print('CASE#: {}'.format(case))
//    [print(result) for result in results.split('#')]
//    case += 1
