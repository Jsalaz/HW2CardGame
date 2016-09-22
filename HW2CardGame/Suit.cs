﻿using System;
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

		static Suit()
		{
			for (int i = 0; i < 4; i++)
			{
				VALUES.Add(new Suit(i));
			}
		}

		public Suit(int suitIndex)//specific suit with default suit rank C>D>H>S
		{
			mySuit = ((SuitType)suitIndex);
			sName = mySuit.ToString();
		//	sValue = (int)mySuit;
			sSymbol = InitSymbol();
		}

		public Suit(int suitIndex, int suitVal)//specific Suit and Rank Value
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

		/*symbol unicodes
		 * Club = '\u2667'
		 * Diamond = '\u2662'
		 * Heart = '\u2661'
		 * Spade = '\u2664'
		 * */
		public string InitSymbol()
		{
			string ch;
			switch ((int)mySuit)
			{
				case 0:
					ch = ("\u2667");
					return ch + "C";
				case 1:
					ch = ("\u2662");
					return ch + "D";
				case 2:
					ch = ("\u2661");
					return ch + "H";
				case 3:
					ch = ("\u2664");
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
			if (VALUES.IndexOf(this) == VALUES.IndexOf(OtherSuitObject))
			{ return 0; }
			else if (VALUES.IndexOf(this) > VALUES.IndexOf(OtherSuitObject))
			{ return 1; }
			else
			{ return -1; }
		}

		public int GetValue()
		{
			return sValue;
		}

		public override string ToString()
		{
			return GetName();
			//return "SuitName: " + GetName() + ", SuitSymbol: " + GetSymbol() + ", SuitRank: " + GetValue();
		}
	}
}

		/*
		public Suit()//random suit for a card with default suit rank C>D>H>S
		{
			mySuit = ((SuitType)(sRandom.Next() % 4));
			sName = mySuit.ToString();
			sValue = (int)mySuit;
			sSymbol = InitSymbol();
		}*/
