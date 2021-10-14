using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe
{
    class UC2Chooseletter
    {
        public static void createboard()
        {
            char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        }
        public static void chooseletter()
        {
            char letter;

            Console.WriteLine("Choose a letter X or O: ");
            letter = Console.ReadLine()[0];

            if (letter == 'X')
            {
                Console.WriteLine("Player's letter is X.");
                Console.WriteLine("Computer's letter is O.");
            }
            else if (letter == 'O')
            {
                Console.WriteLine("Player's letter is O.");
                Console.WriteLine("Computer's letter is X.");
            }
            else
            {
                Console.WriteLine("Error. You have to choose X or O only.");
            }
        }
    }

}