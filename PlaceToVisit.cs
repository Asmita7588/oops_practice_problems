using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramOops
{
    internal class PlaceToVisit
    {
        public void PlaceWantToVisit()
        {
            Console.WriteLine("Enter a place which you want to visit :");
            string placeName = Console.ReadLine();

            Console.WriteLine("UpperCase " + placeName.ToUpper());
            Console.WriteLine("LowerCase " + placeName.ToLower());
        }
    }
}
