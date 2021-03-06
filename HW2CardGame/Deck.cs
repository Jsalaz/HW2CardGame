﻿/*********************************
 * Jorge Salazar
 * CSC 496
 * Professor R. Burns
 * HW2: CardGame
 * *****************************/

using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public class Deck
	{
		private int _topOfDeck;
		private int _deckSize;
		private static Random shuffler = new Random();

		public List<Card> DeckOfCards;
		public List<Card> NotInDeck = new List<Card>();

		public Deck()
		{
			DeckOfCards = new List<Card>();
			_topOfDeck = -1;
			_deckSize = 0;
		}

		//1
		public void AddCard(Card aCard)
		{
			DeckOfCards.Add(aCard);
			_topOfDeck++;	
			_deckSize++;
		}

		//2
		public Card DealOne()
		{
			Card topCard = DeckOfCards[_topOfDeck];
			NotInDeck.Add(topCard);
			DeckOfCards.RemoveAt(_topOfDeck--);
			return topCard;
		}

		//3
		public int GetCardsRemaining()
		{
			return _topOfDeck+1;
		}

		//4
		public int GetDeckSize()
		{
			return _deckSize;
		}

		//5
		public bool IsEmpty()
		{
			if (DeckOfCards.Count == 0)
			{ return true; }
			return false;
		}

		//6
		public void Shuffle()
		{
			//Fisher-Yates Shuffle Algorithm
			for (int i = 0; i < _topOfDeck+1; i++)
			{
				int randCardIndex = (int)(shuffler.Next(i, _topOfDeck+1));// % (_topOfDeck - i));
				Card cardHolder = DeckOfCards[randCardIndex];
				DeckOfCards[randCardIndex] = DeckOfCards[i];
				DeckOfCards[i] = cardHolder;
			}
		}

		//7
		public void RestoreDeck()
		{
			foreach (Card s in NotInDeck)
			{
				//adds cards from NotInDeck back to Deck
				DeckOfCards.Add(s);
				_topOfDeck++;
			}
			NotInDeck.Clear();
		}
	}
}