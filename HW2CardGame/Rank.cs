using System;
using System.Collections.Generic;

namespace HW2CardGame
{

	public class Rank
	{
		public enum cardRank
		{ TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE }	

		public static List<Rank> VALUES = new List<Rank>();
		static Random rRandom = new Random();

		private int rValue;
		private string rSymbol;
		private string rName;

		private cardRank myRank;

		//first Test with Random value to delete soon
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
			rValue = (int)myRank;
			rSymbol = InitSymbol();
		}

		//second test to delete soon
		public Rank(int eNumCode)
		{
			myRank = ((cardRank)eNumCode);
			rName = myRank.ToString();
			rValue = (int)myRank;
			rSymbol = InitSymbol();
		}

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

		//According to Specifications GetValue is not needed
		public int GetValue()
		{
			return rValue;
		}

		public string GetSymbol()
		{
			//Console.WriteLine(GetValue());
			//Console.WriteLine(rValue);
			return rSymbol;
		}

		public string InitSymbol()
		{
			if ((int)myRank >= 0 && (int)myRank < 9)
			{
				return ((int)myRank + 2).ToString();
			}

			switch ((int)myRank)
			{
				case 9:
					return "J";
				case 10:
					return "Q";
				case 11:
					return "K";
				case 12:
					return "A";
				default: //Error Checking in rank
					return "nill";
			}
		}

		public int CompareTo(Rank OtherRankObject)
		{
			if (this.GetValue() == OtherRankObject.GetValue())
			{ return 0; }
			    else if (this.GetValue() > OtherRankObject.GetValue())
			{ return 1; }
			else
			{ return -1;}
		}

	}
}
