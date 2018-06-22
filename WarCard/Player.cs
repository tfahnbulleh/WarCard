using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCard
{
    public class Player
    {
        private string _name;
        private int _score;
        private int _lastPointEarned;
        private List<Card> _cardSelected;
        private Card _currentCardSelected;

        //constructor
        public Player(string playerName)
        {
            _name = playerName;
            _score = 0;
            _lastPointEarned = 0;
            _cardSelected = new List<Card>();
        }


        //return the cards selected when card was shuffle and share
        public List<Card> CarSelected
        {
            get { return this._cardSelected; }
        }


        public void AddCard(Card card)
        {
            this._cardSelected.Add(card);
        }
            

        //get or set the name of a player
       public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        //get or set the score of a player
        public int Score
        {
            get { return this._score; }
            set { this._score = value; }
        }


        //get or set the last point earn by a player
        public int LastPointEarned
        {
            get { return this._lastPointEarned; }
            set { this._lastPointEarned = value;}
        }

        //reset player score and las point earn
        public void Reset()
        {
            this._cardSelected.Clear();
            this._score = 0;
            this._lastPointEarned = 0;
        }

        //get or set the current card selected by a player
        public Card CurrentCard
        {
            get { return this._currentCardSelected; }
            set { this._currentCardSelected = value; }
        }
   
    }
}
