using System;
using System.Collections.Generic;

namespace HW2CardGame
{

	public class Rank
	{
		public enum cardRank
		{ TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE };

		//static public int DOS, TRES, CUATRO, CINCO, SEIS, SIETE, OCHO, NUEVE, DIES, SOTA, REINA, REY;

		public static List<Rank> VALUES = new List<Rank>();
		private int rValue;
		private string rSymbol;
		private string rName;

		private cardRank myRank;

		//alternative method loads values of 13 cards possible delete
		//bam!! static constructor
		static Rank()
		{
			for (int i = 2; i < 15; i++)
			{
				VALUES.Add(new Rank(i));
			}
		}

		//second working code
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

		public override string ToString()
		{
			return GetName();
			//return "RankName: " + GetName() + ", RankValue: " + GetValue() + ", RankSymbol: " + GetSymbol() ;
		}

		public string GetName()
		{
			return rName;
		}

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

		public int CompareTo(Rank OtherRankObject)
		{
			if (VALUES.IndexOf(this) == VALUES.IndexOf(OtherRankObject))
			{ return 0; }
			else if (VALUES.IndexOf(this) > VALUES.IndexOf(OtherRankObject))
			{ return 1; }
			else
			{ return -1; }
		}
	}
}
/*//first Test with Random value to delete soon
public Rank()
{
	//Creates an Enum based on a random number mod 13
	//			works
	myRank = ((cardRank)(rRandom.Next() % 13));
	//stores the name of the String Enum to rName
	//			works great
	rName = myRank.ToString();
	//stores the value of the index from the enum
	//			rValue = GetValue();
	rValue = (int)myRank	;
	rSymbol = InitSymbol();
}
*/