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
		}

		public void BlackJackStart()
		{
			BlackJackDeck = new Deck();
			PopulateDeck();
			BlackJackDeck.Shuffle();
			// deals two cards to each player
			humPlayer.AddCard(BlackJackDeck.DealOne());
			humPlayer.AddCard(BlackJackDeck.DealOne());
			compPlayer.AddCard(BlackJackDeck.DealOne());
			compPlayer.AddCard(BlackJackDeck.DealOne());

			Console.WriteLine("Welcome to BlackJack");

			if (HumanTurn() <= 21)
			{
				Console.WriteLine("Computer's Turn!");
				//Console.ReadLine();
				ComputerTurn();
			}
		}

		public void ComputerTurn()
		{
			int cCount = 0;
			Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
			Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
			Console.WriteLine("Dealer's Score is {0}", compPlayer.EvaluateHand());
			do
			{

				if (compPlayer.EvaluateHand() < 17)
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
			} while (compPlayer.EvaluateHand()< 17);
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
				if ((input == "h") || (input == "H"))
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
