namespace GraphInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else
            {
                //notifyIcon1.Text = "Nohing to remove";
                //notifyIcon1.BalloonTipText = "Nohing to remove";
                //notifyIcon1.Icon = SystemIcons.Information;
                //// ³���������� �����������
                //notifyIcon1.ShowBalloonTip(1000);
                MessageBox.Show("Nohing to remove");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Nohing to remove");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {

        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMC_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
    }
}