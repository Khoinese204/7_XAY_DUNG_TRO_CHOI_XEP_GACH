﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris.Forms
{
    public partial class frmLevelUp : Form
    {
        public frmLevelUp(int level)
        {
            InitializeComponent();
            labelLevelUp.Text = level.ToString();
        }
        private void btnClick_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
