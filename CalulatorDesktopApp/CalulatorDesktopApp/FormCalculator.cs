namespace CalulatorDesktopApp
{
    public partial class FormCalculator : Form
    {
        string data;
        int length;
        string operation;
        double input1, total = 0, input2=0;
        int initialInput = 0;
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
            initialInput = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
           
            operation = "+";
            SetTextBoxValues();
            GetInputValues();

            Calculate();
            initialInput++;
        }

        private void GetInputValues()
        {
            if (initialInput == 0)
            {
                if (textBoxResult.Text == "")
                {
                    input1 = 0;
                }
                else
                {
                    input1 = Convert.ToDouble(textBoxResult.Text);
                }
            }
            else {
                input2 = Convert.ToDouble(textBoxResult.Text);
            }
            
        }

        private void Calculate()
        {
            if (initialInput == 0)
            {
                if (operation == "+")
                {
                    total = input1 + input2;
                }
                else if (operation == "*")
                {
                    total = input1 * input2;
                }
                else if (operation == "/")
                {
                    total = input1 / input2;
                }
                else if (operation == "-")
                {
                    total = input1 - input2;
                }
            }
            else {
                if (operation == "+")
                {
                    total = total + input2;
                }
                else if (operation == "*")
                {
                    total = total * input2;
                }
                else if (operation == "/")
                {
                    total = total / input2;
                }
                else if (operation == "-")
                {
                    total = total - input2;
                }
            }
            textBoxResult.Text = total.ToString();
            input2 = 0;
        }

        private void SetTextBoxValues()
        {
            if (textBoxResult.Text == "")
            {
                textBoxInput.Text = "0" + operation;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + textBoxResult.Text + operation;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            SetTextBoxValues();
            Calculate();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            SetTextBoxValues();
            Calculate();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            SetTextBoxValues();
            Calculate();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            initialInput = 0;
        }
    }
}
