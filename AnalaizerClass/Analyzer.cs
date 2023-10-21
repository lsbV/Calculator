using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AnalaizerClass
{
    public class Analyzer
    {
        #region fields
        /// <summary>
        /// позиція виразу, на якій знайдена синтаксична помилка (у випадку відловлення на рівні виконання - не визначається)
        /// </summary>
        private int erposition = 0;
        /// <summary>
        /// Вхідний вираз
        /// </summary>
        public string expression = "";
        /// <summary>
        /// Показує, чи є необхідність у виведенні повідомлень про помилки. У разі консольного запуску програми це значення - false.
        /// </summary>
        public bool ShowMessage = true;
        #endregion fields

        public Analyzer(string expression)
        {
            this.expression = expression;

        }


        /// <summary>
        /// Перевірка коректності структури в дужках вхідного виразу 
        /// </summary>
        /// <returns>true - якщо все нормально, false- якщо є помилка</returns>
        /// метод біжить по вхідному виразу, символ за символом аналізуючи його, і рахуючи кількість дужок.У разі виникнення
        /// помилки повертає false, а в erposition записує позицію, на якій виникла помилка.
        public bool CheckCurrency()
        {
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push('(');
                }
                else if (expression[i] == ')')
                {
                    if (brackets.Count == 0)
                    {
                        erposition = i;
                        throw new CalcException(MathError.Error01.Replace("<i>", erposition.ToString()));
                    }
                    else
                    {
                        brackets.Pop();
                    }
                }
            }
            if (brackets.Count == 0)
            {
                return true;
            }
            else
            {
                erposition = expression.Length;
                throw new CalcException(MathError.Error01.Replace("<i>", erposition.ToString()));
            }
        }
        /// <summary>
        /// Форматує вхідний вираз, виставляючи між операторами пропуски і видаляючи зайві, а також знаходить нерозпізнані оператори, стежить за кінцем рядка
        /// а також знаходить помилки в кінці рядка
        /// </summary>
        /// <returns>кінцевий рядок або повідомлення про помилку, що починаються з спец.символу &</returns>
        public string Format()
        {
            expression = expression.Replace(" ", "").Replace(',','.');
            return expression;
        }
        /// <summary>
        /// Формує масив, в якому розташовуються оператори і символи представлені в зворотному польському записі(без дужок)
        /// На цьому ж етапі відшукується решта всіх помилок (див. код). По суті - це компіляція.
        /// </summary>
        /// <returns>массив зворотнього польського запису</returns>
        public TwoPart CreateStack(string expression)
        {
            if (expression.Contains('('))
            {
                expression = OpenBrackets(expression);
            }
            char[] operatorsChars = new[] { '+', '-', '/', '*', '%' };
            List<string> numbers = new();
            List<string> operators = new();
            bool lastIsOperator = false;
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    string number = TakeNumberByIndex(expression, i);
                    numbers.Add(number);
                    i += number.Length - 1;
                    lastIsOperator = false;
                }
                else if (operatorsChars.Contains(expression[i]))
                {                    
                    if (ItIsUnaryMinus(expression, i, operatorsChars))
                    {
                        string negativeNumber = "-" + TakeNumberByIndex(expression, i + 1);
                        numbers.Add(negativeNumber);
                        i += negativeNumber.Length - 1;
                        lastIsOperator = false;
                    }
                    else
                    {
                        if (lastIsOperator)
                        {
                            throw new CalcException(MathError.Error04.Replace("<i>", i.ToString()));
                        }
                        operators.Add(expression[i].ToString());
                        lastIsOperator = true;
                    }                    
                }
                else if (expression[i] == '(' || expression[i] == ')')  { }
                else
                {
                    throw new CalcException(MathError.Error02.Replace("<i>", i.ToString()));
                }
            }
            if(numbers.Count == 0 || operators.Count >= numbers.Count)
            {
                throw new CalcException(MathError.Error03);
            }
            return new TwoPart(numbers, operators);
        }

        private static string TakeNumberByIndex(string expression, int i)
        {
            return new(expression.Skip(i).TakeWhile(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
        }

        private bool ItIsUnaryMinus(string expression, int i, char[] operatorsChars)
        {
            if (expression[i] != '-') return false;
            if (i - 1 < 0) return true;
            if(expression[i - 1] == '(') return true;
            if (operatorsChars.Contains(expression[i-1])) return true;
            return false;
        }

        private string OpenBrackets(string expression)
        {
            while (expression.Contains('('))
            {
                var expressionList = expression.ToList();
                string copy = expression;

                for (int i = 0; i < expressionList.Count; i++)
                {
                    if (expressionList[i] == '(')
                    {
                        int nearOpenBracket = expressionList.IndexOf('(', i + 1);
                        int nearCloseBracket = expressionList.IndexOf(')', i + 1);
                        if (nearOpenBracket != -1 && nearOpenBracket < nearCloseBracket)
                        {
                            i = nearOpenBracket - 1;
                            continue;
                        }
                        var length = expressionList.SkipLast(expressionList.Count - nearCloseBracket).Skip(i + 1).Count();
                        string smallExp = new(expressionList.Skip(i+1).Take(length).ToArray());
                        Analyzer smallAnalaizer = new Analyzer(smallExp);
                        var newNumber = smallAnalaizer.Estimate();
                        expressionList.RemoveRange(i, length + 2);
                        expressionList.InsertRange(i, newNumber.ToString());                        
                    }
                }
                expression = new( expressionList.ToArray());
            }
            return expression;
        }


        /// <summary>
        /// Обчислення зворотнього польського запису
        /// </summary>
        ///<returns>результат обчислень,або повідомлення про помилку</returns>
        public double RunEstimate(List<string> numbers, List<string> operators)
        {
            var firstPriority = new[] { "*", "/", "%" };
            var secondPriority = new[] { "+", "-" };
            while (operators.Count > 0)
            {
                for (int i = 0; i < operators.Count; i++)
                {
                    var firstNumber = numbers[i];
                    var sign = operators[i];
                    var secondNumber = numbers[i + 1];
                    if ((secondPriority.Contains(sign) && operators.Any(e => firstPriority.Contains(e)) == false) || firstPriority.Contains(sign))
                    {
                        var res = Calculate(firstNumber, sign, secondNumber);
                        numbers.RemoveAt(i);
                        numbers.RemoveAt(i);
                        numbers.Insert(i, res.ToString());
                        operators.RemoveAt(i);
                        i--;
                    }
                }
            }
            return double.Parse(numbers[0]);
        }
        private double Calculate(string firstNumber, string sign, string secondNumber)
        {
            double a = double.Parse(firstNumber, CultureInfo.InvariantCulture);
            double b = double.Parse(secondNumber, CultureInfo.InvariantCulture);
            switch (sign)
            {
                case "+":
                    return CalcClass.Add(a, b);
                case "-":
                    return CalcClass.Substruct(a, b);
                case "*":
                    return CalcClass.Multiplication(a, b);
                case "/":
                    return CalcClass.Divide(a, b);
                case "%":
                    return CalcClass.Mod(a, b);
                default:
                    throw new CalcException(MathError.Error02);
            }
        }

        /// <summary>
        /// Метод, який організовує обчислення. По черзі запускає CheckCorrncy, Format, CreateStack і RunEstimate
        /// </summary>
        /// <returns></returns>
        public double Estimate()
        {
            CheckCurrency();
            var expression = Format();
            var parts = CreateStack(expression);
            return RunEstimate(parts.Numbers, parts.Operators);
        }


        public class TwoPart
        {
            public List<string> Numbers;
            public List<string> Operators;
            public TwoPart(List<string> numbers, List<string> operators)
            {
                this.Numbers = numbers;
                this.Operators = operators;
            }
        }
    }
}