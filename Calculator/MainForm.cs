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
        public List<double> _numbers;
        public Stack<double> _firstNumber = new Stack<double>();
        public Stack<double> _secondNumber = new Stack<double>();

        private bool isThisFirstNum = true;

        //numbers
        private void button_0_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(0);
                firstNumber += "0";
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(0);
                secondNumber += "0";
                UpdateNumber();
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                MessageBox.Show("Whatx");
                _firstNumber.Push(1);
                firstNumber += "1";
                UpdateNumber();
            }
            else
            {
                MessageBox.Show("What");
                _secondNumber.Push(1);
                secondNumber += "1";
                UpdateNumber();
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(2);
                firstNumber += "2";
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(2);
                secondNumber += "2";
                UpdateNumber();
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(3);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(3);
                UpdateNumber();
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(4);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(4);
                UpdateNumber();
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(5);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(5);
                UpdateNumber();
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(6);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(6);
                UpdateNumber();
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(7);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(7);
                UpdateNumber();
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(8);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(8);
                UpdateNumber();
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (isThisFirstNum)
            {
                _firstNumber.Push(9);
                UpdateNumber();
            }
            else
            {
                _secondNumber.Push(9);
                UpdateNumber();
            }
        }

        //operations:
        private void button_plus_Click(object sender, EventArgs e)
        {
            isThisFirstNum = false;
            operation = 1;
            Operation(1);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            isThisFirstNum = false;
            operation = 2;
            Operation(2);
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            isThisFirstNum = false;
            operation = 3;
            Operation(3);
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            isThisFirstNum = false;
            operation = 4;
            Operation(4);
        }

        //Visual:
        private void UpdateNumber()
        {
            richTextBox1.Text = firstNumber.ToString();
            textBox1.Text = firstNumber.ToString();
        }
        //Operations_Stack:
        private void Operation(int operation)
        {
            //
        }
        //Answer
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            double numb1 = 0;
            double numb2 = 0;
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
        }
    }
}

