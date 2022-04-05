using System.Net.Security;

namespace ClCardGame;

public class Deck
{
    public Deck()
    {
        Cards = new List<Card>();
    }

    public List<Card> Cards { get; set; }

    public void CreateDeck(int amountOfJokers = 2)
    {
        for (int i = 0; i < amountOfJokers; i++)
        {
            Card card = new Card(Rank.Joker, Suit.Jokers);
            Cards.Add(card);
        }

        foreach (Rank rank in Enum.GetValues(typeof(Rank)))
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (rank != Rank.Joker && suit != Suit.Jokers)
                {
                    Card card = new Card(rank, suit);
                    Cards.Add(card);
                }
            }
        }
    }
}