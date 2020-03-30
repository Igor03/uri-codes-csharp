using System;

namespace Banknotes_1018
{
    class Program
    {

        public static int GetNotes(ref int amount, int note)
        {
            int _notes;
            if (amount / note < 0) return 0;
            _notes = amount / note;
            amount = amount % note;
            return _notes;
        }

        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine(amount);
            Console.WriteLine(GetNotes(ref amount, 100) + " nota(s) de R$ 100,00");
            Console.WriteLine(GetNotes(ref amount, 50) + " nota(s) de R$ 50,00");
            Console.WriteLine(GetNotes(ref amount, 20) + " nota(s) de R$ 20,00");
            Console.WriteLine(GetNotes(ref amount, 10) + " nota(s) de R$ 10,00");
            Console.WriteLine(GetNotes(ref amount, 5) + " nota(s) de R$ 5,00");
            Console.WriteLine(GetNotes(ref amount, 2) + " nota(s) de R$ 2,00");
            Console.WriteLine(GetNotes(ref amount, 1) + " nota(s) de R$ 1,00");
        }
    }
}
