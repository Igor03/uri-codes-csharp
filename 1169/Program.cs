using System;

namespace GrainInAChessBoard_1169 {
    class Program {

        public static void StopAndGo() {
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        public static UInt64 GetKg (int squares) {
            UInt64 grains = 0;
            for (int i = 0; i < squares; i++)
                grains = grains +  Convert.ToUInt64(Math.Pow(2, i));
            return Convert.ToUInt64((grains/12)/1000);
        }

        static void Main(string[] args) {

            int TestCases = Int32.Parse(Console.ReadLine());
            int squares;
            for (int i = 0; i < TestCases; i++) {
                squares = Int32.Parse(Console.ReadLine());
                Console.WriteLine(GetKg(squares) + " kg");
            }
        }
    }
}
