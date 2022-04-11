using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class sumofnumbers
    {
        static int SumofElement(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }

            return sum;

        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter array Size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("enter array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = SumofElement(arr);
            Console.WriteLine("sum of arrays : " + result);
            Console.ReadLine();
        }
    }

}