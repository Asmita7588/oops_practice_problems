using System;

namespace PracticeProgramOops.Shapes
{
    public class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                    length = value;
                else
                    throw new ArgumentException("Length must be positive.");
            }
        }

        public double Breadth
        {
            get { return breadth; }
            set
            {
                if (value > 0)
                    breadth = value;
                else
                    throw new ArgumentException("Breadth must be positive.");
            }
        }
        public double CalculateArea()
        {
            return length * breadth;
        }
    }
}
