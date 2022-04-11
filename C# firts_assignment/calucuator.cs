using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNummber;
            string operation;
            int result;

            System.Console.WriteLine("Enter FirstNumber: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter SecondNumber: ");
            secondNummber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Operation(+,-,*,/): ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "-":

                    result = firstNumber - secondNummber;
                    Console.WriteLine("your answer is" + firstNumber + " - " + secondNummber + " = " + result);
                    Console.ReadLine();
                    break;

                case "*":
                    result = firstNumber * secondNummber;
                    Console.WriteLine("your answer is:" + firstNumber + " x " + secondNummber + " = " + result);
                    Console.ReadLine();
                    break;

                case "+":
                    result = firstNumber + secondNummber;
                    Console.WriteLine("your answer is" + firstNumber + " +" + secondNummber + " = " + result);
                    Console.ReadLine();
                    break;

                case "/":
                    result = firstNumber / secondNummber;

                    Console.WriteLine("your answer is" + firstNumber + " / " + secondNummber + " = " + result);
                    Console.ReadLine();
                    break;

                default:
                    System.Console.WriteLine("enter a valid opertor");
                    Console.ReadLine();
                    break;
            }


        }
    }
}
