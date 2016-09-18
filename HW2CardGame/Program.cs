using System;

namespace HW2CardGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/*
			//Card TestCard = new Card();
			//Generates Random rank objects
			Rank testRank = new Rank();
			Console.WriteLine(testRank.ToString());
			Rank testRank2 = new Rank();
			Console.WriteLine(testRank2.ToString());
			Rank testRank3 = new Rank();
			Console.WriteLine(testRank3.ToString());
			*/

			//Generates specified rank
			//Creating BlackJack Rank
			/*
			Rank.VALUES.Add(new Rank(9));
			Rank.VALUES.Add(new Rank(12));
			Rank.VALUES.Add(new Rank(0));
			*/
			//SAVE THIS FOR BLACKJACK
			Console.WriteLine("Populating List<Rank> Values with Rank for BlackJack");
			for (int i = 0; i < 13; i++)
			{
				if (i < 9)
				{
					Rank.VALUES.Add(new Rank(i, i+2));
				}
				else if (i < 12)
				{
					Rank.VALUES.Add(new Rank(i, 10));
				}
				else if (i == 12)
				{
					Rank.VALUES.Add(new Rank(i, 11));
				}
			}
			/*
			foreach (Rank c in Rank.VALUES)
			{
				if (c.GetValue() == 11)
				{//modified ToString for ACE
					Console.WriteLine("RankName: " + c.GetName() + ", RankValue: 1 and " + c.GetValue() + ", RankSymbol: " + c.GetSymbol());
				}
				else
				{//Default ToString
					Console.WriteLine(c);
				}
			}*/


			Console.ReadLine();

			//gets specific rank object
			Rank compTest = Rank.VALUES[5];
			Console.WriteLine(compTest);
			Rank comp1Test = Rank.VALUES[5];
			Console.WriteLine(comp1Test);
			Rank comp3Test = new Rank(11, 10);
			Console.WriteLine(comp3Test);
			Console.WriteLine("Should be 0, it is {0}", compTest.CompareTo(comp1Test));
			Console.WriteLine("Should be 1, it is {0}", comp3Test.CompareTo(comp1Test));
			Console.WriteLine("Should be -1, it is {0}", compTest.CompareTo(comp3Test));
			Console.WriteLine();
			Console.ReadLine();

			for (int i = 0; i < 4; i++)
			{
				Suit.VALUES.Add(new Suit(i, 0));
			}

			foreach (Suit c in Suit.VALUES)
			{
				Console.WriteLine(c);
			}

			Console.ReadLine();
		}
	}
}
