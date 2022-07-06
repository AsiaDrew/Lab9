using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class Circle
    {
        //properties
        private double Radius;
        public double circumference;
        public double area;

        //constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        //methods
        public  double CalculateCircumference()
        {
            return circumference = 2 * Math.PI * Radius;
        }
        public string CalculateFormattedCircumference()
        {
            string formattedCircu = FormatNumber(CalculateCircumference());
            return $"Circumference: {formattedCircu}";
        }
        public double CalculateArea()
        {
            return area = Math.PI * Math.Pow(Radius, 2);
            
        }
        public string CalculateFormattedArea()
        {
            string formatArea = FormatNumber(CalculateArea());
            return $"Area: {formatArea}";

        }
        private string FormatNumber(double x)
        {
            string newString = Math.Round(x,2).ToString();
            return newString;
        }
    }
}
