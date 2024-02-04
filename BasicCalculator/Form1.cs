namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        double total;
        string operation;

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                num2 = double.Parse(textBox1.Text);
                total = num1 + num2;
                textBox1.Text = total.ToString();
            }
            else if (operation == "-")
            {
                num2 = double.Parse(textBox1.Text);
                total = num1 - num2;
                textBox1.Text = total.ToString();
            }
            else if (operation == "*")
            {
                num2 = double.Parse(textBox1.Text);
                total = num1 * num2;
                textBox1.Text = total.ToString();
            }
            else if (operation == "/")
            {
                num2 = double.Parse(textBox1.Text);
                total = num1 / num2;
                textBox1.Text = total.ToString();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }
    }
}
