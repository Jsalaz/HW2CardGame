using System;

namespace HW2CardGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input;
			CardCountGame CCGame = new CardCountGame();
			BlackJackGame BJackGame = new BlackJackGame();
			do
			{
				Console.WriteLine("\nPick from the Menu:");
				Console.WriteLine("1: CardCount");
				Console.WriteLine("2: BlackJack");
				Console.WriteLine("3: Quit");
				input = Convert.ToString(Console.ReadLine());
				switch (input)
				{
					case "1":
						{
							CCGame.CardCountPlay();
							break;
						}
					case "2":
						{
							BJackGame.BlackJackStart();
							break;
						}
					case "3":
						{
							Console.WriteLine("Thanks for playing");
							break; 
						}
					default:
						{ break; }
				}
			} while (input != "3");
			Console.ReadLine();

		}
	}
}
