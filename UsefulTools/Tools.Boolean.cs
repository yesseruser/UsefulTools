namespace UsefulTools
{
    public partial class Tools
    {
        public static class Boolean
        {
            public static bool True { get => true; }
            public static bool False { get => false; }
            public static bool Invert(bool input) => !input;
        }
    }
}
