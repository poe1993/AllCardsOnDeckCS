﻿using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<string>()
        {
        "Ace of Spades","Ace of Hearts","Ace of Clubs","Ace of Diamonds",
        "Two of Spades","Two of Hearts","Two of Clubs","Two of Diamonds",
        "Three of Spades","Three of Hearts","Three of clubs","Three of Diamonds",
        "Four of Spades","Four of Hearts","Four of Clubs","Four of Diamonds",
        "Five of Spades","Five of Hearts","Five of Clubs","Five of Diamonds",
        "Six of Spades","Six of Hearts","Six of Clubs","Six of Diamonds",
        "Seven of Spades", "Seven of Hearts", "Seven of Clubs", "Seven of Diamonds",
        "Eight of Spades", "Eight of Hearts", "Eight of Clubs", "Eight of Diamonds",
        "Nine of Spades", "Nine of Hearts", "Nine of Clubs", "Nine of Diamonds",
        "Ten of Spades", "Ten of Hearts","Ten of Clubs","Ten of Diamonds",
        "Jack of Spades", "Jack of Hearts", "Jack of Clubs", "Jack of Diamonds",
        "Queen of Spades", "Queen of Hearts", "Queen of Clubs", "Queen of Diamonds",
        "King of Spades","King of Hearts","King of Clubs","King of Diamonds"
      };
            var n = deck.Count;
            var random = new Random();

            for (int rightIndex = n - 1; rightIndex > 1; rightIndex--)
            {
                int leftIndex = random.Next(rightIndex - 1);
                var leftCard = deck[rightIndex];
                var rightCard = deck[leftIndex];
                deck[rightIndex] = rightCard;
                deck[leftIndex] = leftCard;
                var topCard = rightCard;
                var nextCard = leftCard;
                if (rightIndex == 50)
                {
                    break;
                }


                Console.WriteLine("Topcard:{0}", topCard);
                Console.WriteLine("Nextcard:{0}", nextCard);

                var playerHand = new List<string>();
                playerHand.Add(topCard);
                playerHand.Add(nextCard);
                Console.WriteLine("player dealt:{0},{1}", topCard, nextCard);
            }

        }
    }
}
