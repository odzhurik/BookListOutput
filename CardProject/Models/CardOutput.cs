using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProject.Models
{
   internal static class CardOutput
    {
        public static void ConsoleOutput(List<Card>cards)
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach(Card card in cards)
            {
                Console.Write("\n" + card.CardName + " of ");
                if(card.Suit==Suit.Clubs)
                {
                    Console.Write('♣');
                }
                if (card.Suit == Suit.Hearts)
                {
                    Console.Write('♥');
                }
                if (card.Suit == Suit.Diamonds)
                {
                    Console.Write('♦');
                }
                if (card.Suit == Suit.Spades)
                {  Console.Write('♠');
                }
            }
            Console.ReadKey();
        }
    }
}
