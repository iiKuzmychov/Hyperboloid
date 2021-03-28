using System;

namespace Hyperboloid
{
    public abstract class DrawableFigure3D
    {
        public readonly double MinZ;
        public readonly double MaxZ;

        public DrawableFigure3D(double minZ, double maxZ)
        {
            if (minZ > maxZ)
                throw new ArgumentOutOfRangeException("MinZ must be less MaxZ");

            MinZ = minZ;
            MaxZ = maxZ;
        }

        public abstract DrawableFigure2D GetZAxisSection(double z);
    }
}
