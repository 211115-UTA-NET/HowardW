using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            int NumSides = 3;
            public Triangle(string Name, int NumSides)
        {
            this.Name = Name;
            this.NumSides = NumSides;
        }

        // This method returns the general information about the shape.
        public void GetInfo()
        {
            System.Console.WriteLine($"This {Name} has {NumSides} sides and an area of {Area}");
        }

        // This method returns the area of the shape
        public double GetArea()
        {
            return this.Area;
        }
        
        // This method sets the Area of the shape
        protected abstract void SetArea();

    }
}
