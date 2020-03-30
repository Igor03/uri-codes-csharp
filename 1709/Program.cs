using System;
using System.Collections.Generic;

namespace _1709
{
    class Program
    {
        //static string ExecuteSwap(string cards, int numberOfCards)
        //{
        //    string[] _cards = cards.Split(',');
        //    numberOfCards = numberOfCards / 2;
        //    string cardsAux = "";
        //    for (int i = 0; i < numberOfCards; i++)            
        //        cardsAux += _cards[i + numberOfCards] + "," + _cards[i] + ",";            
        //    return cardsAux.Substring(0, cardsAux.Length - 1);
        //}
     
        static int[] ExecuteSwap(int[] cards)
        {            
            int numberOfCards = cards.Length;
            List<int> _cards = new List<int>();

            for (int i = 0; i < numberOfCards/2; i++)
            {
                _cards.Add(cards[i + numberOfCards/2]);
                _cards.Add(cards[i]);                               
            }
            return _cards.ToArray();            
        }

        static void Main(string[] args)
        {

            int[] cards = new int[int.Parse(Console.ReadLine())];
            int count = 0;
            
            for (int i = 0; i < cards.Length; i++)            
                cards[i] = i + 1;

            while (true)
            {
                count++;
                cards = ExecuteSwap(cards);
                if (cards[0] == 1) break;                
            }

            Console.WriteLine(count);
          

            //string cards = "", cardsAux;
            //int numberOfCards = int.Parse(Console.ReadLine()), count = 0;
            //for (int i = 0; i < numberOfCards; i++)         
            //    cards += (i+1).ToString() + ",";
            //cards = cards.Substring(0, cards.Length - 1);
            //cardsAux = cards;

            //while (true)
            //{
            //    count += 1;
            //    cardsAux = ExecuteSwap(cardsAux, numberOfCards);
            //    if (cardsAux.Equals(cards))
            //        break;
            //}
            //Console.WriteLine(count);            
            Console.ReadLine();
        }
    }
}
