# WarCard

In the card game War, a deck of playing cards is divided between two players. Each player exposes a
card; the player whose card has the higher value wins possession of both exposed cards. Create a a
computerized game of War named War Card Game in which a standard 52-card deck is randomly
divided between two players, one of which is the computer. Reveal one card for the computer and one
card for the player at a time. Award 2wo points for the player whose card has the higher value. (For this
game the king is the highest card, followed by the queen and jack, then the numbers 10 down to 2 and
finally the ace.) If the computer and player expose cards with equal value in the same turn, award one
point to each. At the end of the game, all 52 cards should have been played only once, and the sum of
the player’s and computer’s score will be 50.
Use an array of 52 integers to store unique values for each card. Write a method named FillDeck()
that places 52 unique values into this array. Write another method named SelectCard() that you
call twice on each deal to select a unique card for each player, with no repetition of cards in 26 deals.
(To pause the play between each dealt hand you use a button.
Create the GUI of the War card game and name it WarCardGameGUI. Let the user click a button to
deal the cards, then make that button invisible and expose a Play button. Each time the user clicks Play,
a pair of cards is revealed. To keep the Frame size reasonable, you might want to erase the output
label’s contents every four hands of so. Below are sever examples of how the QUI could be created.
