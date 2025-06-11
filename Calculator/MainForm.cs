namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            labelText.Text = "Enter the first number:";
            firstNumber_Text.Text = "";
        }

        private int operation;
        public string firstNumber = "";
        public string secondNumber = "";
        private bool isThisFirstNum = true;
        private bool isPointExist = false;
        private bool isResultActive = false;
        //Numbers
        private void numberButtons(object sender, EventArgs e)
        {
            if (firstNumber == "0" && isThisFirstNum)
            {
                return;
            }
            else if (secondNumber == "0" && !isThisFirstNum)
            {
                return;
            }
            else if (isResultActive && secondNumber == "" && operation == 0)
            {
                MessageBox.Show("Secect the operation or clear the current result!");
                return;
            }
                Button clickedButton = sender as Button;
            switch (clickedButton.Text)
            {
                case "0":
                    if (isThisFirstNum)
                    {
                        if (firstNumber == "0")
                        {
                            return;
                        }
                        firstNumber += "0";
                    }
                    else
                    {
                        if (secondNumber == "0")
                        {
                            return;
                        }
                        secondNumber += "0";
                    }
                    break;
                case "1":
                    if (isThisFirstNum)
                    {
                        firstNumber += "1";
                    }
                    else
                    {
                        secondNumber += "1";
                    }
                    break;
                case "2":
                    if (isThisFirstNum)
                    {
                        firstNumber += "2";
                    }
                    else
                    {
                        secondNumber += "2";
                    }
                    break;
                case "3":
                    if (isThisFirstNum)
                    {
                        firstNumber += "3";
                    }
                    else
                    {
                        secondNumber += "3";
                    }
                    break;
                case "4":
                    if (isThisFirstNum)
                    {
                        firstNumber += "4";
                    }
                    else
                    {
                        secondNumber += "4";
                    }
                    break;
                case "5":
                    if (isThisFirstNum)
                    {
                        firstNumber += "5";
                    }
                    else
                    {
                        secondNumber += "5";
                    }
                    break;
                case "6":
                    if (isThisFirstNum)
                    {
                        firstNumber += "6";
                    }
                    else
                    {
                        secondNumber += "6";
                    }
                    break;
                case "7":
                    if (isThisFirstNum)
                    {
                        firstNumber += "7";
                    }
                    else
                    {
                        secondNumber += "7";
                    }
                    break;
                case "8":
                    if (isThisFirstNum)
                    {
                        firstNumber += "8";
                    }
                    else
                    {
                        secondNumber += "8";
                    }
                    break;
                case "9":
                    if (isThisFirstNum)
                    {
                        firstNumber += "9";
                    }
                    else
                    {
                        secondNumber += "9";
                    }
                    break;
            }
            UpdateNumber();
        }
        //Operations:
        private void buttons_Operation_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.Text)
            {
                case "+":
                    if (isThisFirstNum)
                    {
                        if (firstNumber == "")
                        {
                            return;
                        }
                        isThisFirstNum = false;
                    }
                    label_operation.Text = "+";
                    operation = 1;
                    break;
                case "-":
                    if (isThisFirstNum)
                    {
                        if (firstNumber == "")
                        {
                            //firstNumber += "-";
                            //UpdateNumber();
                            return;
                        }
                        isThisFirstNum = false;
                    }
                    label_operation.Text = "-";
                    operation = 2;
                    break;
                case "*":
                    if (isThisFirstNum)
                    {
                        if (firstNumber == "")
                        {
                            return;
                        }
                        isThisFirstNum = false;
                    }
                    label_operation.Text = "*";
                    operation = 3;
                    break;
                case "/":
                    if (isThisFirstNum)
                    {
                        if (firstNumber == "")
                        {
                            return;
                        }
                        isThisFirstNum = false;
                    }
                    label_operation.Text = "/";
                    operation = 4;
                    break;
            }
            labelText.Text = "Enter the second number:";
            firstNumber_Text.Text = firstNumber;
            richTextBox1.Text = ""; //NEED TO CHANGE LOGIC 
            isPointExist = false;
        }
        //POINT 
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
        }

        //Answer
        private void button_Answer_Click(object sender, EventArgs e)
        {
            if (firstNumber == "")
            {
                MessageBox.Show("Enter the first number!");
                return;
            }
            if (operation == 0)
            {
                MessageBox.Show("Select the operation!");
                return;
            }
            if (secondNumber == "")
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
            operation = 0;
            isResultActive = true;
            secondNumber = "";
            richTextBox1.Text = answer.ToString();
            labelText.Text = "Here's your answer:";
            label_operation.Text = "";
            firstNumber_Text.Text = "";
        }
        private void button_deleteLast_Click(object sender, EventArgs e)
        {
            char delSymbol;
            if (isThisFirstNum)
            {
                if (firstNumber == "")
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
                UpdateNumber();
            }
            else
            {
                if (secondNumber == "")
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
                UpdateNumber();
            }
            if (delSymbol == ',')
            {
                isPointExist = false;
            }
        }
        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            firstNumber = "";
            secondNumber = "";
            operation = 0;
            isThisFirstNum = true;
            isPointExist = false;
            isResultActive = false;

            richTextBox1.Text = "";
            labelText.Text = "Enter the first number:";
            label_operation.Text = "";
            firstNumber_Text.Text = "";
        }
    }
}

