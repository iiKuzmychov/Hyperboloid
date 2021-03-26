using System;

namespace Hyperboloid
{
    public class Ellipse : DrawableFigure2D
    {
        public readonly double A;
        public readonly double B;

        public Ellipse(double a, double b) : base(-a, a)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a));

            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b));

            A = a;
            B = b;
        }

        public override double[] GetYValues(double x)
        {
            double absoluteValue = B * Math.Sqrt((A + x) * (A - x)) / A;
                                 //b *         √((a + x) * (a - x)) / a
                                 //b * √((a + x) * (a - x)) / a

            return new double[] { absoluteValue, -absoluteValue };
        }

        public override bool Equals(object obj)
        {
            if (obj is Ellipse)
            {
                var objectAsEllipse = obj as Ellipse;

                if (objectAsEllipse.A == A &&
                    objectAsEllipse.B == B)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return base.Equals(obj);
        }

        public static bool operator ==(Ellipse ellipse1, Ellipse ellipse2)
        {
            return !(ellipse1 is null) && ellipse1.Equals(ellipse2);
        }

        public static bool operator !=(Ellipse ellipse1, Ellipse ellipse2)
        {
            return !(ellipse1 == ellipse2);
        }
    }
}
