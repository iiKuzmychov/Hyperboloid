using System;

namespace Hyperboloid
{
    public abstract class DrawableFigure2D
    {
        public readonly double MaxX;
        public readonly double MinX;

        public DrawableFigure2D(double minX, double maxX)
        {
            if (minX > maxX)
                throw new ArgumentOutOfRangeException("MinZ must be less MaxZ");

            MinX = minX;
            MaxX = maxX;
        }

        public abstract double[] GetYValues(double x);
    }
}
