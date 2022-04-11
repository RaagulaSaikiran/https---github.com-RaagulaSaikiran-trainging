using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FindingCircleArea
    {

        public static void Main(string[] args)
        {
 
                Console.WriteLine("Enter radius of circle ");
                int radius = Convert.ToInt32(Console.ReadLine());

                AreaAndCircumference(radius);
            Console.ReadLine();

            }

          
            public static void AreaAndCircumference(int radius)
            {
                float circle_area = 3.14f * (radius * radius);
                float circle_circumference = 2 * 3.14f * radius;

                Console.WriteLine("Area is: " + circle_area);
                Console.WriteLine("Circumference is:" + circle_circumference);
            }
        }
    }
  