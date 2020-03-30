using System;
// 
// Problem description: https://www.urionlinejudge.com.br/judge/en/problems/view/1306

namespace NumberingRoads_1306 {

    class Program {

        public static int MinimumSuffixes(int roads, int integers) {
            int MinimumSuffixes = 0;

            if (roads <= (integers * (1 + 26))) {
                while (MinimumSuffixes <= 26 && (integers * (1 + MinimumSuffixes)) < roads)
                    MinimumSuffixes++;
                return MinimumSuffixes;
            }
            return -1;
        }

        static void Main(string[] args) {

            int cases = 0;
            int roads; // R 
            int integers; // N
            string line;

            while (true) {
                line = Console.ReadLine();
                roads = Int32.Parse(line.Split(' ')[0]);
                integers = Int32.Parse(line.Split(' ')[1]);
                if (roads + integers == 0)
                    break;
                if (MinimumSuffixes(roads, integers) == -1) {
                    Console.WriteLine("Case " + (++cases) + ": impossible");
                    continue;
                }
                Console.WriteLine("Case " + (++cases) + ": " + MinimumSuffixes(roads, integers));
            }
        }
    }
}
