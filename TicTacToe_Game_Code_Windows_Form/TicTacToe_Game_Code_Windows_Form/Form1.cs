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
    public partial class Form1 : Form
    {
        public static Player play = new Player();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            play.Player01 = PLTB01.Text;
            play.Player02 = PLTB02.Text;

            if (string.IsNullOrWhiteSpace(PLTB01.Text) || string.IsNullOrWhiteSpace(PLTB02.Text))
            {
                MessageBox.Show("Enter the players name, then click 'Start' button");
            }
            else if (play.Player01 == play.Player02)
            {
                MessageBox.Show("The Names are not to be in Same");
                PLTB01.Clear();
                PLTB02.Clear();
            }
            else if (play.Player01 != play.Player02)
            {
               Tic_Tac_Toe_Game Form = new Tic_Tac_Toe_Game();
                Form.ShowDialog();  
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PLTB01_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PLTB02_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
