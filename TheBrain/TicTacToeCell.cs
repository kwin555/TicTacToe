﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kevin Nguyen
namespace TheBrain
{
    class TicTacToeCell
    {
        /// <summary>
        /// Property indicating the row of the referenced square. (0-2)
        /// </summary>
        public int RowID { get; set; }

        /// <summary>
        /// Property indicating the column of the referenced square. (0-2)
        /// </summary>
        public int ColID { get; set; }

        /// <summary>
        /// Property indicating the owner of a square. (human, computer, open, error)
        /// </summary>
        public CellOwners CellOwner { get; set; } = CellOwners.Open;
    }
}
