using System;

namespace Hyperboloid
{
    public class Ellipse : DrawableFigure2D
    {
        public readonly double RadiusX;
        public readonly double RadiusY;

        public Ellipse(double radiusX, double radiusY) : base(-radiusX, radiusX)
        {
            if (radiusX <= 0)
                throw new ArgumentOutOfRangeException(nameof(radiusX));

            if (radiusY <= 0)
                throw new ArgumentOutOfRangeException(nameof(radiusY));

            RadiusX = radiusX;
            RadiusY = radiusY;
        }

        public override double[] GetYValues(double x)
        {
            double absoluteValue = RadiusY * Math.Sqrt((RadiusX + x) * (RadiusX - x)) / RadiusX;
                                 //b *         √((a + x) * (a - x)) / a
                                 //b * √((a + x) * (a - x)) / a

            return new double[] { absoluteValue, -absoluteValue };
        }
    }
}
