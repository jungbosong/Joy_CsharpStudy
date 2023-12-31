﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    // 패를 표현하는 클래스
    public class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int GetTotalValue()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                if (card.Rank == Rank.Ace)
                {
                    aceCount++;
                }
                total += card.GetValue();
            }

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public Rank GetRank(int idx)
        {
            return cards[idx].Rank;
        }

        public string GetFirstCard()
        {
            return cards[0].ToString();
        }
        
        public string GetAllCard()
        {
            string result = "";
            foreach(Card card in cards) 
            {
                result += card.ToString() + "\n";
            }
            return result;
        }
    }
}
