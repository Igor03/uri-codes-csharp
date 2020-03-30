using System;

namespace SortByLength_1244 {
    class Program {

        public static int[] GetWordsSizes(String[] words) {
            int[] WordSizes = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
                WordSizes[i] = words[i].Length;
            return WordSizes;
        }

        public static void SwapString (int pw1, int pw2, String[] words, int[] WordsSizes) {
            string strAux = words[pw1];
            int intAux = WordsSizes[pw1];
            words[pw1] = words[pw2];
            WordsSizes[pw1] = WordsSizes[pw2];
            words[pw2] = strAux;
            WordsSizes[pw2] = intAux;
        } 
        
        // Baseado no Bubble Sort
        public static void SortByLength(String[] words) {
            int[] WordsSizes = GetWordsSizes(words);
            for (int i = 0; i < WordsSizes.Length - 1; i++) {
                for (int j = 0; j < WordsSizes.Length-i-1; j++) {
                    if (WordsSizes[j] < WordsSizes[j + 1]) SwapString(j, j + 1, words, WordsSizes);                                          
                }
            }
        }

        static void Main(string[] args) {

            int TestCases = Int32.Parse(Console.ReadLine());
            string[] words;

            for (int j = 0; j < TestCases; j++) {
                words = Console.ReadLine().Split(' ');
                SortByLength(words);
                for (int i = 0; i < words.Length; i++) {
                    Console.Write(words[i]);
                    if (i == words.Length - 1)
                        continue;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }    
        }
    }
}
