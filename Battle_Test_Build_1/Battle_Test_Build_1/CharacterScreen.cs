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
    public partial class CharacterScreen : Form
    {
        private Form1 form1;
        private Options options;
        private mapSelection mapSelection;
        
        public CharacterScreen()
        {
            InitializeComponent();
        }

        private void backToTitleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 = new Form1();
            form1.Show();
        }

        private void optionBtn_Click(object sender, EventArgs e)
        {
            options = new Options();
            options.Show(this);

        }

        private void CharacterScreen_Load(object sender, EventArgs e)
        {

        }

        private void mapBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mapSelection = new mapSelection();
            mapSelection.Show(this);

        }
    }
}
