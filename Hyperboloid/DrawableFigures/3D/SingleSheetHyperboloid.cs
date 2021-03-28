using System;

namespace Hyperboloid
{
    public class SingleSheetHyperboloid : DrawableFigure3D
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;

        public SingleSheetHyperboloid(double a, double b, double c, double minZ, double maxZ) : base(minZ, maxZ)
        {
            A = (a != 0) ? a : throw new ArgumentException("A must not equals zero");
            B = (b != 0) ? b : throw new ArgumentException("B must not equals zero");
            C = (c != 0) ? c : throw new ArgumentException("C must not equals zero");
        }

        public SingleSheetHyperboloid(double a, double b, double c) : this(a, b, c, double.NegativeInfinity, double.PositiveInfinity) { }

        public override DrawableFigure2D GetZAxisSection(double z)
        {
            var ellipseA = A * Math.Sqrt(1 + Math.Pow(z, 2) / Math.Pow(C, 2));
                         //a *         √(1 + z^2            / c^2           )
                         //a * √(1 + z^2 / c^2)

            var ellipseB = B * Math.Sqrt(1 + Math.Pow(z, 2) / Math.Pow(C, 2));
                         //b *         √(1 + z^2            / c^2           )
                         //b * √(1 + z^2 / c^2)

            return new Ellipse(ellipseA, ellipseB);
        }
    }
}
