using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramOops
{
    internal class BirthdayCalculatorExample
    {
        public static int DaysUntilNextBirthday(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            return (nextBirthday - today).Days;
        }
    }
}
