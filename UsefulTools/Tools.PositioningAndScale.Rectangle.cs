namespace UsefulTools
{
    public partial class Tools
    {
        public static partial class PositioningAndScale
        {
            public class Rectangle
            {
                /// <summary>
                /// The size
                /// </summary>
                public Size2D size;
                /// <summary>
                /// The coordinates
                /// </summary>
                public Coordinates2D coordinates;

                /// <summary>
                /// The constructor with preset Size2D and Coordinates2D
                /// </summary>
                /// <param name="size">The size to use. Use UsefulTools.Tools.PositioningAndScale.Size2D</param>
                /// <param name="coordinates">The coordinates to use. Use UsefulTools.Tools.PositioningAndScale.Coordinates2D</param>
                public Rectangle(Size2D size, Coordinates2D coordinates)
                {
                    this.size = size;
                    this.coordinates = coordinates;
                }
                /// <summary>
                /// The constructor without preset Size2D and Coordinates2D
                /// </summary>
                /// <param name="width">The width to use.</param>
                /// <param name="heigth">The heigth to use.</param>
                /// <param name="x">The x coordinate</param>
                /// <param name="y">The y coordinate</param>
                public Rectangle(double width, double heigth, double x, double y)
                {
                    size = new Size2D(width, heigth);
                    coordinates = new Coordinates2D(x, y);
                }
            }
        }
    }
}
