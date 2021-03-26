using System;

namespace Hyperboloid
{
    public struct Vector3D
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public static Vector3D Zero = new Vector3D(0, 0, 0);

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        private static double DegreesToDirection(int degrees)
        {
            return (double)(degrees - 180) / 180;
        }

        public static Vector3D FromDegrees(int x, int y, int z)
        {
            return new Vector3D(DegreesToDirection(x), DegreesToDirection(y), DegreesToDirection(z));
        }
    }
}
