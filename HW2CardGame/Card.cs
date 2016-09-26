/*********************************
 * Jorge Salazar
 * CSC 496
 * Professor R. Burns
 * HW2: CardGame
 * *****************************/

//using System;

namespace HW2CardGame
{
	public class Card
	{
		private readonly Rank CardRank;
		private readonly Suit CardSuit;

		//Creates a Card with given Rank and Suit Attributes
		public Card(Suit aSuit, Rank aRank)
		{
			CardRank = aRank;
			CardSuit = aSuit;
		}

		//2
		public Rank GetRank()
		{
			return CardRank;
		}

		//3
		public Suit GetSuit()
		{
			return CardSuit;
		}

		//4
		public override string ToString()
		{
			return GetRank() + " of " + GetSuit();
			//return GetRank().ToString() + ", " + GetSuit().ToString();
		}

		//1
		public int CompareTo(Card OtherCardObject)
		{
			int rankComp = CardRank.CompareTo(OtherCardObject.CardRank);//gets 0 if cards have the same rank
			int suitComp;

			if (rankComp == 0)
			{
				suitComp = CardSuit.CompareTo(OtherCardObject.CardSuit);
				if (rankComp == suitComp)
				{ return 0; }
				else
				{ return suitComp; }
			}
			else 
			{ return rankComp; }
		}
	}
}