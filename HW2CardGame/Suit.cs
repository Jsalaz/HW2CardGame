using System;
using System.Collections.Generic;

namespace HW2CardGame
{
	public class Suit
	{
		internal static List<Suit> VALUES = new List<Suit>();
		public enum SuitType
		{ CLUBS, DIAMONDS, HEARTS, SPADES }

		public SuitType mySuit;

		public string sName;
		public string sSymbol;
		public int sValue;
		public Suit(int suitIndex, int suitVal)
		{
			mySuit = ((SuitType)suitIndex);
			sName = mySuit.ToString();
			sValue = suitVal;
			sSymbol = InitSymbol();
		}
		public string GetName()
		{
			return sName;
		}

		public int GetValue()
		{
			return sValue;
		}
		/*symbol unicodes
		* Heart = '\u2661'
		* Spade = '\u2664'
		* Club = '\u2667'
		* Diamond = '\u2662'
		* */
		public string InitSymbol()
		{
			char ch;
			switch ((int)mySuit)
			{
				case 0:
					ch = ('\u2667');
					return ch + "C";
				case 1:
					ch = ('\u2662');
					return ch + "D";
				case 2:
					ch = ('\u2661');
					return ch + "H";
				case 3:
					ch = ('\u2664');
					return ch + "S";
				default:
					return "nill";
			}
		}

		public string GetSymbol()
		{
			return sSymbol;
		}

		public int CompareTo(Suit OtherSuitObject)
		{
			if (this.sValue == OtherSuitObject.sValue)
			{ return 0; }
			else if (this.sValue > OtherSuitObject.sValue)
			{ return 1; }
			else
			{ return -1; }
		}

		public override string ToString()
		{
			return "SuitName: " + GetName() + " SuitSymbol: " + GetSymbol() + " SuitRank: " + GetValue();
		}
	}
}
