namespace Hyperboloid
{
    public struct Point2D
    {
        public double X;
        public double Y;

        public static Point2D Zero = new Point2D(0, 0);
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }

        public static Point2D operator +(Point2D point, double number)
        {
            return new Point2D(point.X + number, point.Y + number);
        }

        public static Point2D operator *(Point2D point, double number)
        {
            return new Point2D(point.X * number, point.Y * number);
        }
    }
}
