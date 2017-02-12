using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProject.Models
{
    internal class OutputCardList
    {
        private List<Card> deck;
        private void DeckInit()
        {
            deck = new List<Card>();
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
                        deck.Add(card);
                    }
                    if ((CardName)cardName == CardName.Ace)
                    {
                        Card card = new Card();
                        card.Suit = (Suit)i;
                        card.CardName = (CardName)cardName;
                        card.CardValue = maxValueCard;
                        deck.Add(card);
                        break;
                    }
                    if ((CardName)cardName <= CardName.Ten)
                    {
                        Card card = new Card();
                        card.Suit = (Suit)i;
                        card.CardName = (CardName)cardName;
                        card.CardValue = cardValue;
                        deck.Add(card);
                    }

                }
            }
        }
        private List<Card> GenerateCardList()
        {
            List<Card> cardList = new List<Card>();
            DeckInit();
            Random rng = new Random();
            int listCount = rng.Next(1,deck.Count);
            foreach(Card card in deck)
            {
                if(listCount==cardList.Count)
                {
                    break;
                }
                cardList.Add(card);
            }
            return cardList;
        }
        public void Output()
        {
            CardOutput.ConsoleOutput(GenerateCardList());
        }
    }
}
