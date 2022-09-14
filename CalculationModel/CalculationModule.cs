using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationModule
{
    public class CalculationModule
    {
        public string firstOperand { get; set; } = string.Empty;
        public string secondOperand { get; set; } = string.Empty;
        public string operation { get; set; } = string.Empty;
        public string result { get; protected set; } = string.Empty;
        public CalculationModule(){}
        public CalculationModule(string FirstOperand, string SecondOperand, string Operation){
            CheckOperand(FirstOperand);
            CheckOperand(SecondOperand);
            CheckOperation(Operation);
            this.firstOperand = FirstOperand;
            this.secondOperand = SecondOperand;
            this.operation = Operation;
        }
        public virtual void Calculate()
        {
            CheckOperand(firstOperand);
            CheckOperand(secondOperand);
            CheckOperation(operation);
            try
            {
                switch (operation)
                {
                    case "+":
                        result = (Convert.ToDouble(firstOperand) + Convert.ToDouble(secondOperand)).ToString();
                        break;
                    case "-":
                        result = (Convert.ToDouble(firstOperand) - Convert.ToDouble(secondOperand)).ToString();
                        break;
                    case "/":
                        Double SecondOperand = Convert.ToDouble(secondOperand);
                        if(SecondOperand == 0)
                        {
                            result = "Error; Division by zero";
                            throw new DivideByZeroException();
                        }
                        result = (Convert.ToDouble(firstOperand) / SecondOperand).ToString();
                        break;
                    case "*":
                        result = (Convert.ToDouble(firstOperand) * Convert.ToDouble(secondOperand)).ToString();
                        break;
                }
            }
            catch
            {
                result = "Unkown Error";
                throw;
            }
           
        }

        protected virtual void CheckOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "/":
                    break;
                case "*":
                    break;
                default:
                    result = "Operantion error";
                    throw new ArgumentException(result);
            }

        }

        protected virtual void CheckOperand(string operand)
        {
            try
            {
                Convert.ToDouble(operand);
            }
            catch
            {
                result = "Operand error";
                throw;
            }
        }
    }
}
