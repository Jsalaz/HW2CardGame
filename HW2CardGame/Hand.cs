using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public abstract class Hand
	{
		public List<Card> myHand;

		//1
		public void AddCard(Card aCard)
		{
			myHand.Add(aCard);
			//_currentSize++;
		}

		//2
		public abstract int CompareTo(Hand OtherHandObject);

		//3 True is a card is found in hand
		public bool ContainsCard(Card trialCard)
		{
			foreach (Card handCard in myHand)
			{
				if (trialCard.CompareTo(handCard) == 0)
				{ return true; }
			}
			return false;
		}

		//4
		public void DiscardHand()
		{
			myHand.Clear(); //hand is cleared
			//_currentSize = -1;
		}

		//5 should work allongside ContainsCard... check if the card is there... then check the index of the card
		public int FindCard(Card trialCard)
		{
			return myHand.IndexOf(trialCard);
		}

		//6
		public Card GetCardAtIndex(int index)
		{
			Card aCard = myHand[index];
			return aCard;
		}

		//7
		public int GetNumberOfCards()
		{
			return myHand.Count;
		}

		//8
		public bool IsEmpty()
		{
			return myHand.Count == 0;
		}

		//9 removes specific card from hand. Should work with 3, 5 and 6. Check if card is in hand, fetch the index of the card, and the remove it
		public Card RemoveCard(Card trialCard)
		{
			int index = FindCard(trialCard);
			Card holder = GetCardAtIndex(index);
			myHand.Remove(trialCard);
			return holder;
		}

		//10 removes card at specified index
		public Card RemoveCard(int index)
		{
			Card holder = myHand[index];
			myHand.RemoveAt(index);
			return holder;
		}

		//11 evaluates hand
		public abstract int EvaluateHand();

		//12
		public override string ToString()
		{
			string tempCard = "";
			foreach (Card s in myHand)
			{
				tempCard = tempCard + s + " \n";
			}
			return tempCard;
		}
	}
}
