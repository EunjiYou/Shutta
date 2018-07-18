using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Player
    {
        public Player(int no)
        {
            No = no;
        }

        public int No;

        public int Money;

        public List<Card> Cards;

        public void TakeCard(Card card)
        {
            Cards.Add(card);
        }
    }
}