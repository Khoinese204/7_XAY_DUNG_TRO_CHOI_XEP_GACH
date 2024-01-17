
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Entities;

namespace Tetris.Forms
{
    public partial class formLeaderBoard : Form
    {
        public formMainMenu frmMM;

        public formLeaderBoard(formMainMenu a)
        {
            frmMM = a;
            InitializeComponent();
            InterfaceDBandGame ServerScoreboard = new InterfaceDBandGame();
            ServerScoreboard.read = 2;
            ServerScoreboard.RefreshLocalScoreBoard();
            StringBuilder RankString = new StringBuilder();
            StringBuilder NameString = new StringBuilder();
            StringBuilder ScoreString = new StringBuilder();
            StringBuilder LevelString = new StringBuilder();


            for (int i = 0; i < ServerScoreboard.LocalScoreBoardItemsQty(); i++)
            {
                RankString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).Rank + "\n");
                NameString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).PlayerName + "\n");
                ScoreString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).Score.ToString() + "\n");
                LevelString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).Level.ToString() + "\n");
            }

            labelRank.Text = RankString.ToString();
            labelName.Text = NameString.ToString();
            labelScore.Text = ScoreString.ToString();
            labelLevel.Text = LevelString.ToString();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMM.Closed += (s, args) => this.Close();
            frmMM.Show();

        }

    }
}
