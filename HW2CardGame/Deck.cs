using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public class Deck
	{
		private int _deckSize;
//		private int _cardsInPlay;

		//holds the random number that will select the card on top.
//		int top;

		List<Card> DeckCards = new List<Card>();

		public Deck()
		{
			this._deckSize = 52;
		}

		public Deck(int deckSize)
		{
			this._deckSize = deckSize;
			for (int i = 0; i < _deckSize; i++)
			{
				
			}
		}

		public void AddCar(Card aCard)
		{
			DeckCards.Add(aCard);
		}

/*		public Card DealOne()
		{
			DeckCards.RemoveAt(top);
		}

		public int GetCardsRemaining()
		{
			return _deckSize - _cardsInPlay;
		}
*/
		public int GetDeckSize()
		{
			return _deckSize;
		}

		public bool IsEmpty()
		{
			if (_deckSize == 0)
			{ return true; }
			else 
			{ return false; }
		}

		public void Shuffle()
		{
			
		}

		public void RestoreDeck()
		{
//			DeckCards.Add();
		}

	}
}
