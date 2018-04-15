using System;
using CommonFramework.Core;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TheBrain;
// Kevin Nguyen
namespace UserInterfaceGraphics
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private TicTacToeGame _ticTacToeGame = new TicTacToeGame();


        private void Mainform_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.MarkerChanged += this.MarkerChangedHandler;
            EnableControls(false);
        }

        void EnableControls(bool setControlsEnabled)
        {
            foreach (var control in this.Controls)
            {
                switch (control)
                {
                    case Button btn when (btn.Name != "btnClose" && btn.Name != "btnAbout"):
                        btn.Enabled = setControlsEnabled;
                        break;
                    case TableLayoutPanel pnl:
                        pnl.Enabled = setControlsEnabled;
                        break;
                    default:
                        break;
                }
            }
        }

        void EvaluateAndAnnounceWinner()
        {
            if (_ticTacToeGame.EvaluateBoard())
            {
                MessageBox.Show(
                    $"The Winner is {_ticTacToeGame.IdentifyWinner()}",
                    "Tic Tac Toe Winner",
                    MessageBoxButtons.OK);

            }
        }

        private void MarkerChangedHandler(object sender, TheBrain.TicTacToeGame.MarkerChangedArgs e)
        {      
            foreach (var item in this.tableLayoutPanel1.Controls)
            {
                if (!(item is GameCell gameCell)) continue;
                if ((gameCell.CellRowNo != e.RowID) || (gameCell.CellColNo != e.ColID)) continue;
                gameCell.CellOwner = e.CellOwner;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBoxTicTactoe();
            aboutBox.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;
            if (_ticTacToeGame.Winner == CellOwners.Open)
            {
                _ticTacToeGame.AutoPlayComputer();
                EvaluateAndAnnounceWinner();
            }
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            _ticTacToeGame.PlayerName = txtPlayerName.Text;
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            var nameIsValid = (txtPlayerName.TextLength >= 2);
            EnableControls(nameIsValid);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _ticTacToeGame.ResetGrid();
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is GameCell gameCell)
                {
                    gameCell.CellOwner = CellOwners.Open;
                }
            }
            /*we use using the Brain to use references to the DLL located in that cs file
             * we create a local varaible with class TicTacToeGame from theBrain cs file and name it _tictacToeGame
             * since _ticTacToeGame is of class TicTacToe, I can use the method Reset Grid found in the brain's TicTacToe class
             * 
             */
        }

        private void GameCellMasterClick(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;
            var gameCell = sender as GameCell;
            if (gameCell == null) return;
            _ticTacToeGame.PlaceMarker(gameCell.CellRowNo, gameCell.CellColNo, CellOwners.Human);
            EvaluateAndAnnounceWinner();
        }

        private void gameCell1_Load(object sender, EventArgs e)
        {

        }
    }
}
