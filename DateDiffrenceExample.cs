using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramOops
{
    internal class DateDiffrenceExample
    {
        public void FindDateDiffrence()
        {
            Console.Write("Enter the first date (YYYY-MM-DD): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date (YYYY-MM-DD): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            int daysDifference = Math.Abs((date2 - date1).Days);

            Console.WriteLine($"The difference between the two dates is {daysDifference} days.");
        }
    }
}
