namespace UsefulTools
{
    public partial class Tools
    {
        public static partial class PositioningAndScale
        {
            public class Circle : Rectangle
            {
                public Circle(double radius, Coordinates2D coordinates)
                {
                    if (radius <= 0)
                        throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be positive.");
                    size = new Size2D(radius * 2, radius * 2);
                    this.coordinates = coordinates;
                }

                public Circle(double radius, double x, double y) : this(radius, new Coordinates2D(x, y))
                {
                }

                /// <summary>
                /// The radius of the circle.
                /// </summary>
                public double Radius
                {
                    get
                    {
                        return size.width / 2;
                    }
                }

                /// <summary>
                /// The diameter of the circle.
                /// </summary>
                public double Diameter
                {
                    get
                    {
                        return Radius * 2;
                    }
                }
            }
        }
    }
}
