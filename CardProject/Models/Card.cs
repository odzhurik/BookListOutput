using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProject.Models
{
   internal class Card
    {
        public CardName CardName { get; set; }
        public int CardValue { get; set; }
        public Suit Suit { get; set; }
    }
}
