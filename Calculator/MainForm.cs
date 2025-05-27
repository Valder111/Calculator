namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            labelText.Text = "Enter the first number:";
        }
        
        private int operation;
        public string firstNumber;
        public string secondNumber;
        private bool isThisFirstNum = true;
        private bool isThisFirstDigit = true;
        private bool isPointExist = false;
        //numbers
        private void button_0_Click(object sender, EventArgs e)
        {
            if (isThisFirstDigit)
            {
                return;
            }
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
            operation = 1;
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "0";
            isThisFirstDigit = true;
            isPointExist = false;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            operation = 2;
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "0";
            isThisFirstDigit = true;
            isPointExist = false;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            operation = 3;
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "0";
            isThisFirstDigit = true;
            isPointExist = false;
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            operation = 4;
            if (isThisFirstNum)
            {
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "0";
            isThisFirstDigit = true;
            isPointExist = false;
        }
        private void button_point_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum & isPointExist==false)
            {
                firstNumber += ",";
            }
            else if (isPointExist==false)
            {
                secondNumber += ",";
            }
            isPointExist = true;
            UpdateNumber();
        }

        //Visual:
        private void UpdateNumber()
        {
            if (isThisFirstNum)
            {
                richTextBox1.Text = firstNumber.ToString();
            }
            else
            {
                richTextBox1.Text = secondNumber.ToString();
            }
            isThisFirstDigit = false;
        }

        //Answer
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                MessageBox.Show("Enter the first number!");
            }
            if (secondNumber == null)
            {
                MessageBox.Show("Enter the second number!");
                return;
            }

            // convert process:

            double numb1 = Convert.ToDouble(firstNumber);
            if (numb1 < 0)
            {
                Console.WriteLine(numb1);

            }
            double numb2 = Convert.ToDouble(secondNumber);
            if (numb2 < 0)
            {
                Console.WriteLine(numb2);
            }

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
                    if (numb2 == 0) { richTextBox1.Text = "You can't divide by zero"; return; }
                    answer = numb1 / numb2;
                    break;
            }
            firstNumber = answer.ToString();
            secondNumber = null;
            richTextBox1.Text = answer.ToString();
            labelText.Text = "Here's your answer:";
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            firstNumber = null;
            secondNumber = null;
            isThisFirstNum = true;
            isThisFirstDigit = true;
            isPointExist = false;
            richTextBox1.Text = "0";
            labelText.Text = "Enter the first number:";
        }
    }
}

