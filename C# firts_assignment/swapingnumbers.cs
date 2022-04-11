using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class swapingnumbers
    {

        public static void numbers()
        {
            int number1, number2, temp;


            Console.WriteLine("enter firstNumber  :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter secondNumber  :");
            number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("after swaping: ");
            Console.WriteLine("first number swap as 2nd number: " + number1);
            Console.WriteLine("2nd number swap as 1nd number:" + number2);
            Console.ReadLine();

        }
        static void Main(string[] args)

        {
            swapingnumbers swaped = new swapingnumbers();
            numbers();
        }
    }


}