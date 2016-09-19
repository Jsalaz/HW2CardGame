using System;

namespace HW2CardGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/**
			 * Populate Rank and Suits for BlackJack
			 * This sets the values for the game
			 * -----------Rank
			 * */
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
			//---------Suits
			for (int i = 0; i < 4; i++)
			{
				Suit.VALUES.Add(new Suit(i, 0));
			}
			/// <summary>
			/// Creates an instance of Deck Object
			/// and Populates it with the necesary cards only 13 for our test.
			/// </summary>
			Deck BlackJack = new Deck();
			//deckBuilder
			foreach (Rank r in Rank.VALUES)
			{
				foreach (Suit s in Suit.VALUES)
				{
					Card Test = new Card(s, r);
					BlackJack.AddCard(Test);
					//Console.WriteLine(Test);
				}
			}

			Console.WriteLine("---Shuffled Cards---");
			BlackJack.Shuffle();
			BlackJack.Shuffle();
			BlackJack.Shuffle();
			foreach (Card s in BlackJack.DeckOfCards)
			{
				Console.WriteLine(s);
			}

			Console.ReadLine();

			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());
			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());
			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());
			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());
			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());
			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());

			Console.WriteLine("Cards Left: {0}, DeckSize: {1}, Is it Empty: {2}", BlackJack.GetCardsRemaining(), 
			                  BlackJack.GetDeckSize(), BlackJack.IsEmpty());

			BlackJack.RestoreDeck();
			Console.WriteLine("Cards Left: {0}, DeckSize: {1}, Is it Empty: {2}", BlackJack.GetCardsRemaining(),
							  BlackJack.GetDeckSize(), BlackJack.IsEmpty());
			Console.ReadLine();

			foreach (Card s in BlackJack.DeckOfCards)
			{
				Console.WriteLine(s);
			}

			Console.ReadLine();
		}
	}
}

///////////////////////////////////////////////
/// 	SAVED CODE PARTS FOR BLACKJACK
///////////////////////////////////////////////
/*
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
			*//*
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
			/* //For BlackJack ToString
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
			}*//*


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
			*/

/*
			//random card used for testing
			//Card testCard = new Card();

			//blackJack card
			Card aCard = new Card(Suit.VALUES[3], Rank.VALUES[12]);
			Console.WriteLine(aCard);
			Console.WriteLine(aCard.GetRank());
			Console.WriteLine(aCard.GetSuit());
			Console.ReadLine();

			Card bCard = new Card(Suit.VALUES[3], Rank.VALUES[12]);
			Console.WriteLine(bCard);
			Console.WriteLine(bCard.GetRank());
			Console.WriteLine(bCard.GetSuit());
			Console.ReadLine();

			Card cCard = new Card(Suit.VALUES[2], Rank.VALUES[5]);//7
			Console.WriteLine(cCard);
			Console.WriteLine(cCard.GetRank());
			Console.WriteLine(cCard.GetSuit());
			Console.ReadLine();

			Console.WriteLine("Comparing {0} and {1}: ---> {2}", aCard, bCard, aCard.CompareTo(bCard));//should return 0
			Console.WriteLine("Comparing {0} and {1}: ---> {2}", aCard, cCard, aCard.CompareTo(cCard)); //should return 1
			Console.WriteLine("Comparing {0} and {1}: ---> {2}", cCard, bCard, cCard.CompareTo(bCard)); //should return -1
			Console.ReadLine();*/