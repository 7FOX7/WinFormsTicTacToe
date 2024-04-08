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
    public partial class MainMenuPage : Form
    {
        int numOfMovesRemaining = 9; 
        char playerSign = 'X';
        bool playerO_Wins = false;
        bool playerX_Wins = false;
        bool draw = false;
        bool newGameRequest = false;
        int numOfWins_X = 0;
        int numOfWins_O = 0; 
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblStatistics_Click(object sender, EventArgs e)
        {

        }

        private void txtMovesRemaining_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMovesRemain_Click(object sender, EventArgs e)
        {

        }

        //private void btnCell_01_Click(object sender, EventArgs e)
        //{

        //}

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;

            numOfMovesRemaining--;
            // Print the number of moves remaining: 
            txtMovesRemain.Text = numOfMovesRemaining.ToString();

            if (playerSign == 'O')
            {
                bt.BackColor = Color.Blue;
                bt.Text = "O";

                // Checking for Horizontal: 
                if ((btnCell_01.Text == btnCell_02.Text && btnCell_02.Text == btnCell_03.Text && btnCell_02.Text == "O") ||
                    (btnCell_04.Text == btnCell_05.Text && btnCell_05.Text == btnCell_06.Text && btnCell_05.Text == "O") ||
                    (btnCell_07.Text == btnCell_08.Text && btnCell_08.Text == btnCell_09.Text && btnCell_08.Text == "O") ||
                // Checking for Diagonal: 
                    (btnCell_01.Text == btnCell_05.Text && btnCell_05.Text == btnCell_09.Text && btnCell_05.Text == "O") ||
                    (btnCell_03.Text == btnCell_05.Text && btnCell_05.Text == btnCell_07.Text && btnCell_05.Text == "O") ||
                // Checking for Vertical: 
                    (btnCell_01.Text == btnCell_04.Text && btnCell_04.Text == btnCell_07.Text && btnCell_04.Text == "O") ||
                    (btnCell_02.Text == btnCell_05.Text && btnCell_05.Text == btnCell_08.Text && btnCell_05.Text == "O") ||
                    (btnCell_03.Text == btnCell_06.Text && btnCell_06.Text == btnCell_09.Text && btnCell_06.Text == "O"))
                {
                    numOfWins_O++;
                    txtPlayerO_Wins.Text = numOfWins_O.ToString();
                    playerO_Wins = true; 
                    MessageBox.Show($"Player '{playerSign}' wins!", "Winner Detected");
                    Reset();
                    playerO_Wins = false;
                }

                // Checking for Draw: 
                else if (numOfMovesRemaining == 0)
                {
                    draw = true; 
                    MessageBox.Show("Draw!", "No Winner");
                    Reset();
                    draw = false; 
                }

                else
                {
                    playerSign = 'X';
                    txtTurn.Text = $"Player {playerSign}";
                }
            }

            else if (playerSign == 'X')
            {
                bt.BackColor = Color.Red;
                bt.Text = "X";

                // Checking for Horizontal: 
                if ((btnCell_01.Text == btnCell_02.Text && btnCell_02.Text == btnCell_03.Text && btnCell_02.Text == "X") ||
                    (btnCell_04.Text == btnCell_05.Text && btnCell_05.Text == btnCell_06.Text && btnCell_05.Text == "X") ||
                    (btnCell_07.Text == btnCell_08.Text && btnCell_08.Text == btnCell_09.Text && btnCell_08.Text == "X") ||
                // Checking for Diagonal: 
                    (btnCell_01.Text == btnCell_05.Text && btnCell_05.Text == btnCell_09.Text && btnCell_05.Text == "X") ||
                    (btnCell_03.Text == btnCell_05.Text && btnCell_05.Text == btnCell_07.Text && btnCell_05.Text == "X") ||
                // Checking for Vertical:                                                                            
                    (btnCell_01.Text == btnCell_04.Text && btnCell_04.Text == btnCell_07.Text && btnCell_04.Text == "X") ||
                    (btnCell_02.Text == btnCell_05.Text && btnCell_05.Text == btnCell_08.Text && btnCell_05.Text == "X") ||
                    (btnCell_03.Text == btnCell_06.Text && btnCell_06.Text == btnCell_09.Text && btnCell_06.Text == "X"))
                {
                    numOfWins_X++;
                    txtPlayerX_Wins.Text = numOfWins_X.ToString();
                    playerX_Wins = true; 
                    MessageBox.Show($"Player '{playerSign}' wins!", "Winner");
                    Reset();
                    playerX_Wins = false; 
                }

                // Checking for Draw: 
                else if(numOfMovesRemaining == 0)
                {
                    draw = true; 
                    MessageBox.Show("Draw!", "No Winner");
                    Reset();
                    draw = false; 
                }

                // switch sign if it is still game mode
                else
                {
                    playerSign = 'O';
                    txtTurn.Text = $"Player {playerSign}";
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; 
            result = MessageBox.Show("Are you sure?", "Start a new Game", MessageBoxButtons.YesNo); 
            
            if(result == DialogResult.Yes) 
            {
                newGameRequest = true; 
                Reset();
                newGameRequest = false; 
            }
            else
            {
                return; 
            }
        }

        private void Reset()
        {
            if(playerO_Wins == true || playerX_Wins == true || newGameRequest == true)
            {
                playerSign = 'X'; 
            }
            else if(draw)
            {
                playerSign = 'O';   // 'O' goes first only in case of draw. 
            }

            pnlGameBoard.Enabled = true;
            numOfMovesRemaining = 9;
            txtMovesRemain.Text = numOfMovesRemaining.ToString();
            btnCell_01.Enabled = true; btnCell_01.Text = ""; btnCell_01.BackColor = Color.LightGray;
            btnCell_02.Enabled = true; btnCell_02.Text = ""; btnCell_02.BackColor = Color.LightGray;
            btnCell_03.Enabled = true; btnCell_03.Text = ""; btnCell_03.BackColor = Color.LightGray;
            btnCell_04.Enabled = true; btnCell_04.Text = ""; btnCell_04.BackColor = Color.LightGray;
            btnCell_05.Enabled = true; btnCell_05.Text = ""; btnCell_05.BackColor = Color.LightGray;
            btnCell_06.Enabled = true; btnCell_06.Text = ""; btnCell_06.BackColor = Color.LightGray;
            btnCell_07.Enabled = true; btnCell_07.Text = ""; btnCell_07.BackColor = Color.LightGray;
            btnCell_08.Enabled = true; btnCell_08.Text = ""; btnCell_08.BackColor = Color.LightGray;
            btnCell_09.Enabled = true; btnCell_09.Text = ""; btnCell_09.BackColor = Color.LightGray;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close(); 
            }
            else
            {
                return;
            }
        }

        private void txtPlayerO_Wins_TextChanged(object sender, EventArgs e)
        {
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionsPage newForm = new InstructionsPage();
            newForm.ShowDialog(); 
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsPage newForm = new CreditsPage();
            newForm.ShowDialog();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAQPage newForm = new FAQPage();
            newForm.ShowDialog(); 
        }

        private void tutorialsAndGuidesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TutorialsAndGuidesPage newForm = new TutorialsAndGuidesPage();
            newForm.ShowDialog(); 
        }
        // if X/O wins - x goes first
        // if in the first round there is a draw, in the second round 'O' starts go first 
        // if in the second round player x or player o wins, player x starts go first again 
        // if in both rounds there is a draw - 0 goes 
    }
}
