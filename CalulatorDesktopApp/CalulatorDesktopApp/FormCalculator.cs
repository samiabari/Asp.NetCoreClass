namespace CalulatorDesktopApp
{
    public partial class FormCalculator : Form
    {
        string data;
        int length;
        string operation;
        double total = 0, input1 = 0, input2=0;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + ".";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            data = textBoxResult.Text;
            length = data.Length;
            data = data.Remove(length - 1);
            textBoxResult.Text = data;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxResult.Clear();
            total = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
           
            operation = "+";
            input1 = Convert.ToDouble(textBoxResult.Text);
            SetTextBoxValues();

        }

        private void SetTextBoxValues()
        {
            if (textBoxResult.Text == "")
            {
                textBoxInput.Text = "0";
            }
            textBoxInput.Text = textBoxInput.Text + textBoxResult.Text + operation;
            textBoxResult.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            SetTextBoxValues();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            SetTextBoxValues();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            SetTextBoxValues();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            input2 = Convert.ToDouble(textBoxResult.Text);
            Calculate();
            textBoxResult.Text = total.ToString();
        }

        private void Calculate()
        {
            if (operation == "/")
            {
                total = input1 / input2;
            }
            else if (operation == "+")
            {
                total = input1 + input2;
            }
            else if (operation == "-")
            {
                total = input1 - input2;
            }
            else if (operation == "*")
            {
                total = input1 * input2;
            }
            
        }
    }
}
