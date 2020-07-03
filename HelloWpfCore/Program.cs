using System;
using System.Windows.Media.Media3D;

namespace HelloWpfCore
{
    public static class Program
    {
        public static void Main()
        {
            var point = new Point3D(1, 2, 3);
            Console.WriteLine($"Point X: {point.X}, Y: {point.Y}, Z: {point.Z}");
        }
    }
}
