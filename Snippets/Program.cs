using System;

namespace Snippets
{
    class Program
    {
        static void Main(string region = null, string session = null, string project = null, string[] args = null)
        {
            switch (session)
            {
                case "welcome":
                    Welcome();
                    break;
                case "read-only-struct-members":
                    ReadOnlyStructMembers();
                    break;
            }
        }

        public static void Welcome()
        {
            #region welcome
            Console.WriteLine("Welcome to this interactive guide about C# 8.0");
            #endregion
        }

        public static void ReadOnlyStructMembers()
        {
            #region readonly-struct-members-usage
            Point point = new Point(1.23, 2.43);

            Console.WriteLine(point);
            #endregion
        }
    }

    #region readonly-struct-members
    public struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public override string ToString() => $"({X}, {Y}) is {Distance} from the origin";

        public double Distance => Math.Sqrt(X * X + Y * Y);
    }
    #endregion
}

