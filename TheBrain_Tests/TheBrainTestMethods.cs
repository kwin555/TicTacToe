using System;
using NUnit.Framework;
using TheBrain;
using Shouldly;
//kevin nguyen
namespace TheBrain_Tests
{
    [TestFixture()]
    public class TheBrainTestMethods
    {
        [Test]
        public void TestClassINstantiation()
        {
            //setup

            //Test
            var ticTacToeGame = new TicTacToeGame();

            //Assert
            ticTacToeGame.ShouldNotBeNull();
            ticTacToeGame.IdentifyMarker(0, 0).ShouldBe(CellOwners.Error);
        }

        [Test]
        public void ResetGridTest()
        {
            //Setup
            var ticTacToeGame = new TicTacToeGame();
            //Test
            ticTacToeGame.ResetGrid();
            //Assert
            ticTacToeGame.IdentifyMarker(0,0).ShouldBe(CellOwners.Open);
        }

        [Test]
        public void PlaceMarkerTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();
            //test
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            //assert
            ticTacToeGame.IdentifyMarker(0, 0).ShouldBe(CellOwners.Human);
        }

        [Test]
        public void PlayerNameTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            //test
            ticTacToeGame.PlayerName = "Kevin Nguyen";
            //assert
            ticTacToeGame.PlayerName.ShouldBe("Kevin Nguyen");
        }

        [Test]
        public void WinnerTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            //test
           ticTacToeGame.ResetGrid();
            //assert
           ticTacToeGame.Winner.ShouldBe(CellOwners.Open);
        }

        [Test]
        public void EvaluateBoardTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();
            //test
            ticTacToeGame.EvaluateBoard();
            //assert
            ticTacToeGame.EvaluateBoard().ShouldBeFalse();
        }
        [Test]
        public void IdentifyWinnerTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();
            //test
            ticTacToeGame.IdentifyWinner();
            //assert
            ticTacToeGame.IdentifyWinner().ShouldBe(String.Empty);
        }

        [Test]
        public void EvaluateBoardHumanTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();
            //test
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(1, 1, CellOwners.Human);
            ticTacToeGame.PlaceMarker(2, 2, CellOwners.Human);
            //assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Human);
        }
        [Test]
        public void EvaluateBoardComputerTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();
            //test
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(1, 0, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(2, 0, CellOwners.Computer);
            //assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
        }
        [Test]
        public void AutoPlayComputerTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();
            //test
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();
            //assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
        }

        [Test]
        public void IdentifyHumanWinnerTest()
        {
            //setup
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.PlayerName = "kevin nguyen";
            ticTacToeGame.ResetGrid();
            //setup
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(1, 1, CellOwners.Human);
            ticTacToeGame.PlaceMarker(2, 2, CellOwners.Human);
            ticTacToeGame.EvaluateBoard();
            //assert
            ticTacToeGame.IdentifyWinner().ShouldBe("kevin nguyen");

        }






    }
}
