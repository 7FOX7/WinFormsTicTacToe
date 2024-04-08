using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvgeniiKhe_Assignment05
{
    public partial class IntroPage : Form
    {
        public bool OpenMainMenuPage { get; private set; }
        public IntroPage()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            OpenMainMenuPage = true;
            Close(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
