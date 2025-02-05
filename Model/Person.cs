using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramOops.Model
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }


        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
    }

