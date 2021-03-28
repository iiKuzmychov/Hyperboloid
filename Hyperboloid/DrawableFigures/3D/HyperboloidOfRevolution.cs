using System;

namespace Hyperboloid
{
    public class HyperboloidOfRevolution : SingleSheetHyperboloid
    {
        public HyperboloidOfRevolution(double a, double c, double minZ, double maxZ) : base(a, a, c, minZ, maxZ) { }

        public HyperboloidOfRevolution(double a, double c) : base(a, a, c) { }

        public override DrawableFigure2D GetZAxisSection(double z)
        {
            var circleRadius = A * Math.Sqrt(1 + Math.Pow(z, 2) / Math.Pow(C, 2));
                             //a *         √(1 + z^2            / c^2           )
                             //a * √(1 + z^2 / c^2)

            return new Circle(circleRadius);
        }

        public double CalculateVolume(double height)
        {
            return Math.PI * height * Math.Pow(A, 2) / 3 * (9 + (Math.Pow(height, 2) / (4 * Math.Pow(C, 2))));
                // π       * h      * a^2            / 3 * (9 + (h^2                 / (4 * c^2           )))
                // π * h * a^2 / 3 * (9 + (h^2 / (4 * c^2)))
        }

        public double CalculateBodyInertiaMomentOxy(double height, double mass)
        {
            var volume  = CalculateVolume(height);
            var p0      = mass / volume;

            return p0 * (Math.Pow(A, 2) * Math.Pow(height, 3) * (3 * Math.Pow(height, 2) + 20 * Math.Pow(C, 2))) / (60 * Math.Pow(C, 2));
                 //p0 * (a^2            * h^3                 * (3 * h^2                 + 20 * c^2           )) / (60 * c^2           )
                 //p0 * (a^2  * h^3 * (3 * h^2 + 20 * c^2)) / 60 * c^2
        }

        public double CalculateBodyInertiaMomentOxz(double height, double mass)
        {
            var volume = CalculateVolume(height);
            var p0 = mass / volume;

            return p0 * (Math.Pow(A, 4) * (3 * Math.Pow(height, 5) + 40 * Math.Pow(C, 2) * Math.Pow(height, 3) + 240 * Math.Pow(C, 4) * height)) / (180 * Math.Pow(C, 4));
                 //p0 * (a^4            * (3 * h^5                 + 40 * c^2            * h^3                 + 240 * c^4            * h     )) / (180 * c^4           )
                 //p0 * (a^4 * (3 * h^5 + 40 * c^2 * h^3 + 240 * c^4 * h)) / (180 * c^4)
        }

        public double CalculateBodyInertiaMomentOyz(double height, double mass)
        {
            return CalculateBodyInertiaMomentOxz(height, mass);
        }

        public double CalculateBodyInertiaMomentOx(double height, double mass)
        {
            return CalculateBodyInertiaMomentOxy(height, mass) + CalculateBodyInertiaMomentOxz(height, mass);
        }

        public double CalculateBodyInertiaMomentOy(double height, double mass)
        {
            return CalculateBodyInertiaMomentOxy(height, mass) + CalculateBodyInertiaMomentOyz(height, mass);
        }

        public double CalculateBodyInertiaMomentOz(double height, double mass)
        {
            return 2 * CalculateBodyInertiaMomentOxz(height, mass);
        }
    }
}
