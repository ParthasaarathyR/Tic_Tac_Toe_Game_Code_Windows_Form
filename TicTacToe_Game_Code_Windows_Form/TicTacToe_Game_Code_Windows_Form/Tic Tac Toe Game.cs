using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe__Windows_Forms_Application_
{
    public partial class Tic_Tac_Toe_Game : Form
    {
        public bool player1_turn = true;
        public int[,] boardValue = new int[3, 3];
        const int X_VALUE = 1;
        const int O_VALUE = 2;

        public Tic_Tac_Toe_Game()
        {
            InitializeComponent();
            restart_matrix();
            player1_turn = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (boardValue[0, 2] == X_VALUE || boardValue[0, 2] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 2] = X_VALUE;
                button3.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 2] = O_VALUE;
                button3.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (boardValue[1, 0] == X_VALUE || boardValue[1, 0] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 0] = X_VALUE;
                button4.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 0] = O_VALUE;
                button4.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void Tic_Tac_Toe_Game_Load(object sender, EventArgs e)
        {
            
        }

        private void P1Label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlLB01_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            restart_matrix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boardValue[0, 0] == X_VALUE || boardValue[0, 0] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 0] = X_VALUE;
                button1.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 0] = O_VALUE;
                button1.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void check_win()
        {
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[i, 0]) == Convert.ToInt32(boardValue[i, 1]) &&
                    Convert.ToInt32(boardValue[i, 1]) == Convert.ToInt32(boardValue[i, 2]) &&
                    Convert.ToInt32(boardValue[i, 1]) != 0)
                {
                    display_win_screen(boardValue[i, 0]);
                    return;
                }
            }

            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[0, i]) == Convert.ToInt32(boardValue[1, i]) &&
                    Convert.ToInt32(boardValue[1, i]) == Convert.ToInt32(boardValue[2, i]) &&
                    Convert.ToInt32(boardValue[2, i]) != 0)
                {
                    display_win_screen(boardValue[1, i]);
                    return;
                }
            }

            if (Convert.ToInt32(boardValue[0, 0]) == Convert.ToInt32(boardValue[1, 1]) &&
                Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 2]) &&
                Convert.ToInt32(boardValue[2, 2]) != 0)
            {
                display_win_screen(boardValue[1, 1]);
                return;
            }
            else if (Convert.ToInt32(boardValue[0, 2]) == Convert.ToInt32(boardValue[1, 1]) &&
              Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 0]) &&
              Convert.ToInt32(boardValue[2, 0]) != 0)
            {
                display_win_screen(boardValue[1, 1]);
                return;
            }

            bool is_completed = true;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    if (boardValue[i, j] == 0)
                        is_completed = false;
            if (is_completed)
            {
                MessageBox.Show("The Match Is Draw.");
                restart_matrix();
            }
        }

        private void display_win_screen(int val)
        {
            if (val == X_VALUE)
            {
                MessageBox.Show("Congrats, | " + Form1.play.Player01.ToUpper() + " | You Won... ");
            }
            else
            {
                MessageBox.Show("Congrats, | " + Form1.play.Player02.ToUpper() + " | You Won... ");
            }

            restart_matrix();
        }

        private void restart_matrix()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    boardValue[i, j] = 0;

            clear_buttons();
            player1_turn = true;
        }

        private void clear_buttons()
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;

            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boardValue[0, 1] == X_VALUE || boardValue[0, 1] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 1] = X_VALUE;
                button2.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 1] = O_VALUE;
                button2.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (boardValue[1, 2] == X_VALUE || boardValue[1, 2] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 2] = X_VALUE;
                button6.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 2] = O_VALUE;
                button6.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (boardValue[1, 1] == X_VALUE || boardValue[1, 1] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1,1] = X_VALUE;
                button5.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 1] = O_VALUE;
                button5.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (boardValue[2, 2] == X_VALUE || boardValue[2, 2] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 2] = X_VALUE;
                button9.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 2] = O_VALUE;
                button9.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (boardValue[2, 1] == X_VALUE || boardValue[2, 1] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 1] = X_VALUE;
                button8.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 1] = O_VALUE;
                button8.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (boardValue[2, 0] == X_VALUE || boardValue[2, 0] == O_VALUE)
            {
                MessageBox.Show("Sorry, The Position was already taken...");
            }
            else if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 0] = X_VALUE;
                button7.ForeColor = Color.Firebrick;
            }
            else if (player1_turn == false)
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 0] = O_VALUE;
                button7.ForeColor = Color.MediumBlue;
            }

            check_win();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player play = new Player();

            if (player1_turn == true)
            {
                PlTB.Text = Form1.play.Player01;
                PlTB.ForeColor = Color.Firebrick;
            }
            else
            {
                PlTB.Text = Form1.play.Player02;
                PlTB.ForeColor = Color.MediumBlue;
            }
        }

        private void PlTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
