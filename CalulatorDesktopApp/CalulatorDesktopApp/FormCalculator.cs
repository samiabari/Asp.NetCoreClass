namespace CalulatorDesktopApp
{
    public partial class FormCalculator : Form
    {
        string data;
        int length;
        string lastString;
        string operation;
        double input, total = 0;
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
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            textBoxInput.Text = textBoxResult.Text + "+";
        }
    }
}
