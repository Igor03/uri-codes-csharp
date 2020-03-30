using System;

namespace _1235_InsideOut {

    class Program {

        public  static void StopAndGo(){
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        public static String ReverseString (String str) {
           
            int ArraySize = str.Length;
            Char[] RevStr = new char[ArraySize];
            
            for (int i = ArraySize; i > 0; i--) 
                RevStr[ArraySize - i] = str[i - 1];

            return new String (RevStr);
        }

        static void Main(string[] args) {


            int UseCases = Int32.Parse(Console.ReadLine());
            string str;
            

            for (int i = 0; i < UseCases; i++) {
                str = Console.ReadLine();
                Console.WriteLine(ReverseString(str.Substring(0, str.Length / 2)) + "" + ReverseString(str.Substring(str.Length / 2)));
            }

            /*String model = "VOD OWT SNEH HCNERF EGDIRTRAP A DNA SE";
            Console.WriteLine(ReverseString(model.Substring(0, model.Length / 2))+""+ ReverseString(model.Substring(model.Length / 2 )));

            Console.WriteLine(model.Length / 2);
            Console.WriteLine(model.Substring(0, model.Length/2));
            Console.WriteLine(model.Substring(model.Length/2 + 1));

            // THIS LINE IS GIBBERISH
            //String model = "I ENIL SIHTHSIREBBIG S";

            char[] model2 = new char[model.Length];
            //String x = Console.ReadLine();
            model2 = model.ToCharArray();
            
            for (int i = model2.Length; i > 0; i--) {
                model2[model2.Length - i] = model[i - 1];
                //Console.WriteLine("Letra: "+ model[i-1]);
            }
            string xx = new string(model2);
            Console.WriteLine(xx)*/;
            StopAndGo();
        }
    }
}
