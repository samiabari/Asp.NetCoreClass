using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalulatorDesktopApp
{
    public partial class FormCalculator : Form
    {
        string data;
        int length;
        char operation;
        char lastChar;
        int inputFlag = 0;
        double total = 0, input1, input2;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "1";
            lastChar = '1';
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "2";
            lastChar = '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "3";
            lastChar = '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "4";
            lastChar = '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "5";
            lastChar = '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "6";
            lastChar = '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "7";
            lastChar = '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "8";
            lastChar = '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "9";
            lastChar = '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            clearField();
            textBoxResult.Text = textBoxResult.Text + "0";
            lastChar = '0';
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            clearField();
            if (textBoxResult.Text == "")
            {
                textBoxResult.Text = "0";
            }
            textBoxResult.Text = textBoxResult.Text + ".";
            lastChar = '.';
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
            input1 = 0;
            input2 = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (lastChar != '-' && lastChar != '+' && lastChar != '/' && lastChar != '*')
            {
                lastChar = '+';
                operation = '+';
                SetTextBoxValues();
                SetInputValuesNCalculate();

            }
        }

        private void SetInputValuesNCalculate()
        {
            if (inputFlag == 1)
            {
                input2 = Convert.ToDouble(textBoxResult.Text);
                Calculate();
                textBoxResult.Text = total.ToString();
            }
            else
            {

                input1 = Convert.ToDouble(textBoxResult.Text);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (lastChar != '-' && lastChar != '+' && lastChar != '/' && lastChar != '*')
            {
                lastChar = '-';
                operation = '-';
                SetTextBoxValues();
                SetInputValuesNCalculate();
            }
            
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (lastChar != '-' && lastChar != '+' && lastChar != '/' && lastChar != '*')
            {
                lastChar = '*';
                operation = '*';
                SetTextBoxValues();
                SetInputValuesNCalculate();
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (lastChar != '-' && lastChar != '+' && lastChar != '/' && lastChar != '*')
            {
                lastChar = '/';
                operation = '/';
                SetTextBoxValues();
                SetInputValuesNCalculate();
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            
            input2 = Convert.ToDouble(textBoxResult.Text);
            Calculate();
            lastChar = '=';
            SetTextBoxValues();
            
            textBoxResult.Text = total.ToString();
            inputFlag = 0;
        }

        private void Calculate()
        {
            if (inputFlag == 1)
            {
                if (operation == '/')
                {
                    total = input1 / input2;
                }
                else if (operation == '+')
                {
                    total = input1 + input2;
                }
                else if (operation == '-')
                {
                    total = input1 - input2;
                }
                else if (operation == '*')
                {
                    total = input1 * input2;
                }
            }
            else 
            {
                if (operation == '/')
                {
                    total = total / input2;
                }
                else if (operation == '+')
                {
                    total = total + input2;
                }
                else if (operation == '-')
                {
                    total = total - input2;
                }
                else if (operation == '*')
                {
                    total = total * input2;
                }
            }
            
        }

        private void SetTextBoxValues()
        {
            if (inputFlag == 0)
            {
                textBoxInput.Clear();
            }
            if (textBoxResult.Text == "")
            {
                textBoxInput.Text = "0";
            }
            else {
                if (lastChar == '=')
                {
                    textBoxInput.Text = textBoxInput.Text + textBoxResult.Text;
                }
                else {
                    textBoxInput.Text = textBoxInput.Text + textBoxResult.Text + operation.ToString();
                }
                
            }
            
        }


        private void clearField()
        {
            if (lastChar == '*' || lastChar == '+' || lastChar == '-' || lastChar == '/'|| lastChar == '=')
            {
                textBoxResult.Clear();
                inputFlag = 1;
            }
        }
    }
}
