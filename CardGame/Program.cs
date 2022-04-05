// See https://aka.ms/new-console-template for more information

using ClCardGame;

Deck deck = new Deck();

deck.CreateDeck(2);

foreach (var card in deck.Cards)
{
    Console.WriteLine(card.Name);
}