using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCSharp
{
    public static class UI
    {

        public static void GameBoardComponent(Game game)
        {
            Console.WriteLine($" {GridLocationComponent(game.Row1[0])}  | {GridLocationComponent(game.Row1[1])}  | {GridLocationComponent(game.Row1[2])}");
            Console.WriteLine("____|____|____");
            Console.WriteLine($" {GridLocationComponent(game.Row2[0])}  | {GridLocationComponent(game.Row2[1])}  | {GridLocationComponent(game.Row2[2])}");
            Console.WriteLine("____|____|____");
            Console.WriteLine($" {GridLocationComponent(game.Row3[0])}  | {GridLocationComponent(game.Row3[1])}  | {GridLocationComponent(game.Row3[2])}");
            Console.WriteLine("    |    |");

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
                PleaseEnterCorrectFormatMessage();
                CorrectFormatReminderMessage();
                return false;
            }

            if (input.Any(char.IsLetter))
            {
                PleaseEnterCorrectFormatMessage();
                Console.WriteLine("Your input should not contain letters.");
                CorrectFormatReminderMessage();
                return false;
            }

            if (!input.Contains('.'))
            {
                PleaseEnterCorrectFormatMessage();
                Console.WriteLine("Your input should include a period.");
                CorrectFormatReminderMessage();
                return false;
            }

            if (input[1] != '.')
            {
                PleaseEnterCorrectFormatMessage();
                Console.WriteLine("Your input should include a period as a center separator.");
                CorrectFormatReminderMessage();
                return false;
            }

            var xAxis= int.Parse($"{input[0]}");
            
            var yAxis = int.Parse($"{input[2]}");

            if (xAxis > 3 || yAxis > 3)
            {

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
        



    }
}
