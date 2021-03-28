using System;

namespace Hyperboloid
{
    public class Circle : Ellipse
    {
        public double Radius { get => RadiusX; }

        public Circle(double radius) : base(radius, radius) { }

        public override double[] GetYValues(double x)
        {
            double absoluteValue = Math.Sqrt((Radius + x) * (Radius - x));
                                 //        √((a      + x) * (a - x      ))
                                 //√((a + x) * (a - x))

            return new double[] { absoluteValue, -absoluteValue };
        }
    }
}
