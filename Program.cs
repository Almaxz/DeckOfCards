    
using System;

namespace DeckOfCards 
{
    class Program
    {
        static void Main(string[] args)
        {
            Card ca = new Card("ca", "black", 1);
            Console.WriteLine(ca.val);
            Deck cb = new Deck().reset();
            Console.WriteLine(cb.cards.Count);
            Deck cd = new Deck();
            Player rj = new Player("Ranjan");
            Console.WriteLine(cd.cards.Count);

            rj.draw(cd);
            Console.WriteLine(rj.newDeck.Count);
            rj.draw(cd);
            Console.WriteLine(rj.newDeck.Count);
            rj.discard(4);
            Console.WriteLine(rj.newDeck.Count);
            
        }
    }
}