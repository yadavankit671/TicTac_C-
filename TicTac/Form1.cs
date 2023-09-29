using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class TicTacToe : Form
    {
        public bool player = true;
        public bool no_play = false;
        public int count = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }

        private void play_input(object sender, EventArgs e)
        {
            Button clicked =sender as Button;
            if (clicked.Text==" " && no_play == false)
            {
                clicked.Text = (player == true) ? "O" : "X";
                player = (player == true) ? false : true;
                count++;
                check();
            }
            if (count>8 && no_play == false)
            {
                no_play = true;
                textbox.Text = "GAME OVER !!";
            }
        }
        
         
         public void check() {
            if (button_1x1.Text == button_1x2.Text && button_1x1.Text == button_1x3.Text && !button_1x1.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_2x1.Text == button_2x2.Text && button_2x2.Text == button_2x3.Text && !button_2x1.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_3x1.Text == button_3x2.Text && button_3x2.Text == button_3x3.Text && !button_3x1.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_1x1.Text == button_2x1.Text && button_2x1.Text == button_3x1.Text && !button_1x1.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_1x2.Text == button_2x2.Text && button_2x2.Text == button_3x2.Text && !button_1x2.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_1x3.Text == button_2x3.Text && button_2x3.Text == button_3x3.Text && !button_1x3.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_1x1.Text == button_2x2.Text && button_2x2.Text == button_3x3.Text && !button_1x1.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
            else if (button_1x3.Text == button_2x2.Text && button_2x2.Text == button_3x1.Text && !button_1x3.Text.Contains(" "))
            {
                textbox.Text = (player == true) ? "Winner P2" : "Winner P1";
                no_play = true;
            }
        }
         


        private void input_clear(object sender, EventArgs e)
        {
            button_1x1.Text = " ";
            button_1x2.Text = " ";
            button_1x3.Text = " ";
            button_2x1.Text = " ";
            button_2x2.Text = " ";
            button_2x3.Text = " ";
            button_3x1.Text = " ";
            button_3x2.Text = " ";
            button_3x3.Text = " ";
            textbox.Text = "LET'S PLAY";
            player = true;
            count= 0;
            no_play= false;
        }

        private void no_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
