
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;


namespace Calculator_WF
{

    internal class ReversePolishNotation
    {
        public string infixExprProperty { get; private set; }

        public string postfixExprProperty { get; private set; }

        private Dictionary<char, int> operatorsProiritys = new()
        {
            {'(', 0},
            {'+', 1},
            {'-', 1},
            {'x', 2},
            {'/', 2},
            {'%', 2},
            {'^', 3},
            {'~', 4},
            {'√', 5}
        };

        public ReversePolishNotation(string infixExpression)
        {
            infixExprProperty = infixExpression;
            postfixExprProperty = ConvertInfixToPostfix(infixExpression);
        }

        private string GetFullNumberInPRN(string infixExpression, ref int pos)
        {
            string fullNumber = "";
            for(; pos < infixExpression.Length; pos++)
            {
                char currentSymbol = infixExpression[pos];
                if(Char.IsDigit(currentSymbol))
                    fullNumber += currentSymbol;
                else
                {
                    pos--;
                    break;
                }
            }
            return fullNumber;
        }

        private string ConvertInfixToPostfix(string infixExpression)
        {
            Stack<char> operatorsStack = new();
            string expressionInRPN = "";

            for(int i = 0; i < infixExpression.Length; i++)
            {
                char currentSymbol = infixExpression[i];
                if (Char.IsDigit(currentSymbol))
                    expressionInRPN += GetFullNumberInPRN(infixExpression, ref i) + " ";                
                else if (currentSymbol == '√')
                    operatorsStack.Push(currentSymbol);
                else if (currentSymbol == '(')
                    operatorsStack.Push(currentSymbol);
                else if (currentSymbol == ')')
                {
                    while (operatorsStack.Count > 0 && operatorsStack.Peek() != '(')
                        expressionInRPN += operatorsStack.Pop() + " ";
                    operatorsStack.Pop();
                }
                else if (operatorsProiritys.ContainsKey(currentSymbol))
                {
                    char operation = currentSymbol;
                    if ((currentSymbol == '-' && i == 0) || (i > 1 && operatorsProiritys.ContainsKey(infixExpression[i - 1])))
                        operation = '~';

                    while (operatorsStack.Count > 0 && (operatorsProiritys[operatorsStack.Peek()] >= operatorsProiritys[operation]))
                        expressionInRPN += operatorsStack.Pop();
                    operatorsStack.Push(operation);
                }
            }
            while (operatorsStack.Count > 0)
                expressionInRPN += operatorsStack.Pop();
            return expressionInRPN;
        }

        private double EvaluateDuo(char operation, double firstNumber, double secondNumber)
        {
            switch(operation)
            {
                case '+': return firstNumber + secondNumber;
                case '-': return firstNumber - secondNumber;
                case 'x': return firstNumber * secondNumber;
                case '/': return firstNumber / secondNumber;
                case '%': return firstNumber % secondNumber;
                case '~': return firstNumber - secondNumber; // firstNumber must be 0
                case '^': return Math.Pow(firstNumber, secondNumber);
                case '√': return Math.Sqrt(secondNumber);
                default:  return 0;
            }
        }

        public double CalculatePostfixNotation()
        {
            Stack<double> numbers = new();
            string expressionInPRN = postfixExprProperty;

            for(int i = 0; i < expressionInPRN.Length; i++)
            {
                char currentSymbol = expressionInPRN[i];
                if(Char.IsDigit(currentSymbol))
                {
                    string currentNumber = GetFullNumberInPRN(expressionInPRN, ref i);
                    numbers.Push(Convert.ToDouble(currentNumber));
                }
                else if (operatorsProiritys.ContainsKey(currentSymbol))
                {
                    if(currentSymbol == '~')
                    {
                        double leftNumber = numbers.Count > 0 ? numbers.Pop() : 0;
                        numbers.Push(EvaluateDuo('-', 0.0, leftNumber));
                        continue;
                    }
                    else if(currentSymbol == '√')
                    {
                        double rightNumber = numbers.Count > 0 ? numbers.Pop() : 0;
                        numbers.Push(EvaluateDuo('√', 0.0, rightNumber));
                        continue;
                    }
                    double secondNumber = numbers.Pop();
                    double firstNumber  = numbers.Pop();
                    numbers.Push(EvaluateDuo(currentSymbol, firstNumber, secondNumber));
                }
            }
            return numbers.Pop();
        }
    }
}