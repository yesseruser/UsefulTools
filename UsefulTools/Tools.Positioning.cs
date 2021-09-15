namespace UsefulTools
{
    public partial class Tools
    {
        public static class Positioning
        {
            /// <summary>
            /// A 2D size struct.
            /// </summary>
            public struct Size2D
            {
                public double width;
                public double heigth;
                public Size2D(double width, double heigth)
                {
                    this.width = width;
                    this.heigth = heigth;
                }
                public override string ToString() => $"{width} × {heigth}";
            }
            /// <summary>
            /// A 3D size struct.
            /// </summary>
            public struct Size3D
            {
                public double width;
                public double heigth;
                public double length;
                public Size3D(double width, double heigth, double length)
                {
                    this.width = width;
                    this.heigth = heigth;
                    this.length = length;
                }
                public override string ToString() => $"{width} × {heigth} × {length}";
            }
            /// <summary>
            /// A 2D coordinate struct.
            /// </summary>
            public struct Coordinates2D
            {
                public double x;
                public double y;
                public Coordinates2D(double x, double y)
                {
                    this.x = x;
                    this.y = y;
                }
                public override string ToString() => $"{x} × {y}";
            }
            /// <summary>
            /// A 3D coordinate struct.
            /// </summary>
            public struct Coordinates3D
            {
                public double x;
                public double y;
                public double z;
                public Coordinates3D(double x, double y, double z)
                {
                    this.x = x;
                    this.y = y;
                    this.z = z;
                }
                public override string ToString() => $"{x} × {y} × {z}";
            }
        }
    }
}
