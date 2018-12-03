using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Test_Build_1
{
    public partial class Options : Form
    {
        public string numberOfLives;
        public string gameMode;
       

        public Options()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            this.numericUpDown1.Maximum = 10; //limits max lives to ten
            this.numericUpDown1.Minimum = 1; // limits minimum lives to 1

            numberOfLives = numericUpDown1.ToString();
        }

        private void backToCharacterScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           

        }

        private void timeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            LivesChkBox.Checked = false;
            gameMode = "Time";
        }

        private void LivesChkBox_CheckedChanged(object sender, EventArgs e)
        {
            timeChkBox.Checked = false;
            gameMode = "Lives";
        }
    }
}
