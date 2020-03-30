using System;

namespace blobs_1170 {

    class Program {

        public static void StopAndGo() {
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        public static int CalculateDays (double foodSupply) {

            int days = 0;

            while (foodSupply > 1.0) {
                foodSupply = foodSupply/2;
                days++;
            }
            return days;
        }

        static void Main(string[] args) {

            double foodSupply;
            int UseCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < UseCases; i++) {
                foodSupply = Double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateDays(foodSupply) + " dias");
            }
            StopAndGo();
        }
    }
}
