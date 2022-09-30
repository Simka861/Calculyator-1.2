namespace Calculyator_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "00")
            {
                label1.Text = (sender as Button).Text;
            }
            else
            {
                label1.Text += (sender as Button).Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double Num1 = 0, Num2 = 0, Num3 = 0;

        private void button16_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(label1.Text);
            if (znak == '+')
            {
                Num3 = Num1 + Num2;
                label1.Text = Convert.ToString(Num3);
            }
            else if (znak == '-')
            {
                Num3 = Num1 - Num2;
                label1.Text = Convert.ToString(Num3);
            }
            else if (znak == '*')
            {
                Num3 = Num1 * Num2;
                label1.Text = Convert.ToString(Num3);
            }
            else
            {
                Num3 = Num1 / Num2;
                label1.Text = Convert.ToString(Num3);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "00";
        }

        private void button19_Click(object sender, EventArgs e)// кнопка +.-
        {
            if (label1.Text != "")
            {
                if (label1.Text[0] == '-')
                {
                    label1.Text = label1.Text.Remove(0, 1);
                }
                else { label1.Text = '-' + label1.Text; }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length- 1);
            }
        }

        char znak = '+';
        private void button12_Click(object sender, EventArgs e) // кнопка +
        {
            Num1 = Convert.ToDouble(label1.Text);
            znak = (sender as Button).Text[0];
            label1.Text = "00";
        }
    }
}