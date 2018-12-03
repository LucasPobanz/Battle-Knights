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
    public partial class mapSelection : Form
    {
        private CharacterScreen characterScreenForm;
        private Map1 map1;

        public mapSelection()
        {
            InitializeComponent();
        }

        private void mapSelection_Load(object sender, EventArgs e)
        {

        }

        private void backToCharacterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            characterScreenForm = new CharacterScreen();
            characterScreenForm.Show(this);
        }

        private void playMatchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            map1 = new Map1();
            map1.Show(this);
        }
    }
}
