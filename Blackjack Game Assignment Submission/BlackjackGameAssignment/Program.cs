using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackGameAssignment
{
    // Enum to represent the suits of cards.
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    // Enum to represent the ranks of cards.
    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 10,
        Queen = 10,
        King = 10,
        Ace = 11
    }

    // Card class to represent a card in the deck
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        // Constructor to initialize a new card.
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        // Display the card as Rank of Suit (e.g., Ace of Spades).
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    // Deck class to represent a deck of cards
    public class Deck
    {
        private List<Card> _cards;

        // Constructor to create a new deck of cards
        public Deck()
        {
            _cards = new List<Card>();

            // Generate all cards in the deck
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Add(new Card(rank, suit));
                }
            }
        }

        // Shuffle the deck
        public void Shuffle()
        {
            Random rand = new Random();
            _cards = _cards.OrderBy(c => rand.Next()).ToList();
        }

        // Deal a card from the deck
        public Card DealCard()
        {
            Card dealtCard = _cards.FirstOrDefault();
            _cards.Remove(dealtCard);
            return dealtCard;
        }

        // Check how many cards are left in the deck
        public int CardsRemaining()
        {
            return _cards.Count;
        }
    }

    // Player class to represent the player
    public class Player
    {
        public string Name { get; set; }
        public int Balance { get; set; } = 100;
        public List<Card> Hand { get; set; } = new List<Card>();
        public bool isActivelyPlaying { get; set; } = true;

        // Method to calculate the player's score
        public int GetScore()
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in Hand)
            {
                score += (int)card.Rank;
                if (card.Rank == Rank.Ace)
                {
                    aceCount++;
                }
            }

            // If the score is over 21 and there are Aces, reduce the score by 10 for each Ace.
            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        // Method to clear the player's hand for a new round.
        public void ClearHand()
        {
            Hand.Clear();
        }
    }

    // Game class to manage the game logic
    public class BlackjackGame
    {
        private Deck _deck;
        private Player _player;

        // Constructor
        public BlackjackGame(Player player)
        {
            _player = player;
            _deck = new Deck();
            _deck.Shuffle();
        }

        // Method to play a round of blackjack
        public void Play()
        {
            // Clear hands before starting a new round
            _player.ClearHand();

            // Deal two cards to the player
            _player.Hand.Add(_deck.DealCard());
            _player.Hand.Add(_deck.DealCard());

            // Display the player's cards
            Console.WriteLine($"Your hand: {string.Join(", ", _player.Hand)}");

            // Let the player decide if they want to hit or stand
            string playerChoice = "";
            while (_player.GetScore() < 21 && playerChoice != "stand")
            {
                Console.WriteLine($"Your score: {_player.GetScore()}. Would you like to hit or stand?");
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "hit")
                {
                    _player.Hand.Add(_deck.DealCard());
                    Console.WriteLine($"Your hand: {string.Join(", ", _player.Hand)}");
                }
            }

            // Check the result after the player stands or busts
            if (_player.GetScore() > 21)
            {
                Console.WriteLine($"You busted with a score of {_player.GetScore()}! You lose this round.");
            }
            else
            {
                Console.WriteLine($"You stand with a score of {_player.GetScore()}.");
            }
        }
    }

    // Main program to start the game
    class Program
    {
        static void Main(string[] args)
        {
            // Create the player
            Player player = new Player { Name = "Player" };

            // Create a new game with the player
            BlackjackGame game = new BlackjackGame(player);

            // Game loop
            while (player.isActivelyPlaying && player.Balance > 0)
            {
                // Call the game play method to start a round
                game.Play();

                // Ask the player if they want to continue playing
                Console.WriteLine("Would you like to play another round? (yes/no)");
                string continuePlaying = Console.ReadLine().ToLower();
                if (continuePlaying != "yes")
                {
                    player.isActivelyPlaying = false;
                }
            }

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
    }
}
