using System;
using System.Collections.Generic;

// Problem description: https://www.urionlinejudge.com.br/judge/en/problems/view/1255

namespace LetterFrequency_1255 {

    class Program {

        public static void PressKey () {
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        public static List<Char> getDistinctChars(string str) {
            List<char> _chars = new List<char>();
            foreach (char c in str)
                if (!_chars.Contains(c) && Char.IsLetter(c))
                    _chars.Add(c);
            return _chars;
        }

        public static int[] CountOccurrences(List<char> distinctChars, string str) {
            int[] occurrences = new int[distinctChars.Count];                       
            foreach(char c in str)
                if (Char.IsLetter(c)) 
                    occurrences[distinctChars.IndexOf(c)]++;
            return occurrences;
        }

        public static int GetMostOc (int[] occurreces) {
            int greater = occurreces[0];
            foreach (int occ in occurreces)
                if (occ > greater)
                    greater = occ;
            return greater;
        }

        public static List<Char> showString (string str) {

            List<char> output = new List<char>();
            List<char> _chars = getDistinctChars(str);
            int[] ocurrences = CountOccurrences(_chars, str);
            int mostOcc = GetMostOc(ocurrences);


            for (int i = 0; i < ocurrences.Length; i++) {
                if (ocurrences[i] == mostOcc)
                    output.Add(_chars[i]);
            }
            output.Sort();
            return output;
        }
 
        static void Main(string[] args) {

            int testCases = Int32.Parse(Console.ReadLine());
            List<Char> _chars = new List<char>();
            string str;

            for (int i = 0; i < testCases; i++) {
                str = Console.ReadLine().ToLower();
                _chars = showString(str);
                foreach (char c in _chars)
                    Console.Write(c);
                Console.WriteLine();

            }
        }
    }
}
