using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCSharp.Players;

namespace TicTacToeCSharp
{
    public static class UI
    {

        public static void DisplayGameBoardComponent(GameState game)
        {
            Console.WriteLine("   1     2     3");
            Console.WriteLine("      |     |");
            Console.WriteLine($"1  {GridLocationComponent(game.Row1[0])}  | {GridLocationComponent(game.Row1[1])}   | {GridLocationComponent(game.Row1[2])}");
            Console.WriteLine(" _____|_____|_____");
            Console.WriteLine("      |     |");
            Console.WriteLine($"2  {GridLocationComponent(game.Row2[0])}  | {GridLocationComponent(game.Row2[1])}   | {GridLocationComponent(game.Row2[2])}");            
            Console.WriteLine(" _____|_____|_____");
            Console.WriteLine("      |     |");
            Console.WriteLine($"3  {GridLocationComponent(game.Row3[0])}  | {GridLocationComponent(game.Row3[1])}   | {GridLocationComponent(game.Row3[2])}");
            Console.WriteLine("      |     |");
            

        }

        public static string GridLocationComponent(string location)
        {

            var locationString = " ";
            if (!string.IsNullOrEmpty(location))
            {
                locationString = location;
                return locationString;
            }

            return locationString;
        }

        public static bool InputIsAcceptable(string input)
        {
            if (input.Length != 3 || string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {                
                CorrectFormatReminderMessage();
                return false;
            }

            if (input.Any(char.IsLetter))
            {                
                Console.WriteLine("Your input should not contain letters.");
                CorrectFormatReminderMessage();
                return false;
            }

            if (!input.Contains('.'))
            {
                
                Console.WriteLine("Your input should include a period.");
                CorrectFormatReminderMessage();
                return false;
            }

            if (input[1] != '.')
            {
                
                Console.WriteLine("Your input should include a period as a center separator.");
                CorrectFormatReminderMessage();
                return false;
            }

            var xAxis= int.Parse($"{input[0]}");            
            var yAxis = int.Parse($"{input[2]}");

            if (xAxis > 3 || yAxis > 3 || xAxis == 0 || yAxis == 0)
            {
                Console.WriteLine("X and Y Axis values should be between 1 and 3");
                CorrectFormatReminderMessage();
                return false;
            }
            
            return true;
        }            
          
        private static void CorrectFormatReminderMessage()
        {
            Console.WriteLine("The correct format should include a X axis value between (1 - 3) followed by a period (.) followed by a Y axis value between (1 - 3). For example: 1.3 or 2.1");
            Console.WriteLine("");
        }

        private static void PleaseEnterCorrectFormatMessage()
        {
            Console.WriteLine("Please enter the correct format.");
        }
        
        public static void PlayerTakesTurn(GameState game, PlayerBase player)
        {
            while (true)
            {

                Console.WriteLine($"Where you like to place the {player.Symbol}");
                
                string input = Console.ReadLine();

                if (!InputIsAcceptable(input))
                {
                    continue;
                }

                var xAxis = int.Parse($"{input[0]}");
                var yAxis = int.Parse($"{input[2]}");

                if (GameLogic.HasLocationAlreadyBeenSelected(game, xAxis, yAxis))                 
                {
                    continue;
                }

                GameLogic.SetSymbolAtLocation(game, player, xAxis, yAxis);
                break;

            }           

        }

        public static void InitializeGame(GameState game)
        {
            bool gameOn = true;
            DisplayGameBoardComponent(game);
            while (gameOn)
            {
                if (game.WinnerOrTieExists == false)
                {
                    
                    PlayerTakesTurn(game, game.O);
                    GameLogic.CheckForWinner(game);
                    DisplayGameBoardComponent(game);
                }

                if (game.WinnerOrTieExists == false)
                {                    
                    PlayerTakesTurn(game, game.X);
                    GameLogic.CheckForWinner(game);
                    DisplayGameBoardComponent(game);
                }

                if (game.WinnerOrTieExists == true)
                {
                    gameOn = false;
                }
            }

            

            
        }


    }
}
