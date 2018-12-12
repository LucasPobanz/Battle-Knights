using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Test_Build_1
{
    public partial class Form1 : Form
    {
        private CharacterScreen characterScreenForm;
        private Form1 form1;
      
        public Form1()

        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form1 = new Form1();
            //var myPlayer = new System.Media.SoundPlayer();
            //myPlayer.SoundLocation = @"D:\BPA\Battle_Test_Build_1\Scanline.wav";
            //myPlayer.Play();


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            characterScreenForm = new CharacterScreen();
            characterScreenForm.Show(this);
      
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
