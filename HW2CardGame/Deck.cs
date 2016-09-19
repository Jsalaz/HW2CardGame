using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public class Deck
	{
		private int _topOfDeck;
		private int _deckSize;
		static Random shuffler = new Random();

		public List<Card> DeckOfCards = new List<Card>();
		public List<Card> NotInDeck = new List<Card>();

		public Deck()
		{
			DeckOfCards = new List<Card>();
			_topOfDeck = -1;
			_deckSize = 0;
		}

		public void AddCard(Card aCard)
		{
			DeckOfCards.Add(aCard);
			_topOfDeck++;	
			_deckSize++;
		}

		public Card DealOne()
		{
			Card topCard = DeckOfCards[_topOfDeck];
			NotInDeck.Add(topCard);
			DeckOfCards.RemoveAt(_topOfDeck--);
			return topCard;
		}

		public int GetCardsRemaining()
		{
			return _topOfDeck+1;
		}

		public int GetDeckSize()
		{
			return _deckSize;
		}

		public bool IsEmpty()
		{
			if (_topOfDeck == -1)
			{ return true; }
			return false;
		}

		public void Shuffle()
		{
			//Fisher-Yates Shuffle Algorithm
			for (int i = 0; i < _topOfDeck; i++)
			{
				int randCardIndex = (int)(shuffler.Next(i, _topOfDeck));// % (_topOfDeck - i));
				Card cardHolder = DeckOfCards[randCardIndex];
				DeckOfCards[randCardIndex] = DeckOfCards[i];
				DeckOfCards[i] = cardHolder;
			}
		}

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

		public override string ToString()
		{
			foreach (Card s in DeckOfCards)
			{
				Console.WriteLine(s);
			}
			return "";
		}
	}
}