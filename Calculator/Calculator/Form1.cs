using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string expression = "0";
        bool newepression = false;
        private void displayDigit(string num)
        {
            if(expression.Length == 0) { expressionDisplayLabel.Text = ""; }
            if (!displayLabel.Text.Equals("0"))
            {
                displayLabel.Text += num;
            }
            else
            {
                displayLabel.Text = num;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (!displayLabel.Text.Equals("0"))
            {
                displayLabel.Text += "0";
                expression += "0";
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            displayDigit("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            displayDigit("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            displayDigit("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            displayDigit("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            displayDigit("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            displayDigit("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            displayDigit("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            displayDigit("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            displayDigit("9");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (expression.Length == 0) { expressionDisplayLabel.Text = ""; }
            if (displayLabel.Text.Equals("0"))
            {
                expressionDisplayLabel.Text += "0+";
                expression += "0+";
            }
            else
            {
                expressionDisplayLabel.Text += displayLabel.Text + "+";
                expression += displayLabel.Text + "+";
            }
            displayLabel.Text = "0";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (expression.Length == 0) { expressionDisplayLabel.Text = ""; }
            if (displayLabel.Text.Equals("0"))
            {
                expressionDisplayLabel.Text += "0-";
                expression += "0-";
            }
            else
            {
                expressionDisplayLabel.Text += displayLabel.Text + "-";
                expression += displayLabel.Text + "-";
            }
            displayLabel.Text = "0";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (expression.Length == 0) { expressionDisplayLabel.Text = ""; }
            if (displayLabel.Text.Equals("0"))
            {
                expressionDisplayLabel.Text += "0×";
                expression += "0*";
            }
            else
            {
                expressionDisplayLabel.Text += displayLabel.Text + "×";
                expression += displayLabel.Text + "*";
            }
            displayLabel.Text = "0";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (expression.Length == 0) { expressionDisplayLabel.Text = ""; }
            if (displayLabel.Text.Equals("0"))
            {
                expressionDisplayLabel.Text += "0÷";
                expression += "0/";
            }
            else
            {
                expressionDisplayLabel.Text += displayLabel.Text + "÷";
                expression += displayLabel.Text + "/";
            }
            displayLabel.Text = "0";
        }

        private void leftBracketButton_Click(object sender, EventArgs e)
        {
            displayDigit("(");
            expressionDisplayLabel.Text += displayLabel.Text;
            expression += displayLabel.Text;
            displayLabel.Text = "0";
        }

        private void rightBracketButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char c in expressionDisplayLabel.Text)
            {
                if (c == '(')
                    count++;
                else if (c == ')')
                {
                    count--;
                }
            }
            foreach (char c in displayLabel.Text)
            {
                if (c == '(')
                    count++;
                else if (c == ')')
                {
                    count--;
                }
            }
            if (count > 0)
            {
                displayDigit(")");
                expressionDisplayLabel.Text += displayLabel.Text;
                expression += displayLabel.Text;
                displayLabel.Text = "0";
        }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.Equals("0"))
            {
                displayDigit("0.");
            } 
            else
            {
                int count = 0;
                foreach (char c in displayLabel.Text)
                {
                    if (c == '.')
                        count++;
                }
                if(count == 0)
                    displayDigit(".");
            }
            
        }

        private void allClearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            expressionDisplayLabel.Text = "";
            expression = "";
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if(displayLabel.Text.Length > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1);
            }
            else if (displayLabel.Text.Equals("0"))
            {
                expressionDisplayLabel.Text = "";
                expression = "";
            } else
            {
                displayLabel.Text = "0";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (expression.Length == 0) { expressionDisplayLabel.Text = ""; }
            expressionDisplayLabel.Text += displayLabel.Text;
            expression += displayLabel.Text;
            DataTable dt = new DataTable();
            var result = dt.Compute(expression, "");
            expressionDisplayLabel.Text += "=";
            displayLabel.Text = result.ToString();
            expression = "";
        }
    }
}
