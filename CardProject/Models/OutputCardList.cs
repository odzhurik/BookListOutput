using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProject.Models
{
    internal class OutputCardList
    {
        private List<Card> cards;
        public void CardListInit()
        {
            cards = new List<Card>();
            int minValueCard = 2;
            int minValueHigherCard = 10;
            int maxValueCard = 11;
            for (int i = 0; i < Enum.GetNames(typeof(Suit)).Length; i++)
            {
                for (int cardName = 0, cardValue = minValueCard; cardName < Enum.GetNames(typeof(CardName)).Length; cardName++, cardValue++)
                {
                    if ((CardName)cardName == CardName.Jack || (CardName)cardName == CardName.King || (CardName)cardName == CardName.Queen)
                    {
                        Card card = new Card();
                        card.Suit = (Suit)i;
                        card.CardName = (CardName)cardName;
                        card.CardValue = minValueHigherCard;
                        cards.Add(card);
                    }
                    if ((CardName)cardName == CardName.Ace)
                    {
                        Card card = new Card();
                        card.Suit = (Suit)i;
                        card.CardName = (CardName)cardName;
                        card.CardValue = maxValueCard;
                        cards.Add(card);
                        break;
                    }
                    if ((CardName)cardName <= CardName.Ten)
                    {
                        Card card = new Card();
                        card.Suit = (Suit)i;
                        card.CardName = (CardName)cardName;
                        card.CardValue = cardValue;
                        cards.Add(card);
                    }

                }
            }
        }
        public void Output()
        {
            CardListInit();
            CardOutput.ConsoleOutput(cards);
        }
    }
}
