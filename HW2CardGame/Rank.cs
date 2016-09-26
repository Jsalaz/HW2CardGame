/*********************************
 * Jorge Salazar
 * CSC 496
 * Professor R. Burns
 * HW2: CardGame
 * *****************************/

//using System;
using System.Collections.Generic;

namespace HW2CardGame
{

	public class Rank
	{
		private enum cardRank
		{ TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE };

		//static public int DOS, TRES, CUATRO, CINCO, SEIS, SIETE, OCHO, NUEVE, DIES, SOTA, REINA, REY;

		public static List<Rank> VALUES = new List<Rank>();
		private int rValue;
		private string rSymbol;
		private string rName;

		private cardRank myRank;

		/**
		 *bam!! static constructor 
		 *This constructor sets the rank of Values to a standard set.
		 *For CardCount I would have to comment the static constructor out 
		 *and use the second constructor for more control.
		 * */
		static Rank()
		{
			for (int i = 2; i < 15; i++)
			{
				VALUES.Add(new Rank(i));
			}
		}

		/**second constructor
		 * values can be derived from the enum index, but for this project 
		 * the values were defined in CardCountHand and BlackJackHand
		 * */
		public Rank(int eNumCode)
		{
			myRank = ((cardRank)eNumCode);
			rName = myRank.ToString();
			//rValue = (int)myRank;
			rSymbol = InitSymbol();
		}

		//Third constructor assigns predifined values just incase a game needs to define values.
		public Rank(int eNumCode, int rankVal)
		{
			myRank = ((cardRank)eNumCode);
			rValue = rankVal;
			rName = myRank.ToString();
			rSymbol = InitSymbol();
		}

		//3
		public string GetName()
		{
			return rName;
		}

		//2
		public string GetSymbol()
		{
			return rSymbol;
		}

		public string InitSymbol()
		{
			if ((int)myRank >= 2 && (int)myRank < 11)
			{
				return ((int)myRank).ToString();
			}

			switch ((int)myRank)
			{
				case 11:
					return "J";
				case 12:
					return "Q";
				case 13:
					return "K";
				case 14:
					return "A";
				default: //Error Checking in rank
					return "nill";
			}
		}

		//According to Specifications GetValue is not needed
		//currently serves no use.
		public int GetValue()
		{
			return rValue;
		}

		//1
		public int CompareTo(Rank OtherRankObject)
		{
			if (VALUES.IndexOf(this) == VALUES.IndexOf(OtherRankObject))
			{ return 0; }
			else if (VALUES.IndexOf(this) > VALUES.IndexOf(OtherRankObject))
			{ return 1; }
			else
			{ return -1; }
		}

		//4
		public override string ToString()
		{
			return (GetName());
			//return "RankName: " + GetName() + ", RankValue: " + GetValue() + ", RankSymbol: " + GetSymbol() ;
		}
	}
}