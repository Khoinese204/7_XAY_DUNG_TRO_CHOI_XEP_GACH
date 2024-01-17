using System;
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
    public partial class formOption : Form
    {
        public int ChooseLevel { get; private set; } = 1;
        public int ChooseSound { get; private set; } = 1;

        public int ChooseEffect { get; private set; } = 1;
        public static formOption Instance { get; internal set; }

        public formOption()
        {
            InitializeComponent();
            Instance = this;
        }

        private void formOption_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ChooseSound = 1;
            }
            else
            {
                ChooseSound = 2;
            }

            if (checkBox2.Checked)
            {
                ChooseEffect = 1;
            }
            else
            {
                ChooseEffect = 2;
            }

            if (radioEasy.Checked)
            {
                ChooseLevel = 1;
                radioMedium.Checked = false;
                radioHard.Checked = false;
            }
            else if (radioMedium.Checked)
            {
                ChooseLevel = 2;
                radioHard.Checked = false;
                radioEasy.Checked = false;
            }
            else
            {
                ChooseLevel = 3;
                radioMedium.Checked = false;
                radioEasy.Checked = false;
            }

            this.Hide();
        }
        public int GetChooseLevel()
        {
            return ChooseLevel;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
