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
		}

		public void BlackJackStart()
		{
			PopulateDeck();
			BlackJackDeck.Shuffle();
			// deals two cards to human player
			humPlayer.AddCard(BlackJackDeck.DealOne());
			humPlayer.AddCard(BlackJackDeck.DealOne());
			compPlayer.AddCard(BlackJackDeck.DealOne());
			compPlayer.AddCard(BlackJackDeck.DealOne());

			Console.WriteLine("Welcome to BlackJack");

			if (HumanTurn() <= 21)
			{
				Console.WriteLine("Computer's Turn!");
				Console.ReadLine();
				ComputerTurn();
			}
			else
			{
				Console.WriteLine("You're over 21 (bust). Dealer Wins!");
				Console.ReadLine();
			}
			//Console.WriteLine("Computer's Turn!");
			//Console.ReadLine();
		}

		public void ComputerTurn()
		{
			int cCount = 0;
			bool hit = true;
			Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
			Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
			do
			{
				Console.WriteLine("Dealer's Score is {0}", compPlayer.EvaluateHand());
				if (compPlayer.EvaluateHand() < 17)
				{
					compPlayer.AddCard(BlackJackDeck.DealOne());
					Console.WriteLine("Dealer has been dealt the {0}", compPlayer.GetCardAtIndex(cCount++));
				}
				else if (compPlayer.EvaluateHand() > 21)
				{ 
					Console.WriteLine("Dealer's Score is {0}", compPlayer.EvaluateHand());
					Console.WriteLine("Dealer is over 21: You Win!!");
					hit = false;
				}
			} while (hit) ;
			Console.ReadLine();
			//return compPlayer.EvaluateHand();
		}

		public int HumanTurn()
		{
			int hCount = 0;
			string input;

			Console.WriteLine("You have been dealt the {0}", humPlayer.GetCardAtIndex(hCount++));
			Console.WriteLine("You have been dealt the {0}", humPlayer.GetCardAtIndex(hCount++));
			do
			{
				Console.WriteLine("Your Score is {0}", humPlayer.EvaluateHand());
				Console.WriteLine("Hit or Stand (H/S)?");
				input = Convert.ToString(Console.ReadLine());
				if ((input == "h") || (input == "H"))
				{
					humPlayer.AddCard(BlackJackDeck.DealOne());
					Console.WriteLine("You have been dealt the {0}", humPlayer.GetCardAtIndex(hCount++));
				}
				else if (input == "s" || input == "S")
				{ break; }
			} while (input != "s" || input != "S");// (input != 'S'));
			return humPlayer.EvaluateHand();
		}

		public void PopulateDeck()
		{
			//populates deck
			for (int q = 0; q < 6; q++)
			{
				foreach (Rank r in Rank.VALUES)
				{
					foreach (Suit s in Suit.VALUES) //creates all cards in deck
					{
						Card Test = new Card(s, r);
						BlackJackDeck.AddCard(Test);
						//Console.WriteLine(Test);
					}
				}
			}
		}
	}
}
