namespace CalculatorDesktopApp
{
    public partial class CalculatorForm : Form
    {
        double result = 0;
        double outValue=0;
        string data;
        int length, value;
        string lastData;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                textBoxDataNResult.Text = textBoxDataNResult.Text + "1";
           
        }



        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                data=textBoxDataNResult.Text;
                length = data.Length;
                string trimmedData = data.Remove(length-1);
                textBoxDataNResult.Text =trimmedData;
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxDataNResult.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
                textBoxDataNResult.Text = textBoxDataNResult.Text + "2";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
                textBoxDataNResult.Text = textBoxDataNResult.Text + "3";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
                textBoxDataNResult.Text = textBoxDataNResult.Text + "4";
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
                textBoxDataNResult.Text = textBoxDataNResult.Text + "5";
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
                textBoxDataNResult.Text = textBoxDataNResult.Text + "6";
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
                textBoxDataNResult.Text = textBoxDataNResult.Text + "7";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
                textBoxDataNResult.Text = textBoxDataNResult.Text + "8";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           textBoxDataNResult.Text = textBoxDataNResult.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
                textBoxDataNResult.Text = textBoxDataNResult.Text + "0";
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
                data = textBoxDataNResult.Text;
                length = data.Length;
                lastData = Convert.ToString(data[length - 1]);
                if (int.TryParse(lastData, out value))
                {
                    textBoxDataNResult.Text = textBoxDataNResult.Text + "%";
                }
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                data = textBoxDataNResult.Text;
                length = data.Length;
                lastData = Convert.ToString(data[length - 1]);
                if (int.TryParse(lastData, out value))
                {
                    textBoxDataNResult.Text = textBoxDataNResult.Text + "/";
                }
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                data = textBoxDataNResult.Text;
                length = data.Length;
                lastData = Convert.ToString(data[length - 1]);
                if (int.TryParse(lastData, out value))
                {
                    textBoxDataNResult.Text = textBoxDataNResult.Text + "*";
                }
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                data = textBoxDataNResult.Text;
                length = data.Length;
                lastData = Convert.ToString(data[length - 1]);
                if (int.TryParse(lastData, out value))
                {
                    textBoxDataNResult.Text = textBoxDataNResult.Text + "-";
                }
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                data = textBoxDataNResult.Text;
                length = data.Length;
                lastData = Convert.ToString(data[length - 1]);
                if (int.TryParse(lastData, out value))
                {
                    textBoxDataNResult.Text = textBoxDataNResult.Text + "+";
                }
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (textBoxDataNResult.Text != string.Empty)
            {
                textBoxDataNResult.Text = "";
            }
            else
            {
                textBoxDataNResult.Text = "";
            }
        }
    }
}
