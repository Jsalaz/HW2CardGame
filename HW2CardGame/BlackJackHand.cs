using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public class BlackJackHand : Hand
	{
		public BlackJackHand()
		{
			myHand = new List<Card>();
		}

		//2 
		override public int CompareTo(Hand OtherHandObject)
		{
			int currentPlayer = EvaluateHand();
			int otherPlayer = OtherHandObject.EvaluateHand();
			//if (currentPlayer > 21){
			if (currentPlayer > otherPlayer && !(currentPlayer > 21))
			{ return 1; }
			else if (currentPlayer < otherPlayer && !(otherPlayer >21))
			{ return -1; }
			else
			{ return 0; }
		}

		//11
		override public int EvaluateHand()
		{
			int sum = 0;
			int curr;
			foreach (Card c in myHand)
			{
				curr = Rank.VALUES.IndexOf(c.GetRank());
				if (curr < 9) //for 2-10 cards
				{
					sum = sum + curr + 2;
				}
				else if (curr > 8 && curr < 12) //for face cards
				{
					sum = sum + 10;
				}
				else if (curr == 12) //for aces
				{
					if (sum + 11 > 21)
					{ sum = sum + 1; }
					else
					{ sum = sum + 11; }
				}
			}
			return sum;
		}
	}
}
