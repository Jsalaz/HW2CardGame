using System;


namespace HW2CardGame
{
	public class Card
	{
		private Rank CardRank;
		private Suit CardSuit;


		public Card(Suit aSuit, Rank aRank)
		{
			this.CardRank = aRank;
			this.CardSuit = aSuit;
		}


	}
}
