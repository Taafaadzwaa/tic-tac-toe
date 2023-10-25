using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            // Create an instance of the new form
            Playing secondForm = new Playing();

            // Show the new form
            secondForm.Show();
        }



        private string player1Name;
        private string player2Name;
        private void buttonStart_Click(object sender, EventArgs e)
        {

            // Get player names from the text boxes
            player1Name = textBox1.Text;
            player2Name = textBox2.Text;

            // Check if both players entered their names
            if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name))
            {
                MessageBox.Show("Both players must enter their names.");
                return;
            }

            // Display the assigned letters
            MessageBox.Show(player1Name + " is assigned 'X' and " + player2Name + " is assigned 'O'.");

            // Disable the text boxes and the "Start Game" button
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            buttonStart.Enabled = false;
        }
    }
}





