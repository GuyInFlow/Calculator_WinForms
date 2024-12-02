using Calculator_WF.CustomControlers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.Drawing.Design;
using System.Windows.Forms;


namespace Calculator_WF
{
    public partial class Form1 : Form
    {
        // State variables for top-level buttons
        private bool isNeedToClose = false;
        private bool isNeedToMaximize = false;
        private bool isNeedToHide = false;

        // State variables for second-level buttons
        private bool isNeedToShowHistory = false;
        private bool isNeedToShowMenu = false;

        // State variables for math operations
        private bool isOperationReleased = false;
        private bool isEqualPressed = false;

        // Temporary expressions
        private string infixExpression = "";
        private string fullInfixExpression = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Logic for top-level buttons
        private void CloseButton_Click(object sender, EventArgs e)
        {
            isNeedToClose = true;
            this.Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            isNeedToMaximize = !isNeedToMaximize;
            this.WindowState = isNeedToMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            isNeedToHide = !isNeedToHide;
            this.WindowState = isNeedToHide ? FormWindowState.Minimized : FormWindowState.Normal;
        }

        private void TrashButton_Click(object sender, EventArgs e)
        {
            HistoryTextBox.Clear();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            if (!isNeedToShowHistory)
            {
                HistoryPanel.Size = new Size(350, 360);
                TrashButton.MaximumSize = new Size(350, 40);
                isNeedToShowHistory = true;
            }
            else
            {
                HistoryPanel.Size = new Size(350, 1);
                isNeedToShowHistory = false;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            isNeedToShowMenu = !isNeedToShowMenu;
            // Add your logic here for showing/hiding the menu
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            MainTextBox.Text    = "0";
            PlentyTextBox.Text  = "";
            infixExpression     = "";
            fullInfixExpression = "";
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            if (isOperationReleased)
            {
                isOperationReleased = false;
                MainTextBox.Text = "";
            }

            if (isEqualPressed)
            {
                isEqualPressed = false;
                PlentyTextBox.Text = "";
            }

            RoundButton currentButton = (RoundButton)sender;
            infixExpression += currentButton.Text;
            PlentyTextBox.Text += currentButton.Text;

            MainTextBox.Text = MainTextBox.Text == "0" ? currentButton.Text : MainTextBox.Text + currentButton.Text;
        }

        private void ButtonMathOperation_Click(object sender, EventArgs e)
        {
            if (isEqualPressed)
            {
                isEqualPressed = false;
                PlentyTextBox.Text  = "";
                MainTextBox.Text    = "0";
                infixExpression     = "";
                fullInfixExpression = "";
            }
            else
            {
                isOperationReleased = true;

                RoundButton currentButton = (RoundButton)sender;
                infixExpression += currentButton.Text;
                PlentyTextBox.Text += currentButton.Text;
            }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            isOperationReleased = true;
            isEqualPressed = true;

            ReversePolishNotation rpn = new ReversePolishNotation(infixExpression);
            double result = rpn.CalculatePostfixNotation();

            MainTextBox.Text = result.ToString();
            PlentyTextBox.Text += " = " + result.ToString();
            fullInfixExpression = PlentyTextBox.Text;
            HistoryTextBox.Text += fullInfixExpression + '\n';

            infixExpression = ""; // Prepare for next expression
        }

        private void DenominatorDivisionButton_Click(object sender, EventArgs e)
        {
            if (isEqualPressed)
            {
                isEqualPressed = false;
                MainTextBox.Text    = "0";
                PlentyTextBox.Text  = "";
                infixExpression     = "";
                fullInfixExpression = "";
            }
            else
            {
                int i = infixExpression.Length - 1;
                string fullNumberReverse = "";

                while (i >= 0 && (Char.IsDigit(infixExpression[i]) || infixExpression[i] == ','))
                {
                    fullNumberReverse += infixExpression[i];
                    i--;
                }

                string fullNumber = new string(fullNumberReverse.Reverse().ToArray());

                infixExpression = infixExpression.Substring(0, i + 1) + "1/" + fullNumber;
                PlentyTextBox.Text = infixExpression;
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (isEqualPressed)
            {
                isEqualPressed = false;
                MainTextBox.Text    = "0";
                PlentyTextBox.Text  = "";
                infixExpression     = "";
                fullInfixExpression = "";
            }
            else
            {
                int i = infixExpression.Length - 1;
                string fullNumberReverse = "";

                while (i >= 0 && (Char.IsDigit(infixExpression[i]) || infixExpression[i] == ',' || infixExpression[i] == '√' || infixExpression[i] == '^'))
                {
                    fullNumberReverse += infixExpression[i];
                    i--;
                }

                string fullNumber = new string(fullNumberReverse.Reverse().ToArray());

                if (i >= 0 && (infixExpression[i] == '+' || infixExpression[i] == '-'))
                {
                    char lastOperator = infixExpression[i];
                    infixExpression = infixExpression.Substring(0, i);

                    switch (lastOperator)
                    {
                        case '+': infixExpression += '-' + fullNumber; break;
                        case '-': infixExpression += '+' + fullNumber; break;
                    }
                }
                else if (i >= 0 && (infixExpression[i] == '/' || infixExpression[i] == 'x'))
                {
                    char lastOperator = infixExpression[i];
                    infixExpression = infixExpression.Substring(0, i + 1);

                    fullNumber = fullNumber[0] == '-' ? fullNumber.Substring(1) : "-" + fullNumber;

                    infixExpression += fullNumber;
                }

                PlentyTextBox.Text = infixExpression;
                MainTextBox.Text = fullNumber;
            }
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (!MainTextBox.Text.Contains(","))
                MainTextBox.Text += ",";
        }

        private void DeleteKeyButton_Click(object sender, EventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text.Length > 1 ? MainTextBox.Text.Substring(0, MainTextBox.Text.Length - 1) : "0";
        }
    }
}