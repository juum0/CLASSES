using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            d.Shuffle();
            BJHand player = new BJHand(d, 2);
            BJHand dealer = new BJHand(d, 2);
            //ToString not working right, maybe not dealing any cards?
            Console.WriteLine(player.ToString());
            int gameLoop = 1;
            string hitStand = "";
            int playerScore = 0;
            int dealerScore = 0;
            while (gameLoop == 1)
            {
                int playerTurn = 1;
                int dealerTurn = 1;
                while (playerTurn == 1)
                {
                    Console.WriteLine("Your current score is: " + player.Score + ". Would you like to hit or stand?");
                    hitStand = Console.ReadLine();
                    hitStand = StringCleaning(hitStand);
                    Console.WriteLine();
                    if (player.IsBusted == false)
                    {
                        if (hitStand.Substring(0, 1) == "h")
                        {
                            player.AddCard(d.Deal());
                            Console.WriteLine(player.ToString());
                        }
                        else if (hitStand.Substring(0, 1) == "s")
                        {
                            playerTurn = 0;
                            while (dealerTurn == 1)
                            {
                                if (dealer.IsBusted == false)
                                {
                                    if (dealer.Score < 17)
                                        dealer.AddCard(d.Deal());

                                    else if (dealer.Score > 17)
                                        dealerTurn = 0;
                                }

                                else if (dealer.IsBusted == true)
                                {
                                    Console.WriteLine("Dealer busted! You win!");
                                    playerScore++;
                                    gameLoop = PlayAgain();
                                }

                                else
                                {
                                    if (dealer.Score == player.Score && dealer.Score <= 21 && playerScore <= 21)
                                        Console.WriteLine("Draw");
                                    else if (dealer.Score > player.Score && dealer.Score <= 21 && playerScore <= 21)
                                    {
                                        Console.WriteLine("Dealer wins");
                                        dealerScore++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You win!");
                                        playerScore++;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Busted!");
                        dealerScore++;
                        gameLoop = PlayAgain();
                    }
                }
            }
        }

        static int PlayAgain()
        {
            Console.WriteLine("Play again? Yes or no?");
            string reTry = Console.ReadLine();
            reTry = StringCleaning(reTry);
            if (reTry.Substring(0, 1) == "y")
                return 1;
            else 
                return 0;
        }

        static string StringCleaning(string s)
        {
            s.ToLower();
            string clean = "";
            foreach (char c in s)
                if (Char.IsLetter(c) == true)
                    clean = clean + c;
            return clean;
        }
    }
}

