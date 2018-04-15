using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBrain;
//Kevin Nguyen
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Kevin Nguyen");
            Console.WriteLine("TicTacToe Console Test");

            var ticTacToeGame = new TicTacToeGame();

            var testCase = ticTacToeGame.IdentifyMarker(0, 0);
            Console.WriteLine();
            Console.WriteLine("after instantiating the TicTacToeGame class,");
            Console.WriteLine($"Cell 0,0 is currently : {testCase}");
            Console.WriteLine($"Note: testcase is of type: {testCase.GetType()}");

            ticTacToeGame.ResetGrid();

            var testcase2 = ticTacToeGame.IdentifyMarker(0,0);
            Console.WriteLine();
            Console.WriteLine("now that the class is reset and ready to play,");
            Console.WriteLine($"Cell 0,0 is now : {testcase2}");

            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            Console.WriteLine();
            Console.WriteLine("the marker is set to human, checking,");
            Console.WriteLine($"cell 0,0 is finally : {ticTacToeGame.IdentifyMarker(0, 0)}");

            ticTacToeGame.PlayerName = "Kevin Nguyen";
            Console.WriteLine();
            Console.WriteLine("The player name is set and is now");
            Console.WriteLine($"PlayerName : {ticTacToeGame.PlayerName}");

            Console.WriteLine();
            Console.WriteLine($"Winner : {ticTacToeGame.Winner}");
            Console.WriteLine($"Evaluate Board : {ticTacToeGame.EvaluateBoard()}");
            Console.WriteLine($"IdentifyWinner : {ticTacToeGame.IdentifyWinner()}");

            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();


        }
    }
}
