namespace Hyperboloid
{
    public struct Point3D
    {
        public double X;
        public double Y;
        public double Z;

        public static Point3D Zero = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(Point2D point2D, double z)
        {
            X = point2D.X;
            Y = point2D.Y;
            Z = z;
        }

        public static Point3D operator +(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        }

        public static Point3D operator -(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X - point2.X, point1.Y - point2.Y, point1.Z - point2.Z);
        }

        public static Point3D operator +(Point3D point, double number)
        {
            return new Point3D(point.X + number, point.Y + number, point.Z + number);
        }

        public static Point3D operator *(Point3D point, double number)
        {
            return new Point3D(point.X * number, point.Y * number, point.Z * number);
        }
    }
}
