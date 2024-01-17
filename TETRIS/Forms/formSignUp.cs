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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tetris.Forms
{
    public partial class frmSignUp : Form
    {
        SqlConnection connection = new SqlConnection(@"Persist Security Info=False;Integrated Security=True;Initial Catalog=TetrisDataBase;Data Source=KHOIPRO2K4\SQLEXPRESS01");
        private frmSignIn frmSignIn;
        public frmSignUp(frmSignIn a)
        {
            InitializeComponent();
            frmSignIn = a;
        }
        private void LoadData()
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput1(txtUserName.Text, txtPassword.Text))
                {
                    if (checkInput2(txtFullName.Text))
                    {
                        if (txtPassword.Text == txtRePassword.Text)
                        {
                            int v1 = isExistUserName(txtUserName.Text);
                            int v2 = isExistFullName(txtFullName.Text);
                            if (v1 != 1)
                            {
                                if (v2 != 1)
                                {
                                    connection.Open();
                                    MessageBox.Show("Register Successfully!");
                                    SqlCommand command = new SqlCommand($"INSERT INTO GameAccount(UserName, PassWord, PlayerName) VALUES('{txtUserName.Text}', '{txtPassword.Text}', '{txtFullName.Text}') SELECT SCOPE_IDENTITY()", connection);
                                    command.ExecuteNonQuery();
                                    SqlCommand command2 = new SqlCommand($"select AccountId from GameAccount where UserName = '{txtUserName.Text}'", connection);
                                    string temp = command2.ExecuteScalar().ToString();
                                    int x = Convert.ToInt32(temp);
                                    SqlCommand _command = new SqlCommand($"INSERT INTO GameSession(AccountId, Scores, TotalTime, Initials, Level) VALUES ({x}, 0, 00:00:00, '', 1) SELECT SCOPE_IDENTITY()", connection);
                                    _command.ExecuteNonQuery();
                                    txtUserName.Text = "";
                                    txtPassword.Text = "";
                                    txtRePassword.Text = "";
                                    txtFullName.Text = "";
                                    connection.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Fullname is used");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username is used");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password does not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Fullname in games must be between 4 and 15 characters long and contain only letters, numbers, underscores and no spaces");
                    }
                }
                else
                {
                    MessageBox.Show("Your Username or Password must be between eight and 30 characters long and contain only letters, numbers, underscores and no spaces");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int isExistUserName(string username)
        {
            connection.Open();
            string query = "select count(*) from GameAccount where UserName = '" + username + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }
        int isExistFullName(string fullname)
        {
            connection.Open();
            string query = "select count(*) from GameAccount where PlayerName = '" + fullname + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }
        bool IsValidString(string input, int minLength, int maxLength)
        {
            if (input.Length >= minLength && input.Length <= maxLength)
            {
                foreach (char c in input)
                {
                    if (!char.IsLetterOrDigit(c) && c != '_')
                    {
                        return false;
                    }
                }
                return !input.Contains(" ");
            }

            return false;
        }
        bool checkInput1(string username, string password)
        {
            int count = 0;
            if (IsValidString(username, 8, 30))
            {
                count++;
            }

            if (IsValidString(password, 8, 30))
            {
                count++;
            }

            if (count == 2)
                return true; 
            return false;
        }
        bool checkInput2(string fullname)
        {
            int count = 0;
            if (IsValidString(fullname, 4, 15))
            {
                count++;
            }
            if (count == 1)
                return true;
            return false;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignIn.Refresh();
            frmSignIn.Closed += (s, args) => this.Close();
            frmSignIn.Show();
        }

    }
}
