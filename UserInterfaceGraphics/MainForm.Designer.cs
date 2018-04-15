namespace UserInterfaceGraphics
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameCell2 = new UserInterfaceGraphics.GameCell();
            this.gameCell3 = new UserInterfaceGraphics.GameCell();
            this.gameCell4 = new UserInterfaceGraphics.GameCell();
            this.gameCell5 = new UserInterfaceGraphics.GameCell();
            this.gameCell6 = new UserInterfaceGraphics.GameCell();
            this.gameCell7 = new UserInterfaceGraphics.GameCell();
            this.gameCell9 = new UserInterfaceGraphics.GameCell();
            this.gameCell1 = new UserInterfaceGraphics.GameCell();
            this.gameCell8 = new UserInterfaceGraphics.GameCell();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Human Player";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(104, 47);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(150, 20);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            this.txtPlayerName.Validated += new System.EventHandler(this.txtPlayerName_Validated);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(28, 95);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(145, 62);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start New Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(28, 176);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(145, 62);
            this.btnGoComputer.TabIndex = 3;
            this.btnGoComputer.Text = "Go! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(445, 417);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(526, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.67327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66337F));
            this.tableLayoutPanel1.Controls.Add(this.gameCell2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell8, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(255, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gameCell2
            // 
            this.gameCell2.CellColNo = 1;
            this.gameCell2.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell2.CellRowNo = 0;
            this.gameCell2.Location = new System.Drawing.Point(101, 3);
            this.gameCell2.Name = "gameCell2";
            this.gameCell2.Size = new System.Drawing.Size(94, 93);
            this.gameCell2.TabIndex = 1;
            this.gameCell2.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell2.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell3
            // 
            this.gameCell3.CellColNo = 2;
            this.gameCell3.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell3.CellRowNo = 0;
            this.gameCell3.Location = new System.Drawing.Point(201, 3);
            this.gameCell3.Name = "gameCell3";
            this.gameCell3.Size = new System.Drawing.Size(96, 93);
            this.gameCell3.TabIndex = 2;
            this.gameCell3.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell3.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell4
            // 
            this.gameCell4.CellColNo = 0;
            this.gameCell4.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell4.CellRowNo = 1;
            this.gameCell4.Location = new System.Drawing.Point(3, 102);
            this.gameCell4.Name = "gameCell4";
            this.gameCell4.Size = new System.Drawing.Size(92, 96);
            this.gameCell4.TabIndex = 3;
            this.gameCell4.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell4.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell5
            // 
            this.gameCell5.CellColNo = 1;
            this.gameCell5.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell5.CellRowNo = 1;
            this.gameCell5.Location = new System.Drawing.Point(101, 102);
            this.gameCell5.Name = "gameCell5";
            this.gameCell5.Size = new System.Drawing.Size(94, 96);
            this.gameCell5.TabIndex = 4;
            this.gameCell5.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell5.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell6
            // 
            this.gameCell6.CellColNo = 2;
            this.gameCell6.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell6.CellRowNo = 1;
            this.gameCell6.Location = new System.Drawing.Point(201, 102);
            this.gameCell6.Name = "gameCell6";
            this.gameCell6.Size = new System.Drawing.Size(96, 96);
            this.gameCell6.TabIndex = 5;
            this.gameCell6.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell6.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell7
            // 
            this.gameCell7.CellColNo = 0;
            this.gameCell7.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell7.CellRowNo = 2;
            this.gameCell7.Location = new System.Drawing.Point(3, 204);
            this.gameCell7.Name = "gameCell7";
            this.gameCell7.Size = new System.Drawing.Size(92, 93);
            this.gameCell7.TabIndex = 6;
            this.gameCell7.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell7.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell9
            // 
            this.gameCell9.CellColNo = 2;
            this.gameCell9.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell9.CellRowNo = 2;
            this.gameCell9.Location = new System.Drawing.Point(201, 204);
            this.gameCell9.Name = "gameCell9";
            this.gameCell9.Size = new System.Drawing.Size(96, 93);
            this.gameCell9.TabIndex = 8;
            this.gameCell9.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell9.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell1
            // 
            this.gameCell1.CellColNo = 0;
            this.gameCell1.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell1.CellRowNo = 0;
            this.gameCell1.Location = new System.Drawing.Point(3, 3);
            this.gameCell1.Name = "gameCell1";
            this.gameCell1.Size = new System.Drawing.Size(92, 93);
            this.gameCell1.TabIndex = 0;
            this.gameCell1.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell1.Load += new System.EventHandler(this.gameCell1_Load);
            this.gameCell1.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // gameCell8
            // 
            this.gameCell8.CellColNo = 1;
            this.gameCell8.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell8.CellRowNo = 2;
            this.gameCell8.Location = new System.Drawing.Point(101, 204);
            this.gameCell8.Name = "gameCell8";
            this.gameCell8.Size = new System.Drawing.Size(94, 93);
            this.gameCell8.TabIndex = 7;
            this.gameCell8.GameCellClick += new System.EventHandler(this.GameCellMasterClick);
            this.gameCell8.Click += new System.EventHandler(this.GameCellMasterClick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.Text = "TicTacToe - Kevin Nguyen";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GameCell gameCell2;
        private GameCell gameCell3;
        private GameCell gameCell4;
        private GameCell gameCell5;
        private GameCell gameCell6;
        private GameCell gameCell7;
        private GameCell gameCell8;
        private GameCell gameCell9;
        private GameCell gameCell1;
    }
}

