using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tetris.Entities;
using Tetris.Entities.Enums;
using System.Drawing.Drawing2D;

namespace Tetris.Forms
{
    public partial class formMainMenu : Form
    {
        public SqlConnection connection = new SqlConnection(@"Persist Security Info=False;Integrated Security=True;Initial Catalog=TetrisDataBase;Data Source=KHOIPRO2K4\SQLEXPRESS01");

        public int defaultDifficulty = 1; // 1: Dễ, 2: Trung bình, 3: Khó
        formOption FormOption = new formOption();
        private string AccountId { get; set; } = null; // tài khoản không đăng nhập với accountId = NULL

        public string GetAccountId()
        {
            return AccountId;
        }
        public string GetName()
        {
            return lblName.Text;
            
        }

        public string GetLevel()
        {
            return lblLevel.Text;
        }

        public void SetPlayer(string accountid)
        {
            AccountId = accountid;

            connection.Open();
            string nameQuery = "";
            if (AccountId != null)
            {
                int temp = Convert.ToInt32(AccountId);
                nameQuery = $"SELECT PlayerName FROM GameAccount  WHERE AccountId = {temp}";
                SqlCommand nameCommand = new SqlCommand(nameQuery, connection);
                lblName.Text = nameCommand.ExecuteScalar().ToString();
            }
            else
            {
                nameQuery = "Guest";
            }
            string levelQuery = "";
            if (AccountId != null)
            {
                int temp = Convert.ToInt32(AccountId);
                levelQuery = $"SELECT TOP 1 Level FROM GameSession  WHERE AccountId = {temp} order by Level DESC";
            }
            else
            {
                levelQuery = $"SELECT TOP 1 Level FROM GameSession  WHERE AccountId is NULL order by Level DESC";
            }
            SqlCommand levelCommand = new SqlCommand(levelQuery, connection);
            lblLevel.Text = levelCommand.ExecuteScalar().ToString();
            connection.Close();
        }
        public formMainMenu()
        {
            InitializeComponent();
            SetPlayer(AccountId);
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            // var frmSignUp = new frmSignUp(this);
            frmSignUp.Closed += (s, args) => this.Close();
            frmSignUp.Show();
            */
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPlay = new formPlay(this);
            formPlay.ShowDialog();

            if (formPlay.DialogResult == DialogResult.No)
            {
                formPlay.Close();
                this.Show();
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHighScores = new formLeaderBoard(this);
            formHighScores.Closed += (s, args) => this.Close();
            formHighScores.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOption.ShowDialog();
            this.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmSignIn = new frmSignIn(this);
            frmSignIn.Closed += (s, args) => this.Close();
            frmSignIn.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát game không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHighScores = new formHighScore(this);
            formHighScores.Show();
        }
    }
        
}
