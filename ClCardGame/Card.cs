namespace ClCardGame;

public enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Joker }
public enum Suit { Spaces, Clubs, Hearts, Diamonds, Jokers }

public class Card
{
    public Rank Rank;
    public Suit Suit;

    public Card(Rank rank, Suit suit)
    {
        Rank = rank;
        Suit = suit;
        Name = rank.ToString() + " of " + suit.ToString();
    }

    public string Name { get; set; }
}