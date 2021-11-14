namespace UsefulTools
{
    public partial class Tools
    {
        public static partial class PositioningAndScale
        {
            public class Circle : Rectangle
            {
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
