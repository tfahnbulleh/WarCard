using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCard
{
   public class DeckOfCard
    {
        private List<Card> DeckCard; //list of cards
        private const int NUMBEROFCARDS = 52; //number of cards on a deck
        
        //constructor
        public DeckOfCard()
        {
            DeckCard = new List<Card>();
            FillDeck();
        }


        //return instance variable DeckCard
        public List<Card> deckCard
        {
            get { return this.DeckCard; }
        }

         
        //fill deck of cards
        private void FillDeck()
        {
            List<int> faces = new List<int>() { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //face of cards
            List<string> suites = new List<string>() { "Heart", "Diamond", "Club", "Spade" };//card suites
            DeckCard.Clear();
            for (int i = 0; i < NUMBEROFCARDS; i++)
            {
                DeckCard.Add(new Card(faces.ElementAt(i % 13), suites.ElementAt(i / 13)));
            }
        }

        
        //method to generate random number
        private int GenerateRandomNumber(int max)
        {
            int num;
            Random random = new Random();
            num = random.Next(0, max);
            return num;
        }
    }
}
