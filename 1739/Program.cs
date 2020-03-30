using System;

namespace _1739
{
  
    class Program
    {

        static UInt32 Fibb(int n)
        {
            UInt32 number1 = 0, number2 = 1, counter = 0, sumPrev;
            while (true)
            {
                sumPrev = number1 + number2;
                number1 = number2;
                number2 = sumPrev;
                //index++;
                if (number1 % 3 == 0 || number1.ToString().Contains("3")) { 
                    counter++;
                    if (counter == n)
                        return number1;
                }
            }
        }

        //static int fib3 = 0;
        //static int Fibb(int n)
        //{

        //    if (n <= 2) return n;
        //    if (n % 3 == 0 || n.ToString().Contains("3"))
        //    {
        //        fib3++;
        //        if (fib3 == n)
        //            return 0;
        //    } 
        //    if (fib3 == n) return 0;
        //    return Fibb(n - 1) + Fibb(n - 2);
        //}

        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {                    
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(Fibb(n));                    
                }
                catch (Exception e)
                {
                    break;
                }
            }
        }
    }
}
