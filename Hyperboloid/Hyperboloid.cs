using System;

namespace Hyperboloid
{
    public class Hyperboloid : DrawableFigure3D
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;

        public Hyperboloid(double a, double b, double c, double minZ, double maxZ) : base(minZ, maxZ)
        {
            A = (a != 0) ? a : throw new ArgumentException("A must not equals zero");
            B = (b != 0) ? b : throw new ArgumentException("B must not equals zero");
            C = (c != 0) ? c : throw new ArgumentException("C must not equals zero");
        }

        public Hyperboloid(double a, double b, double c) : this(a, b, c, double.NegativeInfinity, double.PositiveInfinity) { }

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

        public double CalculateSurfaceVolume(double height)
        {
            if (A != B)
                throw new InvalidOperationException("Нельзя посчитать площадь поверхности при A != B");

            return Math.PI * height * Math.Pow(A, 2) / 3 * (9 + (Math.Pow(height, 2) / (4 * Math.Pow(C, 2))));
                // π       * h      * a^2            / 3 * (9 + (h^2                 / (4 * c^2           )))
                // π * h * a^2 / 3 * (9 + (h^2 / (4 * c^2)))
        }

        public override bool Equals(object obj)
        {
            if (obj is Hyperboloid)
            {
                var objectAsHyperboloid = obj as Hyperboloid;

                if (objectAsHyperboloid.A == A &&
                    objectAsHyperboloid.B == B &&
                    objectAsHyperboloid.C == C)
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

        public static bool operator ==(Hyperboloid hyperboloid1, Hyperboloid hyperboloid2)
        {
            return !(hyperboloid1 is null) && hyperboloid1.Equals(hyperboloid2);
        }

        public static bool operator !=(Hyperboloid hyperboloid1, Hyperboloid hyperboloid2)
        {
            return !(hyperboloid1 == hyperboloid2);
        }
    }
}
