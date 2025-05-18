using System.Dynamic;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int operation;

        public string firstNumber;
        public string secondNumber;

        private bool isThisFirstNum = true;

        //numbers
        private void button_0_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "0";
            }
            else
            {
                secondNumber += "0";
            }
            UpdateNumber();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "1";
            }
            else
            {
                secondNumber += "1";
            }
            UpdateNumber();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "2";
            }
            else
            {
                secondNumber += "2";
            }
            UpdateNumber();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "3";
            }
            else
            {
                secondNumber += "3";
            }
            UpdateNumber();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "4";
            }
            else
            {
                secondNumber += "4";
            }
            UpdateNumber();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "5";
            }
            else
            {
                secondNumber += "5";
            }
            UpdateNumber();
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "6";
            }
            else
            {
                secondNumber += "6";
            }
            UpdateNumber();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "7";
            }
            else
            {
                secondNumber += "7";
            }
            UpdateNumber();
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "8";
            }
            else
            {
                secondNumber += "8";
            }
            UpdateNumber();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                firstNumber += "9";
            }
            else
            {
                secondNumber += "9";
            }
            UpdateNumber();
        }

        //operations:
        private void button_plus_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum) 
            {
                isThisFirstNum = false;
                operation = 1;
                Operation(1);
            }
            else
            {
                return;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
                operation = 2;
                Operation(2);
            }
            else
            {
                return;
            }
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
                operation = 3;
                Operation(3);
            }
            else
            {
                return;
            }
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
                operation = 4;
                Operation(4);
            }
            else
            {
                return;
            }
        }

        //Visual:
        private void UpdateNumber()
        {
            if (isThisFirstNum)
            {
                richTextBox1.Text = firstNumber.ToString();
                textBox1.Text = firstNumber.ToString();
            }
            else
            {
                richTextBox1.Text = secondNumber.ToString();
                textBox1.Text = secondNumber.ToString();
            }
        }
        //Operations_Stack:
        private void Operation(int operation)
        {
            //
        }
        //Answer
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (secondNumber == null)
            {
                MessageBox.Show("Enter the second number!");
                return;
            }
            // convert process:
            
            double numb1 = Convert.ToDouble(firstNumber);
            double numb2 = Convert.ToDouble(secondNumber);
            double answer = 0;
            switch (operation)
            {
                case 1:
                    answer = numb1 + numb2;
                    break;
                case 2:
                    answer = numb1 - numb2;
                    break;
                case 3:
                    answer = numb1 * numb2;
                    break;
                case 4:
                    answer = numb1 / numb2;
                    break;
            }
            richTextBox1.Text = answer.ToString();
            textBox1.Text = answer.ToString();
            MessageBox.Show("Wow!");
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {

        }
    }
}

