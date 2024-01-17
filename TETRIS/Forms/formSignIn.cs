using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tetris.Forms
{
    public partial class frmSignIn : Form
    {
        SqlConnection connection = new SqlConnection(@"Persist Security Info=False;Integrated Security=True;Initial Catalog=TetrisDataBase;Data Source=KHOIPRO2K4\SQLEXPRESS01");
        private string playerName = "";
        private string accountId = "";
        private int bestScore = 0;
        private formMainMenu frmMM;
        private bool flag = false;
        public frmSignIn(formMainMenu a)
        {
            InitializeComponent();
            frmMM = a;
            txtUserName.Text = "USERNAME";
            txtPassword.Text = "PASSWORD";
        }

        public void Refresh()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";      
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (flag == true)
                frmMM.SetPlayer(accountId);
            frmMM.Closed += (s, args) => this.Close();
            frmMM.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmSignUp = new frmSignUp(this);
            frmSignUp.Closed += (s, args) => this.Close();
            frmSignUp.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                string query = "select count(*) from GameAccount where UserName='" + txtUserName.Text + "' and " +
                "PassWord='" + txtPassword.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or password", "Error!");
                }
                else
                {
                    MessageBox.Show("You have logged in successfully");
                    SqlCommand command2 = new SqlCommand($"select AccountId from GameAccount where UserName = '{txtUserName.Text}'", connection);
                    accountId = command2.ExecuteScalar().ToString();
                    string fullNameQuery = "SELECT PlayerName FROM GameAccount WHERE UserName='" + txtUserName.Text + "'";
                    SqlCommand fullNameCommand = new SqlCommand(fullNameQuery, connection);
                    playerName = (string)fullNameCommand.ExecuteScalar();
                    flag = true;
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Fill in the blanks!");
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "USERNAME")
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = "USERNAME";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "PASSWORD";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
