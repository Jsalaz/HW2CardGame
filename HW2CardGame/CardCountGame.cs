using System;
namespace HW2CardGame
{
	public class CardCountGame
	{
		CardCountHand player1;
		CardCountHand player2;
		Deck CardCountDeck;

		public CardCountGame()
		{
			player1 = new CardCountHand();
			player2 = new CardCountHand();
			CardCountDeck = new Deck();
		}

		public void CardCountPlay()
		{
			PopulateDeck();
			CardCountDeck.Shuffle();
			// canpossibly move to another method
			for (int x = 0; x < 8; x++)
			{
				player1.AddCard(CardCountDeck.DealOne());
				player2.AddCard(CardCountDeck.DealOne());
			}

			Console.WriteLine("Player 1's Cards:\n" + player1);
			Console.WriteLine("Player 2's Cards:\n" + player2);
			Console.ReadLine();
		}

		public void PopulateDeck()
		{
			//sets rank
			for (int i = 2; i < 15; i++)
			{
				if (i < 11)
				{ Rank.VALUES.Add(new Rank(i, i)); }
				else if (i > 10 && i < 14)
				{ Rank.VALUES.Add(new Rank(i, 10)); }
				else
				{ Rank.VALUES.Add(new Rank(i, 1)); }
			}
			//sets suit
			for (int i = 0; i < 4; i++)
			{
				Suit.VALUES.Add(new Suit(i));
			}

			//populates deck
			foreach (Rank r in Rank.VALUES)
			{
				foreach (Suit s in Suit.VALUES) //creates all cards in deck
				{
					Card Test = new Card(s, r);
					CardCountDeck.AddCard(Test);
					//Console.WriteLine(Test);
				}
			}
		}


	}
}
