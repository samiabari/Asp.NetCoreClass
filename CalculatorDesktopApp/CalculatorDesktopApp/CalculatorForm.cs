namespace CalculatorDesktopApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "1";
            }
            else
            {
                textBoxDataNResult.Text = "1";
            }

        }



        private void buttonBackSpace_Click(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxDataNResult.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "2";
            }
            else
            {
                textBoxDataNResult.Text = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "3";
            }
            else
            {
                textBoxDataNResult.Text = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "4";
            }
            else
            {
                textBoxDataNResult.Text = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "5";
            }
            else
            {
                textBoxDataNResult.Text = "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "6";
            }
            else
            {
                textBoxDataNResult.Text = "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "7";
            }
            else
            {
                textBoxDataNResult.Text = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "8";
            }
            else
            {
                textBoxDataNResult.Text = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "9";
            }
            else
            {
                textBoxDataNResult.Text = "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "0";
            }
            else
            {
                textBoxDataNResult.Text = "0";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + ".";
            }
            else
            {
                textBoxDataNResult.Text = ".";
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "%";
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "/";
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "*";
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "-";
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "+";
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                string s=textBoxDataNResult.Text;

            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }
    }
}
