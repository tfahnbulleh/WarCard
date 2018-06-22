namespace WarCard
{
    partial class gameGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dealCardBtn = new System.Windows.Forms.Button();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.totalDealLbl = new System.Windows.Forms.Label();
            this.totalDealPrompt = new System.Windows.Forms.Label();
            this.playerScoreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.computerScoreLbl = new System.Windows.Forms.Label();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPictureCard = new System.Windows.Forms.PictureBox();
            this.computerPictureCard = new System.Windows.Forms.PictureBox();
            this.scorePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureCard)).BeginInit();
            this.SuspendLayout();
            // 
            // dealCardBtn
            // 
            this.dealCardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dealCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dealCardBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealCardBtn.ForeColor = System.Drawing.Color.White;
            this.dealCardBtn.Location = new System.Drawing.Point(406, 74);
            this.dealCardBtn.Name = "dealCardBtn";
            this.dealCardBtn.Size = new System.Drawing.Size(498, 143);
            this.dealCardBtn.TabIndex = 1;
            this.dealCardBtn.Text = "Click here to start game";
            this.dealCardBtn.UseVisualStyleBackColor = false;
            this.dealCardBtn.Click += new System.EventHandler(this.dealCardBtn_Click);
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.scorePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scorePanel.Controls.Add(this.totalDealLbl);
            this.scorePanel.Controls.Add(this.totalDealPrompt);
            this.scorePanel.Controls.Add(this.playerScoreLbl);
            this.scorePanel.Controls.Add(this.label1);
            this.scorePanel.Controls.Add(this.computerScoreLbl);
            this.scorePanel.Controls.Add(this.playerNameLbl);
            this.scorePanel.Controls.Add(this.label2);
            this.scorePanel.Location = new System.Drawing.Point(179, 621);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(884, 395);
            this.scorePanel.TabIndex = 2;
            // 
            // totalDealLbl
            // 
            this.totalDealLbl.AutoSize = true;
            this.totalDealLbl.BackColor = System.Drawing.Color.White;
            this.totalDealLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDealLbl.Location = new System.Drawing.Point(409, 312);
            this.totalDealLbl.Name = "totalDealLbl";
            this.totalDealLbl.Size = new System.Drawing.Size(0, 39);
            this.totalDealLbl.TabIndex = 9;
            // 
            // totalDealPrompt
            // 
            this.totalDealPrompt.AutoSize = true;
            this.totalDealPrompt.BackColor = System.Drawing.Color.White;
            this.totalDealPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDealPrompt.Location = new System.Drawing.Point(347, 250);
            this.totalDealPrompt.Name = "totalDealPrompt";
            this.totalDealPrompt.Size = new System.Drawing.Size(183, 39);
            this.totalDealPrompt.TabIndex = 8;
            this.totalDealPrompt.Text = "Total Deal";
            // 
            // playerScoreLbl
            // 
            this.playerScoreLbl.AutoSize = true;
            this.playerScoreLbl.BackColor = System.Drawing.Color.White;
            this.playerScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLbl.Location = new System.Drawing.Point(607, 118);
            this.playerScoreLbl.Name = "playerScoreLbl";
            this.playerScoreLbl.Size = new System.Drawing.Size(0, 58);
            this.playerScoreLbl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score Board";
            // 
            // computerScoreLbl
            // 
            this.computerScoreLbl.AutoSize = true;
            this.computerScoreLbl.BackColor = System.Drawing.Color.White;
            this.computerScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScoreLbl.Location = new System.Drawing.Point(215, 125);
            this.computerScoreLbl.Name = "computerScoreLbl";
            this.computerScoreLbl.Size = new System.Drawing.Size(0, 58);
            this.computerScoreLbl.TabIndex = 6;
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.BackColor = System.Drawing.Color.White;
            this.playerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLbl.Location = new System.Drawing.Point(561, 51);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(120, 39);
            this.playerNameLbl.TabIndex = 5;
            this.playerNameLbl.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Blue;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(529, 326);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(194, 129);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 70);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitGameToolStripMenuItem,
            this.resetGameToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(165, 66);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(408, 66);
            this.quitGameToolStripMenuItem.Text = "Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(408, 66);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // playerPictureCard
            // 
            this.playerPictureCard.Image = global::WarCard.Properties.Resources.JOKER;
            this.playerPictureCard.Location = new System.Drawing.Point(758, 259);
            this.playerPictureCard.Name = "playerPictureCard";
            this.playerPictureCard.Size = new System.Drawing.Size(305, 331);
            this.playerPictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureCard.TabIndex = 7;
            this.playerPictureCard.TabStop = false;
            // 
            // computerPictureCard
            // 
            this.computerPictureCard.Image = global::WarCard.Properties.Resources.JOKER;
            this.computerPictureCard.InitialImage = null;
            this.computerPictureCard.Location = new System.Drawing.Point(179, 259);
            this.computerPictureCard.Name = "computerPictureCard";
            this.computerPictureCard.Size = new System.Drawing.Size(313, 331);
            this.computerPictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureCard.TabIndex = 6;
            this.computerPictureCard.TabStop = false;
            // 
            // gameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1220, 1202);
            this.Controls.Add(this.playerPictureCard);
            this.Controls.Add(this.computerPictureCard);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.dealCardBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gameGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War card game";
            this.Load += new System.EventHandler(this.gameGUI_Load);
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dealCardBtn;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerScoreLbl;
        private System.Windows.Forms.Label computerScoreLbl;
        private System.Windows.Forms.Label totalDealLbl;
        private System.Windows.Forms.Label totalDealPrompt;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox computerPictureCard;
        private System.Windows.Forms.PictureBox playerPictureCard;
    }
}

