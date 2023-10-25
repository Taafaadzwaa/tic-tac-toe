using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Playing : Form
    {

        bool turn = true;
        int turn_count = 0;



        public Playing()
        {
            InitializeComponent();
        }

        private void Playing_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {

                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkforwinner();
        }

        private void checkforwinner()
        {
            bool winner = false;

            //horizontalcheck
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {

                winner = true;
            }

            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {

                winner = true;
            }


            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            {

                winner = true;
            }
            //Vertical check
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {

                winner = true;
            }

            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {

                winner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {

                winner = true;
            }
            //diagonal check

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {

                winner = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
            {

                winner = true;
            }

            if (winner)
            {
                disablebutton();
                string w = " ";
                if (turn)
                {
                    w = "O";
                }
                else
                {
                    w = "X";
                }
                MessageBox.Show(w + " WON !!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show(" Well played . Its a DRAW !");
                }
            }
        }


        private void disablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {


            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            catch { }

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This TIC-TAC-TOE Game was Devloped by Tafadzwa Chipangura.October 4-5 2023");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
