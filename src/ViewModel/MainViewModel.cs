using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Globalization;
using Data.Model;

namespace ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private Calculations calculations = new Calculations() { FirstOperand = "0" };
        private string display = "";
        private readonly string comma = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString();
        public string Comma => comma;


        public string Display {
            get => display;

            set { 
                display = value;
                PressEqual.RaiseCanExecuteChanged();
                OnPropertyChanged("Display");
            }
        }

        private string expression = "0";


        public string Expression
        {
            get => expression;

            set
            {
                expression = value;
                PressComma.RaiseCanExecuteChanged();
                PressBackspace.RaiseCanExecuteChanged();
                PressEqual.RaiseCanExecuteChanged();
                OnPropertyChanged("Expression");
            }
        }

        public Command<string> PressDigit { get; }
        public Command<string> PressOperationBtn { get; }
        public Command PressPlusMinus { get; }
        public Command PressComma { get; }
        public Command PressBackspace { get; }
        public Command PressClear { get; }
        public Command PressEqual { get; }


        public MainViewModel()
        {
            PressDigit = new Command<string>(pressDigit);
            PressOperationBtn = new Command<string>(pressOperationBtn);
            PressPlusMinus = new Command(pressPlusMinus);
            PressComma = new Command(pressComma, () => !Expression.Contains(Comma));
            PressBackspace = new Command(pressBackspace, () => Expression != "0");
            PressClear = new Command(pressClear);
            PressEqual = new Command(pressEqual, () => !string.IsNullOrEmpty(lastOperation));
        }

        private void pressEqual()
        {
            try 
            {
                calculations.SecondOperand = Expression;
                calculations.GetResult();
                Expression = calculations.Result;
                Display = $"{Display} {calculations.SecondOperand} = {calculations.Result}";
            }
            catch (Exception e)
            {
            }
        }

        private string lastOperation = "";

        private void pressOperationBtn(string obj)
        {
            try
            {
                if (string.IsNullOrEmpty(lastOperation))
                {
                    calculations.FirstOperand = Expression;
                    calculations.Operation = obj;
                    lastOperation = obj;
                    Display = $"{Expression} {obj} ";
                    Expression = "0";
                }
            }
            catch (Exception e) { }
            
        }

        private void pressClear()
        {
            Display = "";
            Expression = "0";
            lastOperation = "";
            calculations = new Calculations() { FirstOperand = "0" };
        }

        private void pressBackspace()
        {
            switch (Expression) {
                case "0":
                    break;
                case "-0":
                    Expression = "0";
                    break;
                default:
                    if (Expression.Length == 1 || (Expression[0] == '-' && Expression.Length == 2))
                        Expression = Expression.Remove(Expression.Length - 1) + "0";
                    else
                    {
                        Expression = Expression.Remove(Expression.Length - 1);
                    }
                    break;
            }
        }

        private void pressComma()
        {
            Expression = Expression + comma;
        }

        private void pressDigit(string obj)
        {
            if (Expression == "0" || Expression == "-0")
            {
                Expression = Expression.TrimEnd('0') + obj;
            }
            else 
            {
                Expression = Expression + obj;
            }
            
        }
        private void pressPlusMinus()
        {
            if (Expression[0] == '-')
            {
                Expression = Expression.Remove(0, 1);
            }
            else
            {
                Expression = "-" + Expression;
            }

        }

    }
}
