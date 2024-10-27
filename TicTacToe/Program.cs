using System;
using System.Net.Http.Headers;
using System.Threading;

namespace TicTacToe
{
    
    class Program
    {
        // Data strtacture to hold the values for the spaces on the game board
        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        //Varibles to indicate wich player turn 
        static int player = 1;

        // What space the player chose on the board on his turn
        static int choice;

        // Flag to indicate wich player WON is it a TIE or the game CONTINUE
        static int flag;

        /// <summary>
        /// Draws the game board
        /// </summary>
        static void DrawBoard()
        {
            //Number will indicate the square not taken,  X for player 1 chosice, O for player 2 chosice
            Console.WriteLine("        |        |        ");
            Console.WriteLine("  {0}   |   {1}  |   {2}  ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("________|________|________");
            Console.WriteLine("        |        |        ");
            Console.WriteLine("  {0}   |   {1}  |   {2}  ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("________|________|________");
            Console.WriteLine("        |        |        ");
            Console.WriteLine("  {0}   |   {1}  |   {2}  ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("        |        |        ");
        }

        /// <summary>
        /// Chekes if the game was WON, TIED, or should CONTINUE
        /// </summary>
        static int CheckWin()
        {
            if(spaces[0] == spaces[1] &&
               spaces[1] == spaces[2] || //row 1
               spaces[3] == spaces[4] &&
               spaces[4] == spaces[5] || //row 2
               spaces[6] == spaces[7] &&
               spaces[7] == spaces[8] || //row 3
               )

        }


        public static void Main(string[] args)
        {

        }
    }

}
