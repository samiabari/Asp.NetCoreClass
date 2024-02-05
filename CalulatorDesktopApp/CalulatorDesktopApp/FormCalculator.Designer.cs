namespace CalulatorDesktopApp
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            labelInput = new Label();
            labelResult = new Label();
            textBoxInput = new TextBox();
            textBoxResult = new TextBox();
            buttonC = new Button();
            buttonCE = new Button();
            buttonPoint = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEqual = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 248);
            button1.Name = "button1";
            button1.Size = new Size(52, 52);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 248);
            button2.Name = "button2";
            button2.Size = new Size(52, 52);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(131, 248);
            button3.Name = "button3";
            button3.Size = new Size(52, 52);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 315);
            button4.Name = "button4";
            button4.Size = new Size(52, 52);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(70, 315);
            button5.Name = "button5";
            button5.Size = new Size(52, 52);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(131, 315);
            button6.Name = "button6";
            button6.Size = new Size(52, 52);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 380);
            button7.Name = "button7";
            button7.Size = new Size(52, 52);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(70, 380);
            button8.Name = "button8";
            button8.Size = new Size(52, 52);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(131, 380);
            button9.Name = "button9";
            button9.Size = new Size(52, 52);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(189, 315);
            button0.Name = "button0";
            button0.Size = new Size(52, 52);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 12);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(43, 20);
            labelInput.TabIndex = 10;
            labelInput.Text = "Input";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(12, 97);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(49, 20);
            labelResult.TabIndex = 11;
            labelResult.Text = "Result";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(11, 49);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(290, 34);
            textBoxInput.TabIndex = 12;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 132);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(289, 34);
            textBoxResult.TabIndex = 13;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(70, 183);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(52, 52);
            buttonC.TabIndex = 14;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(131, 183);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(52, 52);
            buttonCE.TabIndex = 15;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(189, 380);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(52, 52);
            buttonPoint.TabIndex = 16;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(189, 248);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(52, 52);
            buttonPlus.TabIndex = 17;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(249, 248);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(52, 52);
            buttonMinus.TabIndex = 18;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(189, 183);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(52, 52);
            buttonMultiply.TabIndex = 19;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(247, 183);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(52, 52);
            buttonDivide.TabIndex = 20;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(249, 315);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(52, 118);
            buttonEqual.TabIndex = 21;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 443);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonPoint);
            Controls.Add(buttonCE);
            Controls.Add(buttonC);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInput);
            Controls.Add(labelResult);
            Controls.Add(labelInput);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Label labelInput;
        private Label labelResult;
        private TextBox textBoxInput;
        private TextBox textBoxResult;
        private Button buttonC;
        private Button buttonCE;
        private Button buttonPoint;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEqual;
    }
}
