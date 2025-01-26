namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int numero=0;
        char jogadorAtual = 'X';
        int maisum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbltext1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reset_click(object sender, EventArgs e)
        {
            jogadorAtual = 'X';
            numero = 0;
            b1.Enabled = true; b1.Text = "";
            b2.Enabled = true; b2.Text = "";
            b3.Enabled = true; b3.Text = "";
            b4.Enabled = true; b4.Text = "";
            b5.Enabled = true; b5.Text = "";
            b6.Enabled = true; b6.Text = "";
            b7.Enabled = true; b7.Text = "";
            b8.Enabled = true; b8.Text = "";
            b9.Enabled = true; b9.Text = "";


        }
        private void button_click(object sender, EventArgs e)
        {
            
            Button button = sender as Button;
            button.Enabled = false;
            if (jogadorAtual == 'X')
            {
                button.Text = "X";
                jogadorAtual = 'O';
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"O jogador X ganhou!");
                    maisum = int.Parse(label4.Text);
                    label4.Text = Convert.ToString(maisum +1 );
                    reset_click(sender,e);
                }

                else if (numero == 8)
                {
                    MessageBox.Show("Draw!");
                    reset_click(sender, e);
                }


            }
            else if (jogadorAtual == 'O')
            {
                button.Text = "O";
                jogadorAtual = 'X';
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"O jogador O ganhou!");
                    maisum = int.Parse(label5.Text);
                    label5.Text = Convert.ToString(maisum +1 );
                    reset_click(sender, e);
                }
                else if (numero == 8)
                {
                    MessageBox.Show("Draw!");
                    reset_click(sender, e);

                }
            }
            numero++;


            
        }
    }
}
