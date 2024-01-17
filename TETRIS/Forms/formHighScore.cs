using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Entities;

namespace Tetris.Forms
{
    public partial class formHighScore : Form
    {
        public formMainMenu frmMM;
        public formHighScore(formMainMenu a)
        {
            frmMM = a;
            InitializeComponent();
            InterfaceDBandGame ServerScoreboard = new InterfaceDBandGame();
            ServerScoreboard.NewScoreBoardData.PlayerName = frmMM.GetName();
            ServerScoreboard.NewScoreBoardData.AccountId = frmMM.GetAccountId();
            ServerScoreboard.read = 1;
            ServerScoreboard.RefreshLocalScoreBoard();
            StringBuilder InitialString = new StringBuilder();
            StringBuilder ScoreString = new StringBuilder();
            StringBuilder TotalTimeString = new StringBuilder();

            for (int i = 0; i < ServerScoreboard.LocalScoreBoardItemsQty(); i++)
            {
                InitialString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).Initial + "\n");
                ScoreString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).Score.ToString() + "\n");
                TotalTimeString.AppendLine(ServerScoreboard.ReadLocalScoreBoard(i).TotalTime.ToString() + "\n");
            }

            labelInitials.Text =  InitialString.ToString();
            labelScore.Text = ScoreString.ToString();
            labelTotalTime.Text = TotalTimeString.ToString();


        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMM.Closed += (s, args) => this.Close();
            frmMM.Show();
        }
    }
}
