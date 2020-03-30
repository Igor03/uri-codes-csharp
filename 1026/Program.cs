using System;

namespace CarregaOuNaoCarrega_1026 {
    class Program {

        public static UInt32[] IntToBinary(UInt32 number) {
            UInt32[] BinaryNumber = new UInt32[32];
            string StrNumber = Convert.ToString(number, 2);
            int index = StrNumber.Length - 1;
            for (int i = 0; i < StrNumber.Length; i++)
                BinaryNumber[31-index--] = Convert.ToUInt32(Char.GetNumericValue(StrNumber[i]));            
            return BinaryNumber;
        }

        public static UInt32 BinaryToInt(UInt32[] binary) {
            UInt32 number = 0;
            int index = 0;
            for (int i = binary.Length - 1; i > -1; i--) {
                number = number + binary[i] * (UInt32)Math.Pow(2, index);
                index++;
            }
            return number;
        }

        public static UInt32 SumBinary(UInt32 n1, UInt32 n2) {
            UInt32[] number1 = IntToBinary(n1);
            UInt32[] number2 = IntToBinary(n2);
            UInt32[] result = new UInt32[32];
            for (int i = number1.Length - 1; i > -1; i--)
                result[i] = number1[i] + number2[i] == 2 ? 0 : number1[i] + number2[i];                    
            return BinaryToInt(result);
        }

        static void Main(string[] args) {

            while (true) {
                string s__input = Console.ReadLine();
                if (string.IsNullOrEmpty(s__input))
                    break;
                try { 
                    Console.WriteLine(SumBinary(UInt32.Parse(s__input.Split(' ')[0]), UInt32.Parse(s__input.Split(' ')[1])));
                } catch(Exception e) { break; }

            }
        }
    }
}