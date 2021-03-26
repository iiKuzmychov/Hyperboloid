using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace Hyperboloid
{
    public class GraphicsEngine3D
    {
        private List<(DrawableFigure3D, Color)> figures3D = new List<(DrawableFigure3D, Color)>();
        private List<(DrawableFigure2D, double, Color)> figures2D = new List<(DrawableFigure2D, double, Color)>();
        public double scaleFactor = 1;

        public List<(DrawableFigure3D, Color)> Figures3D
        {
            get => figures3D;
            set => figures3D = value ?? throw new ArgumentNullException(nameof(value));
        }
        public List<(DrawableFigure2D, double, Color)> Figures2D
        {
            get => figures2D;
            set => figures2D = value ?? throw new ArgumentNullException(nameof(value));
        }
        public Color BackgroundColor { get; set; } = Color.White;
        public double Figures3DStep { get; set; } = 1;
        public double Figures2DStep { get; set; } = 0.1;
        public double ScaleFactor
        {
            get => scaleFactor;

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value));

                scaleFactor = value;
            }
        }
        public Vector3D Rotation { get; set; } = Vector3D.Zero;
        public Point3D ZeroPositionOffset { get; set; } = Point3D.Zero;

        private static Point2D[] GetPoints(DrawableFigure2D figure, double step)
        {
            var points = new List<Point2D>();

            for (double x = figure.MinX; x <= figure.MaxX; x += step)
                foreach (var y in figure.GetYValues(x))
                    points.Add(new Point2D(x, y));

            return points.ToArray();
        }

        private static Point3D[] GetPoints(DrawableFigure3D figure, double step)
        {
            var points = new List<Point3D>();

            for (double z = figure.MinZ; z <= figure.MaxZ; z += step)
            {
                var points2D = GetPoints(figure.GetZAxisSection(z), step);
                var points3D = points2D.Select(point2d => new Point3D(point2d, z));
                points.AddRange(points3D);
            }

            return points.ToArray();
        }

        private static Point3D[] PositionTransform(Point3D[] points, Point3D offset)
        {
            return points.Select(point => point + offset).ToArray();
        }

        // https://stackoverflow.com/questions/34050929/3d-point-rotation-algorithm/34060479
        private static Point3D[] RotationTransform(Point3D[] points, Vector3D rotation)
        {
            List<Point3D> transformedPoints = new List<Point3D>();

            // roll - Ox, pitch - Oy, yaw - Oz
            var cosYaw = Math.Cos(rotation.Z * Math.PI);
            var sinYaw = Math.Sin(rotation.Z * Math.PI);

            var cosPitch = Math.Cos(rotation.Y * Math.PI);
            var sinPitch = Math.Sin(rotation.Y * Math.PI);

            var cosRoll = Math.Cos(rotation.X * Math.PI);
            var sinRoll = Math.Sin(rotation.X * Math.PI);

            var aXX = cosYaw * cosPitch;
            var aXY = cosYaw * sinPitch * sinRoll - sinYaw * cosRoll;
            var aXZ = cosYaw * sinPitch * cosRoll + sinYaw * sinRoll;

            var aYX = sinYaw * cosPitch;
            var aYY = sinYaw * sinPitch * sinRoll + cosYaw * cosRoll;
            var aYZ = sinYaw * sinPitch * cosRoll - cosYaw * sinRoll;

            var aZX = -sinPitch;
            var aZY = cosPitch * sinRoll;
            var aZZ = cosPitch * cosRoll;

            foreach (var point in points)
            {
                var pointX = aXX * point.X + aXY * point.Y + aXZ * point.Z;
                var pointY = aYX * point.X + aYY * point.Y + aYZ * point.Z;
                var pointZ = aZX * point.X + aZY * point.Y + aZZ * point.Z;

                transformedPoints.Add(new Point3D(pointX, pointY, pointZ));
            }

            return transformedPoints.ToArray();
        }

        private static Point3D[] ScaleTranform(Point3D[] points, double scaleFactor)
        {
            return points.Select(point => point * scaleFactor).ToArray();
        }

        private static Point2D[] Points3DTo2DWithoutDuplicates(Point3D[] points)
        {
            return points
                .Select(point => new Point2D(point.X, point.Y))
                .Distinct()
                .ToArray();
        }

        private void Draw(Graphics graphics, Point2D[] points, Color color)
        {
            using (var brush = new SolidBrush(color))
            {
                foreach (var point in points)
                    graphics.FillRectangle(brush, (float)point.X, (float)point.Y, 1, 1);
            }
        }

        public void Draw(Graphics graphics)
        {
            if (graphics is null)
                throw new ArgumentNullException(nameof(graphics));

            graphics.Clear(BackgroundColor);

            foreach (var figure in figures3D)
            {
                var points3D    = GetPoints(figure.Item1, Figures3DStep);
                points3D        = RotationTransform(points3D, Rotation);
                points3D        = ScaleTranform(points3D, ScaleFactor);
                points3D        = PositionTransform(points3D, ZeroPositionOffset);
                
                var points2D = Points3DTo2DWithoutDuplicates(points3D);

                Draw(graphics, points2D, figure.Item2);
            }

            foreach (var figure in figures2D)
            {
                var points3D    = GetPoints(figure.Item1, Figures2DStep).Select(point2d => new Point3D(point2d, figure.Item2)).ToArray();
                points3D        = RotationTransform(points3D, Rotation);
                points3D        = ScaleTranform(points3D, ScaleFactor);
                points3D        = PositionTransform(points3D, ZeroPositionOffset);

                var points2D = Points3DTo2DWithoutDuplicates(points3D);

                Draw(graphics, points2D, figure.Item3);
            }
        }
    }
}
