using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Assignment
{
    internal class UC1_CalculateLength
    {
        public void Line()
        {
            Console.WriteLine("Enter the Value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double result = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(result);
        }
    }
}
