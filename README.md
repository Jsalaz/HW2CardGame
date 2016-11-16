# HW2CardGame
DeckOfCards

Jorge Salazar
CSC 496: Large Scale Systems
Video Game Design
Homework 2: C# Object Oriented Deck of Cards with BlackJack and CardCount games

This was aour second C# assignment and it was meant to test our capabilities with 
Object Oriented Abstraction.

Additionally I worked with git for version control and NUnit for testing

My implementation differed from other by my use of Emuns to define the card rank and suits.

List of Classes:

BlackJackGame.cs:   -BlackJack Game Implementation. Starts and runs game with player vs computer

BlackJackHand.cs:   -Defines the rules for BlackJack Game, including winning hand

Card.cs:    	      -Defines a single card an object that encapsulates a Rank and Suit

CardCountGame.cs:   -CarCount Game Implementation. Starts and runs the game 

CardCountHand.cs:   -Defines the rules of Card Count Game, including winning hand

Deck.cs:            -Defined as a collection of cards with methods to create, shuffle, deal card.

HW2CardGame.csproj

Hand.cs             -Defined as a collection of cards with methods to FindCard, GetCard, Remove Car and abstract methods to compare and
                    evaluate hand

Program.cs:         -Demo Program, showcases the completed BlackJack and CardCound Games

README.txt          -Added during class to help demonstrate the use of remote git repositories

Rank.cs             -Defines the Ranks of the Card. Multiple constructors added to give more control in the definition of a rank

Suit.cs             -Defines the Suit of the Card. Multiple constructors added to give more control in the definition of a suit

packages.config     -Used for NUnit Testing

test.cs             -not used
