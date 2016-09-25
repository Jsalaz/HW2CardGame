using System;
namespace HW2CardGame
{
	public class BlackJackGame
	{
		BlackJackHand compPlayer;
		BlackJackHand humPlayer;
		Deck BlackJackDeck;

		public BlackJackGame()
		{
			compPlayer = new BlackJackHand();
			humPlayer = new BlackJackHand();
			BlackJackDeck = new Deck();
			PopulateDeck();
		}

		public void BlackJackStart()
		{
			//checks if you are short on cards. 
			//If you are short then the used cards are restored into the deck 
			//and the deck is shuffled
			if (BlackJackDeck.GetCardsRemaining() < 10)
			{
				BlackJackDeck.RestoreDeck();
			}
			BlackJackDeck.Shuffle();
			// deals two cards to each player
			humPlayer.AddCard(BlackJackDeck.DealOne());
			humPlayer.AddCard(BlackJackDeck.DealOne());
			compPlayer.AddCard(BlackJackDeck.DealOne());
			compPlayer.AddCard(BlackJackDeck.DealOne());

			Console.WriteLine("Welcome to BlackJack");

			if (HumanTurn() <= 21)
			{
				Console.WriteLine("\nComputer's Turn!");
				ComputerTurn();
				if (humPlayer.CompareTo(compPlayer) == 1)
				{
					Console.WriteLine("You are the winner: Your Score {0} || Dealers' score {1}", humPlayer.EvaluateHand(), compPlayer.EvaluateHand());
				}
				else if (humPlayer.CompareTo(compPlayer) == -1)
				{
					Console.WriteLine("Dealer is the winner: Your Score {0} || Dealers' score {1}", humPlayer.EvaluateHand(), compPlayer.EvaluateHand());
				}
				else if (humPlayer.CompareTo(compPlayer) == 0)
				{
					Console.WriteLine("Game is a draw (push): Your Score {0} || Dealers' score {1}", humPlayer.EvaluateHand(), compPlayer.EvaluateHand());
				}
			}

			Console.WriteLine("There are {0} left in the deck of {1} cards", BlackJackDeck.GetCardsRemaining(), BlackJackDeck.GetDeckSize());
			humPlayer.DiscardHand();
			compPlayer.DiscardHand();
			Console.ReadLine();
		}

		public void ComputerTurn()
		{
			int cCount = 0;
			Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
			Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
			Console.WriteLine("Dealer's Score is {0}", compPlayer.EvaluateHand());

			while (compPlayer.EvaluateHand() < 17 && (compPlayer.EvaluateHand() < humPlayer.EvaluateHand()))
			{
				if (compPlayer.EvaluateHand() < 17 && !BlackJackDeck.IsEmpty())
				{
					compPlayer.AddCard(BlackJackDeck.DealOne());
					Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
					Console.WriteLine("Dealer's Score is {0}", compPlayer.EvaluateHand());
				}
				if (compPlayer.EvaluateHand() > 21)
				{
					Console.WriteLine("Dealer is over 21: You Win!!");
					break;
				}
			}
		}

		public int HumanTurn()
		{
			int hCount = 0;
			string input;
			Console.WriteLine("You have been dealt the {0}", humPlayer.GetCardAtIndex(hCount++));
			Console.WriteLine("You have been dealt the {0}", humPlayer.GetCardAtIndex(hCount++));
			Console.WriteLine("Your Score is {0}", humPlayer.EvaluateHand());
			do
			{
				Console.WriteLine("Hit or Stand (H/S)?");
				input = Convert.ToString(Console.ReadLine());
				if (((input == "h") || (input == "H")) && !BlackJackDeck.IsEmpty() )
				{
					humPlayer.AddCard(BlackJackDeck.DealOne());
					Console.WriteLine("You have been dealt the {0}", humPlayer.GetCardAtIndex(hCount++));
					Console.WriteLine("Your Score is {0}", humPlayer.EvaluateHand());
					if (humPlayer.EvaluateHand() > 21)
					{ 
						Console.WriteLine("You're over 21 (bust). Dealer Wins!");
						break;
					}
				}
			} while (input != "s" && input != "S");
			return humPlayer.EvaluateHand();
		}

		public void PopulateDeck()
		{
			//populates deck with 6 decks
			for (int q = 0; q < 6; q++)
			{
				foreach (Rank r in Rank.VALUES)
				{
					foreach (Suit s in Suit.VALUES)
					{
						Card Test = new Card(s, r);
						BlackJackDeck.AddCard(Test);
					}
				}
			}

		}
	}
}
