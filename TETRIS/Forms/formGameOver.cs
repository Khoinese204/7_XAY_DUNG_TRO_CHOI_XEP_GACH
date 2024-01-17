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
    public partial class formGameOver : Form
    {
        public formGameOver()
        {
            InitializeComponent();
        }

        public void Result(string name, string score, string time)
        {
            label5.Text = name;
            label6.Text = score + " pts";
            label7.Text = time;
        }

        private void ButtonYes_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void ButtonNo_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
