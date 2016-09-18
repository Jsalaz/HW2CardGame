using System;

namespace HW2CardGame
{
	public class Card
	{
		private Rank CardRank;
		private Suit CardSuit;

		//string tString;

		//Creates Random Cards used for my testing
		public Card()
		{
			CardRank = new Rank();
			CardSuit = new Suit();
		}

		//Creates a Card with given Rank and Suit Attributes
		public Card(Suit aSuit, Rank aRank)
		{
			CardRank = aRank;
			CardSuit = aSuit;
		}

		public Rank GetRank()
		{
			return this.CardRank;
		}

		public Suit GetSuit()
		{
			return this.CardSuit;
		}

		public override string ToString()
		{
			return GetRank() + " of " + GetSuit();
			//return GetRank().ToString() + ", " + GetSuit().ToString();
		}

		public int CompareTo(Card OtherCardObject)
		{
			int rankComp = this.CardRank.CompareTo(OtherCardObject.CardRank);
			int suitComp;

			if (rankComp == 0)
			{
				suitComp = this.CardSuit.CompareTo(OtherCardObject.CardSuit);
				if (rankComp == suitComp)
				{
					return 0;
				}
				else
				{
					return suitComp;
				}
			}
			else 
			{
				return rankComp;
			}
		}
	}
}
