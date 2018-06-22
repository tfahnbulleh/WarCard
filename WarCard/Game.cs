using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCard
{
   public class Game
    {
        public Player player;
        public Player Computer;
        private DeckOfCard DeckOfCard;
        private int _dealNumber=0;
        private bool _isDeal=false;
        private PictureBox computerPictureCard;
        private PictureBox playerPictureCard;

        public bool IsDeal
        {
            get { return _isDeal; }
        }

        public int DealNumber
        {
            get { return this._dealNumber; }
        }
        
        public Game(string playerName, PictureBox computerPic=null, PictureBox playerPic=null)
        {
            player = new Player(playerName);
            Computer = new Player("Computer");
            computerPictureCard = computerPic;
            playerPictureCard = playerPic;
            DeckOfCard = new DeckOfCard();
        }

        //method to determine if game has ended
        public bool IsGameEnd()
        {
            if (this._dealNumber.Equals(26))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //method to reset the game
        //each player will be given a Score of zero
        public void ResetGame()
        {
            Computer.Reset();
            player.Reset();
            _isDeal = false;
            _dealNumber = 0;
            DeckOfCard = new DeckOfCard();
        }


        //method to generate random number
        private int GenerateRandomNumber(int max)
        {
            int num;
            Random random = new Random();
            num= random.Next(0, max);
            return num;
        }

        //evenly distribute cards to player
        public void DistributeCard()
        {           
            int num; //store random number generated
            do
            {
                num = GenerateRandomNumber(DeckOfCard.deckCard.Count); //method call to generate random number
                Computer.AddCard(DeckOfCard.deckCard.ElementAt(num));
                DeckOfCard.deckCard.RemoveAt(num);
                num = GenerateRandomNumber(DeckOfCard.deckCard.Count);
                player.AddCard(DeckOfCard.deckCard.ElementAt(num));
                DeckOfCard.deckCard.RemoveAt(num);
            }
            while (DeckOfCard.deckCard.Count>0);
            _isDeal = true;
        }

        public void DealCard()
        {
            string winner;
            if (IsGameEnd())
            {
                if (Computer.Score>player.Score)
                {
                    winner = Computer.Name+ " wins";
                }
                else if(player.Score>Computer.Score)
                {
                    winner = player.Name+" wins";
                }
                else
                {
                    winner = "Game draw";
                }
                System.Windows.Forms.MessageBox.Show("GAME ENDS!!"+winner);
            }
            else
            {
                this._dealNumber += 1;
                SelectCard(Computer);
                SelectCard(player);
                ShowCardPicture();
                ScoreDeal();
            }
            
        }

        private void SelectCard(Player player)
        {
            int num = GenerateRandomNumber(player.CarSelected.Count);
            player.CurrentCard = player.CarSelected.ElementAt(num);
            player.CarSelected.RemoveAt(num);
        }

        private void ScoreDeal()
        {
            if(player.CurrentCard.Face>Computer.CurrentCard.Face)
            {
                player.Score += 2;
                player.LastPointEarned = 2;
            }
            else if(Computer.CurrentCard.Face>player.CurrentCard.Face)
            {
                Computer.Score += 2;
                Computer.LastPointEarned = 2;
            }
            else
            {
                Computer.Score += 1;
                player.Score += 1;
            }
        }


        private void ShowCardPicture()
        {
            if (playerPictureCard!=null && computerPictureCard!=null)
            {
                string filePath = Directory.GetCurrentDirectory() + "\\Resources\\" + Computer.CurrentCard.ToString()+".PNG";
                computerPictureCard.ImageLocation = filePath;
                filePath = Directory.GetCurrentDirectory() + "\\Resources\\" +player.CurrentCard.ToString() + ".PNG";
                playerPictureCard.ImageLocation = filePath;
            }
           
        }




    }
}
