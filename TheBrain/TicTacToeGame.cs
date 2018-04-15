using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kevin Nguyen
namespace TheBrain
{
    public class TicTacToeGame
    {
        ///<summary>
        /// This collection of collections will be used to evaluate winning combinations
        /// </summary>
        private Collection<Collection<TicTacToeCell>> _winningCombinations;
        ///<summary>
        /// the collection of 9 possible moves, in order of good-ness
        /// center cell, corner cell, side cell
        /// </summary>
        private Collection<TicTacToeCell> _goodNextMove;
        ///<summary>
        ///public property to hold teh human player name and initialize the property to "human"
        ///</summary>
        public string PlayerName { get; set; } = "Human";
        ///<summary>
        ///This class defines a set of cells
        /// </summary>
        private Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();

        ///<summary>
        ///property indicating the game winner. this property must be reset
        ///to SquareOwners,Open whenever the game is reset. the value of the 
        ///winner only chages when a winner is declared.
        /// </summary>
        public CellOwners Winner { get; private set; } = CellOwners.Error;

        ///<summary>
        ///TicTacToeGame Contructor.
        /// </summary>
        public TicTacToeGame()
        {

        }

        ///<summary>
        ///a medthod to reset the in-memory grid
        /// </summary>
        public void ResetGrid()
        {
            _winningCombinations = null;
            _goodNextMove = null;

            _ticTacToeCells.Clear(); // resets the collection to empty
            Winner = CellOwners.Open;

         

            for (var rowNo = 0; rowNo < 3; rowNo ++)
            {
                for (var colNo = 0; colNo < 3; colNo ++)
                {
                    // this will create 9 cells - rows 0-2 and col 0-2
                    var ticTacToeCell = new TicTacToeCell
                    {
                        RowID = rowNo,
                        ColID = colNo
                    };
                    _ticTacToeCells.Add(ticTacToeCell);
                }
            }
            _goodNextMove = new Collection<TicTacToeCell>()
            {
                _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID ==1),
                _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID ==0),
                _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID ==2),
                _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID ==0),
                _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID ==2),
                _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID ==1),
                _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID ==0),
                _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID ==2),
                _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID ==1)
            };

   
            _winningCombinations = new Collection<Collection<TicTacToeCell>>()
            {
                new Collection<TicTacToeCell>() // loading the first row {
                {
                    // reference to these objects is in the collection - not the new ones!
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 0),
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 2),
                },
                new Collection<TicTacToeCell>()// loading the second row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 0),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 2),
                },
                new Collection<TicTacToeCell>()// loading the third row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 0),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 2),
                },
                new Collection<TicTacToeCell>()// loading the first column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 0),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 0),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 0),
                },
                new Collection<TicTacToeCell>()// loading the second column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 1),
                },
                new Collection<TicTacToeCell>()// loading the third column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 2),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 2),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 2),
                },
                new Collection<TicTacToeCell>()// loading the first diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 0),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 2),
                },
                new Collection<TicTacToeCell>()// loading the first diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID == 0 && tttc.ColID == 2),
                    _ticTacToeCells.First(tttc => tttc.RowID == 1 && tttc.ColID == 1),
                    _ticTacToeCells.First(tttc => tttc.RowID == 2 && tttc.ColID == 0),
                }
            };
        }

        ///<summary>
        ///a method to place the marker for the human (or computer).
        /// </summary>
        public void PlaceMarker(int rowID, int colID, CellOwners cellOwner)
        {
            var targetCell = _ticTacToeCells
            .FirstOrDefault(tttc => tttc.RowID == rowID && tttc.ColID == colID);
            // if the targetCell is not null (meaning it was located), then
            // change the owner as specified
            if (targetCell != null)
            {
                if (targetCell.CellOwner != CellOwners.Open)
                {
                    return;
                }

                //these will be arguments used when the event is fired
                targetCell.CellOwner = cellOwner;
                var eventArgs = new MarkerChangedArgs(rowID, colID, cellOwner);
                //bubble the event up to the parent ( Only if the parent is listening )
                this.MarkerChanged?.Invoke(this,eventArgs);

            }

        }

        ///<summary>
        ///a method to place the marker foor the human (or computer)
        /// </summary>
        public CellOwners IdentifyMarker(int rowID, int colID)
        {
            var targetCell = _ticTacToeCells
                .FirstOrDefault(tttc => tttc.RowID == rowID && tttc.ColID == colID);
        
            /*
            if (targetCell == null)
                return CellOwners.Error;
            else
                return targetCell.CellOwner;
            */
            var returnValue = (targetCell == null) ? CellOwners.Error : targetCell.CellOwner;
            //var returnValue = targetCell?.CellOwner ?? CellOwners.Error;
            return returnValue;
            
        }

        ///<summary>
        ///a method to indicate the auto-play by the computer
        /// </summary>
        public void AutoPlayComputer()
        {
            
            //don't play if a winner has already been declared
            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;
            /*
             * first check for a needed blocking action in rows, columns, or diagonals
             * the blocking action must occur if TWO cells are CellOwners.Human and the
             * third cell is CellOwners.Open
             * Use the PlaceMarker to lay-down the computer's move
             */
            //checking for possible winning moves by computer
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if ((combination[1].CellOwner == CellOwners.Computer) &&
                        (combination[2].CellOwner == CellOwners.Computer))
                    {
                        PlaceMarker(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Computer) &&
                        (combination[2].CellOwner == CellOwners.Computer))
                    {
                        PlaceMarker(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Computer) &&
                        (combination[1].CellOwner == CellOwners.Computer))
                    {
                        PlaceMarker(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }
            // checking for possible winning move by the Human
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if ((combination[1].CellOwner == CellOwners.Human) &&
                        (combination[2].CellOwner == CellOwners.Human))
                    {
                        PlaceMarker(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Human) &&
                        (combination[2].CellOwner == CellOwners.Human))
                    {
                        PlaceMarker(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Human) &&
                        (combination[1].CellOwner == CellOwners.Human))
                    {
                        PlaceMarker(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }
            foreach (var nextMove in _goodNextMove)
            {
                if (nextMove.CellOwner == CellOwners.Open)
                {
                    PlaceMarker(nextMove.RowID, nextMove.ColID, CellOwners.Computer);
                    return;
                }
            }
            /*           //Check each row
                       for (var rowNo = 0; rowNo < 3; rowNo++)
                       {
                           //checking row if the first cell is open
                           if (IdentifyMarker(rowNo, 0) == CellOwners.Open)
                           {
                               if ((IdentifyMarker(rowNo, 1) == CellOwners.Human) &&
                                   (IdentifyMarker(rowNo, 2) == CellOwners.Human))
                               {
                                   PlaceMarker(rowNo,0,CellOwners.Computer);
                                   return;
                               }
                           }
                           //checking row if the second cell is open
                           if (IdentifyMarker(rowNo, 1) == CellOwners.Open)
                           {
                               if ((IdentifyMarker(rowNo, 0) == CellOwners.Human) &&
                                   (IdentifyMarker(rowNo, 2) == CellOwners.Human))
                               {
                                   PlaceMarker(rowNo, 1, CellOwners.Computer);
                                   return;
                               }
                           }
                           //checking row if the third cell is open
                           if (IdentifyMarker(rowNo, 2) == CellOwners.Open)
                           {
                               if ((IdentifyMarker(rowNo, 0) == CellOwners.Human) &&
                                   (IdentifyMarker(rowNo, 1) == CellOwners.Human))
                               {
                                   PlaceMarker(rowNo, 2, CellOwners.Computer);
                                   return;
                               }
                           }
                       }
                       //Check each col
                       for (var colNo = 0; colNo < 3; colNo++)
                       {
                           //checking row if the first cell is open
                           if (IdentifyMarker(0, colNo) == CellOwners.Open)
                           {
                               if ((IdentifyMarker(1, colNo) == CellOwners.Human) &&
                                   (IdentifyMarker(2, colNo) == CellOwners.Human))
                               {
                                   PlaceMarker(0, colNo, CellOwners.Computer);
                               }
                           }
                           //checking row if the second cell is open
                           if (IdentifyMarker(1, colNo) == CellOwners.Open)
                           {
                               if ((IdentifyMarker(0, colNo) == CellOwners.Human) &&
                                   (IdentifyMarker(2, colNo) == CellOwners.Human))
                               {
                                   PlaceMarker(1, colNo, CellOwners.Computer);
                               }
                           }
                           //checking row if the third cell is open
                           if (IdentifyMarker(2, colNo) == CellOwners.Open)
                           {
                               if ((IdentifyMarker(0, colNo) == CellOwners.Human) &&
                                   (IdentifyMarker(1, colNo) == CellOwners.Human))
                               {
                                   PlaceMarker(2, colNo, CellOwners.Computer);
                               }
                           }
                       }

                       //FirstDiagonal - if the top-left is empty
                       if (IdentifyMarker(0, 0) == CellOwners.Open)
                       {
                           if ((IdentifyMarker(1, 1) == CellOwners.Human) &&
                               (IdentifyMarker(2, 2) == CellOwners.Human))
                           {
                               PlaceMarker(0,0,CellOwners.Computer);
                               return;
                           }
                       }
                       //second Diagonal - ifthe top right cell is empty
                       if (IdentifyMarker(0, 2) == CellOwners.Open)
                       {
                           if ((IdentifyMarker(1, 1) == CellOwners.Human) &&
                               (IdentifyMarker(2, 0) == CellOwners.Human))
                           {
                               PlaceMarker(0, 2, CellOwners.Computer);
                               return;
                           }
                       }
                       //FirstDiagonal - if the bottom right is empty
                       if (IdentifyMarker(2, 2) == CellOwners.Open)
                       {
                           if ((IdentifyMarker(0, 0) == CellOwners.Human) &&
                               (IdentifyMarker(1, 1) == CellOwners.Human))
                           {
                               PlaceMarker(2, 2, CellOwners.Computer);
                               return;
                           }
                       }
                       //second diagonal - if the the bottom left cell is empty
                       if (IdentifyMarker(2, 0) == CellOwners.Open)
                       {
                           if ((IdentifyMarker(0, 2) == CellOwners.Human) &&
                               (IdentifyMarker(1, 1) == CellOwners.Human))
                           {
                               PlaceMarker(0, 2, CellOwners.Computer);
                               return;
                           }
                       }
                       //check both diagonals when the center cell is empty
                       if (IdentifyMarker(1, 1) == CellOwners.Open)
                       {
                           if (((IdentifyMarker(0, 2) == CellOwners.Human) &&
                               (IdentifyMarker(2, 0) == CellOwners.Human)) ||
                               ((IdentifyMarker(0, 0) == CellOwners.Human) &&
                               (IdentifyMarker(2, 2) == CellOwners.Human)))
                           {
                               PlaceMarker(1, 1, CellOwners.Computer);
                               return;
                           }
                       }
                       //play the center sauare if empty
                       if (IdentifyMarker(1,1) == CellOwners.Open)
                       {
                           PlaceMarker(1, 1, CellOwners.Computer);
                           return;
                       }
                       //play a corner square if empty
                       if (IdentifyMarker(0, 0) == CellOwners.Open)
                       {
                           PlaceMarker(0, 0, CellOwners.Computer);
                           return;
                       }
                       if (IdentifyMarker(2, 2) == CellOwners.Open)
                       {
                           PlaceMarker(2, 2, CellOwners.Computer);
                           return;
                       }
                       if (IdentifyMarker(0, 2) == CellOwners.Open)
                       {
                           PlaceMarker(0, 2, CellOwners.Computer);
                           return;
                       }
                       if (IdentifyMarker(2, 0) == CellOwners.Open)
                       {
                           PlaceMarker(2, 0, CellOwners.Computer);
                           return;
                       }

                       //otherwise, play any open cell 
                       var firstEmptyCell = _ticTacToeCells
                           .FirstOrDefault(tttc => tttc.CellOwner == CellOwners.Open);
                       if (firstEmptyCell != null)
                       {
                           PlaceMarker(firstEmptyCell.RowID, firstEmptyCell.ColID, CellOwners.Computer);
                           return;
                       }*/
        }
        ///<summary>
        ///a emthod to check for a winner
        /// </summary>
        /// <return>true if a winner has been identified</return>
        public bool EvaluateBoard()
        {
            //loop through all 8 winning combinations
            //remember: _winningCombinations is a ollection of collections of tic tac toecell
            foreach (var combination in _winningCombinations)
            {
                var firstCell = combination[0];

                if ((firstCell.CellOwner != CellOwners.Computer) &&
                    (firstCell.CellOwner != CellOwners.Human)) continue;

                if((firstCell.CellOwner != combination[1].CellOwner ) ||
                   (firstCell.CellOwner != combination[2].CellOwner)) continue;

                Winner = firstCell.CellOwner;
                return true;
            }

            return false;
        }

        ///<summary>
        ///a method which returns a string to check for a winner or draw
        /// </summary>
        /// <return>the name of the winner</return>
        public string IdentifyWinner()
        {
            switch (Winner)
            {
                case CellOwners.Computer:
                    return "Computer";
                case CellOwners.Human:
                    return PlayerName == "" ? "Unamed Human" : PlayerName;
                case CellOwners.Open:
                    return string.Empty;
                default:
                    return "Error";
            }
        }
        /// <inheritdoc />
        /// <summary>
        /// defines the parameters that are returned to the parent form when the event is triggered
        /// </summary>
        public class MarkerChangedArgs : EventArgs
        {
            public MarkerChangedArgs(int rowID, int colID, CellOwners cellOwner)
            {
                RowID = rowID;
                ColID = colID;
                CellOwner = cellOwner;
            }
            public int RowID { get; }
            public int ColID { get; }
            public CellOwners CellOwner { get; }
        }
        /// <summary>
        /// this delegate defines the event (and includes the parameters from above)
        /// </summary>
        /// <param name="sender">normal event object self reference</param>
        /// <param name="e">row, column, and owner of a marker (square)</param>
        public delegate void MarkerChangedHandler(object sender, MarkerChangedArgs e);
        /// <summary>
        /// The exposed event to the MainForm
        /// </summary>
        public event MarkerChangedHandler MarkerChanged;
    }
}
