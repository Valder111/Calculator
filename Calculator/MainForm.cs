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
        public string firstNumber = "";
        public string secondNumber = "";
        private bool isThisFirstNum = true;
        private bool isThisFirstDigit = true;
        private bool isPointExist = false;
        //numbers
        private void numberButtons(object sender, EventArgs e)
        {
            if (isThisFirstDigit)
            {
                firstNumber = "";
            }
            else
            {
                secondNumber = "";
            }
            UpdateNumber();
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                if (firstNumber == "")
                {
                    return;
                }
                firstNumber += "0";
            }
            else
            {
                if (secondNumber == "")
                {
                    return;
                }
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
                if (firstNumber == "")
                {
                    return;
                }
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "";
            label_operation.Text = "+";
            isThisFirstDigit = true;
            isPointExist = false;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            operation = 2;
            if (isThisFirstNum)
            {
                if (firstNumber == "")
                {
                    return;
                }
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "";
            label_operation.Text = "-";
            isThisFirstDigit = true;
            isPointExist = false;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            operation = 3;
            if (isThisFirstNum)
            {
                if (firstNumber == "")
                {
                    return;
                }
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "";
            label_operation.Text = "*";
            isThisFirstDigit = true;
            isPointExist = false;
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            operation = 4;
            if (isThisFirstNum)
            {
                if (firstNumber == "")
                {
                    return;
                }
                isThisFirstNum = false;
            }
            labelText.Text = "Enter the second number:";
            richTextBox1.Text = "";
            label_operation.Text = "/";
            isThisFirstDigit = true;
            isPointExist = false;
        }
        private void button_point_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum & isPointExist == false)
            {
                if (firstNumber == "") { return; }
                firstNumber += ",";
            }
            else if (isPointExist == false)
            {
                if (secondNumber == "") { return; }
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
                    if (numb2 == 0) { richTextBox1.Text = "You can't divide by zero"; return; }
                    answer = numb1 / numb2;
                    break;
            }
            firstNumber = answer.ToString();

            secondNumber = "";

            richTextBox1.Text = answer.ToString();
            labelText.Text = "Here's your answer:";
            label_operation.Text = "";
        }
        private void button_deleteLast_Click(object sender, EventArgs e)
        {
            char delSymbol;
            if (isThisFirstNum)
            {
                if (firstNumber == null)
                {
                    return;
                }
                if (firstNumber.Length == 0)
                {
                    firstNumber = "";
                    richTextBox1.Text = "";
                    return;
                }
                delSymbol = firstNumber[firstNumber.Length - 1];
                firstNumber = firstNumber.Remove(firstNumber.Length - 1);
                //UpdateNumber();
            }
            else
            {
                if (secondNumber == null)
                {
                    return;
                }
                if (secondNumber.Length == 0)
                {
                    secondNumber = "";
                    richTextBox1.Text = "";
                    return;
                }
                delSymbol = secondNumber[secondNumber.Length - 1];
                secondNumber = secondNumber.Remove(secondNumber.Length - 1);
                //UpdateNumber();
            }
            UpdateNumber();
            if (delSymbol == ',')
            {
                isPointExist = false;
            }
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            firstNumber = "";
            secondNumber = "";
            isThisFirstNum = true;
            isThisFirstDigit = true;
            isPointExist = false;
            richTextBox1.Text = "";
            labelText.Text = "Enter the first number:";
            label_operation.Text = "";
        }
    }
}

