using System;
using System.Collections.Generic;

namespace HW2CardGame
{

	public class Rank
	{
		int rankValue;
		string symbol;
		string name;
		static List<Rank> VALUES = new List<Rank>();

		/*public enum cardRack : short
		{
			TWO,
			THREE,
			FOUR,
			FIVE,
			SIX,
			SEVEN,
			EIGHT,
			NINE,
			TEN,
			JACK,
			QUEEN,
			KING,
			ACE
		}*/

		public Rank(string aSymbol, string aName, int rankVal)
		{
			this.symbol = aSymbol;
			this.name = aName;
			this.rankValue = rankVal;
			VALUES.Add(this);
		}

		public int CompareTo(Rank OtherRankObject)
		{
			if (this.rankValue == OtherRankObject.rankValue)
			{ return 0; }
			else if (this.rankValue < OtherRankObject.rankValue)
			{ return -1; }
			else { return 1; }
		}

		public string GetSymbol()
		{
			return this.symbol;
		}

		public string GetName()
		{
			return this.name;
		}

		public override string toString()
		{
			
		}

	}
}
