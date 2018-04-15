using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBrain;
using CommonFramework.Core;
//Kevin Nguyen
namespace UserInterfaceGraphics
{
    public partial class GameCell : UserControl
    {
        public GameCell()
        {
            InitializeComponent();
        }
        public int CellRowNo { get; set; } = -1;
        public int CellColNo { get; set; } = -1;
        private CellOwners _cellOwner = CellOwners.Error; // this property will change during this assignment

        public CellOwners CellOwner
        {
            get { return _cellOwner; }
            set
            {
                _cellOwner = value;
                switch (value)
                {
                    case CellOwners.Computer:
                        picboxEmoji.Image = Properties.Resources.Player_O;
                        break;
                    case CellOwners.Error:
                        picboxEmoji.Image = Properties.Resources.smiley;
                        break;
                    case CellOwners.Human:
                        picboxEmoji.Image = Properties.Resources.Player_X;
                        break;
                    case CellOwners.Open:
                        picboxEmoji.Image = Properties.Resources.Open;
                        break;
                    default:
                        picboxEmoji.Image = Properties.Resources.smiley;
                        break;
                }
            }
        }

        private void GameCell_Load(object sender, EventArgs e) {}

        public event EventHandler GameCellClick;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameCellClick?.Invoke(this, new EventArgs());
        }
    }
}
