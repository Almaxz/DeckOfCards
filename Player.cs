using System.Collections.Generic;

namespace DeckOfCards
{ 
    public class Player
    {
        string name;
        public List<Card> newDeck;

        public Player(string pName)
        {
            name = pName;
            newDeck = new List<Card>();
        }

        public Card draw(Deck deck)
        {
            Card c = deck.deal();
            newDeck.Add(c);
            return c;
        }

        public Card discard(int idx)
        {
            if(idx < 0 || idx > newDeck.Count){
                System.Console.WriteLine("");
                return null;
            } else {
                Card res = newDeck[idx];
                newDeck.RemoveAt(idx);
                return res;
            }
        }
    }
}