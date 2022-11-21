using Abstraction_Polymorphism_Demo.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Polymorphism_Demo
{
    internal class Triangle : Shape
    {
        //(base =  bottom) bottom and height
        private double height;
        private double bottom;

        //Create a triangle of a set base and height
        public Triangle(double height, double bottom) : base("triangle")
        {
            this.height = height;
            this.bottom = bottom;
        }

        //Override the CalculateArea method
        //Area of a triangle is (b*h)/2
        public override double CalculateArea()
        {
            return height * bottom * 0.5;
        }

        //Override the Area property
        //Area of a triangle is (b*h)/2
        public override double Area
        {
            get { return height * bottom * 0.5; }
        }
    }
}
