using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string strChoice;
            double operandA = 0;
            double operandB = 0;
            double total = 0;
            string strContinue;
            do
            {
                Console.WriteLine("Press any following key to perform an arithmetic operation:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n");
                strChoice = Console.ReadLine();

                Console.Write("Enter value 1:");
                double.TryParse(Console.ReadLine(),out operandA);

                Console.Write("Enter value 2:");
                double.TryParse(Console.ReadLine(),out operandB);

                switch (strChoice)
                {
                    case "1":
                        total = addition(operandA, operandB);
                        break;
                    case "2":
                        total = subtraction(operandA, operandB);
                        break;
                    case "3":
                        total = multiplication(operandA, operandB);
                        break;
                    case "4":
                        total = division(operandA, operandB);
                        break;
                    default:
                        Console.WriteLine("Please key in 1-4 only");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                strContinue = Console.ReadLine();
            } while (strContinue.ToUpper() == "Y");
        }

        public static double addition(double a, double b)
        {
            double total;
            total = (a + b);
            Console.WriteLine(a.ToString() + " + " + b.ToString() + "= " + total.ToString());
            return total;
        }

        public static double subtraction(double a, double b)
        {
            double total;
            total = (a - b);
            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + total.ToString());
            return total;
        }

        public static double multiplication(double a, double b)
        {
            double total;
            total = (a * b);
            Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + total.ToString());
            return total;
        }

        public static double division(double a, double b)
        {
            double total;
            total = (a / b);
            Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + total.ToString());
            return total;
        }
    }
}
