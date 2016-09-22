using System;

namespace HW2CardGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			CardCountGame CCGame = new CardCountGame();
			CCGame.CardCountPlay();
		}
	}
}

///////////////////////////////////////////////
/// 	SAVED CODE PARTS FOR BLACKJACK
///////////////////////////////////////////////
/*
/**
			 * Populate Rank and Suits for BlackJack
			 * This sets the values for the game
			 * -----------Rank
			 * */
/*
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
			*//*

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
/// <summary>
			/// Creates an instance of Deck Object
			/// and Populates it with the necesary cards only 13 for our test.
			/// </summary>
			Deck BlackJack = new Deck();
			//deckBuilder
			foreach (Rank r in Rank.VALUES)
			{

				Card Test = new Card(Suit.VALUES[0], r);
				BlackJack.AddCard(Test);
				Console.WriteLine(Test);
				/*foreach (Suit s in Suit.VALUES) //creates all cards in deck
				{
					Card Test = new Card(s, r);
					BlackJack.AddCard(Test);
					//Console.WriteLine(Test);
				}*//*
			}

			Console.WriteLine("---Shuffled Cards---");
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
			Console.WriteLine("Picked up {0} from the Deck. ", BlackJack.DealOne());
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

			// instantiate some cards
			Card c1 = new Card(Suit.VALUES[2], Rank.VALUES[0]); //2 hearts
Card c2 = new Card(Suit.VALUES[2], Rank.VALUES[0]); //k heart
Card c3 = new Card(Suit.VALUES[0], Rank.VALUES[2]); //4 clubs
Card c4 = new Card(Suit.VALUES[0], Rank.VALUES[9]); //J clubs
Card c5 = new Card(Suit.VALUES[1], Rank.VALUES[12]);//A diamonds
Card c6 = new Card(Suit.VALUES[1], Rank.VALUES[11]);//K diamonds

// Testing comparison
Console.WriteLine("Comparing {0}, to {1}:------> {2}", c1, c2, c1.CompareTo(c2));
			Console.WriteLine("Comparing {0}, to {1}:------> {2}", c1, c3, c1.CompareTo(c3));
			Console.WriteLine("Comparing {0}, to {1}:------> {2}", c3, c1, c3.CompareTo(c1));
			Console.WriteLine("Comparing {0}, to {1}:------> {2}", c1, c4, c1.CompareTo(c4));
			Console.WriteLine("Comparing {0}, to {1}:------> {2}", c4, c5, c4.CompareTo(c5));
			Console.WriteLine("Comparing {0}, to {1}:------> {2}", c6, c4, c6.CompareTo(c4));
			Console.WriteLine("Comparing {0}, to {1}:------> {2}", c4, c6, c4.CompareTo(c6));


			foreach (Card s in BlackJack.DeckOfCards)
			{
				Console.WriteLine(s);
			}

			Console.ReadLine();
			*/