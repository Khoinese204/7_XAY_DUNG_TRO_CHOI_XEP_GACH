using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris.Forms
{
    public partial class frmCongratulation : Form
    {
        public string intials = "";
        public frmCongratulation(int scores)
        {
            InitializeComponent();
            labelScores.Text = scores.ToString();
        }
        
        private void btnClick_Click(object sender, EventArgs e)
        {
            intials = textBox1.Text;
            this.Close();

        }
    }
}
