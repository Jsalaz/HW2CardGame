using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public class CardCountHand : Hand
	{

		public CardCountHand()
		{
			myHand = new List<Card>();
		}

		//2 
		override public int CompareTo(Hand OtherHandObject)
		{
			int currentPlayer = EvaluateHand();
			int otherPlayer = OtherHandObject.EvaluateHand();
			if (currentPlayer > otherPlayer)
			{ return 1; }
			else if (currentPlayer < otherPlayer)
			{ return -1; }
			else
			{ return 0; }
		}



		//11	2-0 3-1 4-2 5-3 6-4 7-5 8-6 9-7 10-8 j-9 q-10 k-11 a-12
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
					sum++;
				}
			}
			return sum;
		}
	}
}
