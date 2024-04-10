using System;
using System.Drawing;

namespace NoFences.Util
{
    public static class Extensions
    {

        public static PointF Move(this PointF point, float offsetX, float offsetY)
        {
            return new PointF(point.X + offsetX, point.Y + offsetY);
        }


        public static Rectangle Shrink(this Rectangle rect, int offset)
        {
            return new Rectangle(rect.X + offset, rect.Y + offset, rect.Width - offset * 2, rect.Height - offset * 2);
        }

        public static double Distance(this Point p1, Point p2)
        {
            return Math.Round(Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2)), 1);
        }

    }
}
