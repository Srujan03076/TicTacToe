using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe");
            Console.WriteLine();
            UC1Createboard.createboard();
            UC2Chooseletter.chooseletter();
            UC3Choosevalidcells.choosevalidcell();
        }
    }
}