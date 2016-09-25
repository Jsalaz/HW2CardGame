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
			PopulateDeck();
		}

		public void CardCountPlay()
		{
			if (CardCountDeck.GetCardsRemaining() < 16)
			{
				CardCountDeck.RestoreDeck();
				Console.WriteLine("Low Cards: Restoring Deck");
			}
			CardCountDeck.Shuffle();
			// canpossibly move to another method
			for (int x = 0; x < 8; x++)
			{
				player1.AddCard(CardCountDeck.DealOne());
				player2.AddCard(CardCountDeck.DealOne());
			}

			Console.WriteLine("---Welcome to CardCout!!---");
			Console.WriteLine("-Dealing Cards-");
			Console.WriteLine("Player 1's Cards:\n{0}", player1);
			Console.WriteLine("Player 2's Cards:\n{0}", player2);
			Console.WriteLine("Player 1's score: {0} || Player 2's score: {1}", player1.EvaluateHand(), player2.EvaluateHand());
			Console.WriteLine("There are {0} left in the deck of {1} cards", CardCountDeck.GetCardsRemaining(), CardCountDeck.GetDeckSize());
			if (player1.EvaluateHand() > player2.EvaluateHand())
			{ Console.WriteLine("Player 1 Wins!!"); }
			else if (player1.EvaluateHand() < player2.EvaluateHand())
			{ Console.WriteLine("Player 2 Wins!!"); }
			else
			{ Console.WriteLine("Tied Game"); }
			player2.DiscardHand();
			player1.DiscardHand();
			Console.ReadLine();
		}

		public void PopulateDeck()
		{
			//populates deck
			foreach (Rank r in Rank.VALUES)
			{
				foreach (Suit s in Suit.VALUES) //creates all cards in deck
				{
					Card Test = new Card(s, r);
					CardCountDeck.AddCard(Test);
				}
			}
		}
	}
}
