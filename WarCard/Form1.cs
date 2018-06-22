using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCard
{
    public partial class gameGUI : Form
    {
        Game game;
        public gameGUI()
        {
            InitializeComponent();
            game= new Game("Player",computerPictureCard,playerPictureCard); //initialize game object
        }

     
        //
        private void dealCardBtn_Click(object sender, EventArgs e)
        {
            game.DistributeCard(); //method call to distribute card to players
            if (game.IsDeal) //check if the card has been deal
            {
                dealCardBtn.Enabled = false;
                dealCardBtn.Text = "Click play to deal a card";
            }

            //card has not been deal
            playerScoreLbl.Text = game.player.Score.ToString();
            computerScoreLbl.Text = game.Computer.Score.ToString();
            totalDealLbl.Text = game.DealNumber.ToString();
            playBtn.Enabled = true;//disable button
            dealCardBtn.Text = "Click play to deal a card";
        }


        //the play button is click
        private void playBtn_Click(object sender, EventArgs e)
        {
            game.DealCard(); //method call to deal card
            playerScoreLbl.Text = game.player.Score.ToString(); //set label text
            computerScoreLbl.Text = game.Computer.Score.ToString(); //set label text
            totalDealLbl.Text = game.DealNumber.ToString();//set label text
        }

       
        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.ResetGame(); //method call to reset game
            playBtn.Enabled = false; //disable playerBtn button
            dealCardBtn.Enabled = true; //enable button
            playerScoreLbl.Text = game.player.Score.ToString(); //set text of label
            computerScoreLbl.Text = game.Computer.Score.ToString();//set text of label
            totalDealLbl.Text = game.DealNumber.ToString(); //set text
            totalDealLbl.Text = game.DealNumber.ToString(); //set text
            totalDealLbl.Text = game.DealNumber.ToString(); //set text
            computerPictureCard.Image = WarCard.Properties.Resources.JOKER;
            playerPictureCard.Image = WarCard.Properties.Resources.JOKER;
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //exit the application
        }

        private void gameGUI_Load(object sender, EventArgs e)
        {
            playBtn.Enabled = false; //enable button
            this.MaximizeBox = false; //disable window maximize button
            this.Height = 430; //set the height of the window or form
            this.MinimumSize = this.Size; //set the max size of the window or form
            this.MaximumSize = this.Size; //set the min size ofthe window or form
        }

     
    }
}
