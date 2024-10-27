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
            Console.WriteLine("  {0}     |   {1}    |   {2}  ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("________|________|________");
            Console.WriteLine("        |        |        ");
            Console.WriteLine("  {0}     |   {1}    |   {2}  ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("________|________|________");
            Console.WriteLine("        |        |        ");
            Console.WriteLine("  {0}     |   {1}    |   {2}  ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("        |        |        ");
        }

        /// <summary>
        /// Chekes if the game was WON, TIED, or should CONTINUE
        /// </summary>
        static int CheckWin()
        {
            if (spaces[0] == spaces[1] && //row 1
               spaces[1] == spaces[2] ||
               spaces[3] == spaces[4] && //row 2
               spaces[4] == spaces[5] ||
               spaces[6] == spaces[7] && //row 3
               spaces[7] == spaces[8] ||
               spaces[0] == spaces[3] && //column 1
               spaces[3] == spaces[6] ||
               spaces[1] == spaces[4] && //column 2
               spaces[4] == spaces[7] ||
               spaces[2] == spaces[5] && //column 3
               spaces[5] == spaces[8] ||
               spaces[0] == spaces[4] && //diagonal 1
               spaces[4] == spaces[8] ||
               spaces[2] == spaces[4] && //diagonal 2
               spaces[4] == spaces[6])
            {
                //one of the players won the game (we don'y know yet wich )
                return 1;
            }
            // checks for the tie comdition - All spaces on the board are 'X' or 'O' no longer set to a number 1-9
            else if (spaces[0] != '1' &&
                     spaces[1] != '2' &&
                     spaces[2] != '3' &&
                     spaces[3] != '4' &&
                     spaces[4] != '5' &&
                     spaces[5] != '6' &&
                     spaces[6] != '7' &&
                     spaces[7] != '8' &&
                     spaces[8] != '9')
            {
                // 
                return -1;
            }
            else
            {
                //
                return 0;
            }
        }

        /// <summary>
        /// Draws an X on the game board (instead of the numbers 1-9)
        /// </summary>
        /// <param name="pos"></param>
        static void DrawX(int pos)
        {
            spaces[pos] = 'X';
        }

        /// <summary>
        /// Draws an O on the game board (instead of the numbers 1-9)
        /// </summary>
        /// <param name="pos"></param>
        static void DrawO(int pos)
        {
            spaces[pos] = 'O';
        }


        /// <summary>
        /// THe main Game Loop
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 will be 'X' and Player 2 will br 'O' " + "\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 - YOUR TURN");
                }
                else
                {
                    Console.WriteLine("Player 1 - YOUR TURN");
                }
                Console.WriteLine("\n");
                DrawBoard();

                choice = int.Parse(Console.ReadLine()) - 1; //The negative one is to accountr the fact thet numbers on board stard with one but the index starts with 0 

                //Check that the space is empty no 'X' or 'O'
                if (spaces[choice] != 'X' &&
                   spaces[choice] != 'O')
                {
                    //Check if it was Player 1 ot Player 2 
                    if (player % 2 == 0)
                    {
                        DrawO(choice);
                    }
                    else
                    {
                        DrawX(choice);
                    }
                    //incramente the player, works because plaer one will be always Odd and Player 2 even 
                    player++;

                }
                else
                {
                    Console.WriteLine("The rpw {0} is alredy marked witg {1} \n", choice, spaces[choice]);
                    Console.WriteLine("Please wait 1 second . . .  ");
                    Thread.Sleep(1000);
                }

                flag = CheckWin();
            }while (flag != 1 && flag != -1);

            Console.Clear();
            DrawBoard();

            if(flag == 1)
            {
                Console.WriteLine(" Player {0} has WON! ", (player %2) +1);
            }
            else
            {
                Console.WriteLine(" TIE GAME ");
            }

            Console.ReadLine(); 

        }
    } 
}
  




