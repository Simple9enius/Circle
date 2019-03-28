using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Circle
    {
        private double X{ get; set; }
        private double Y { get; set; }
        private double Radius { get; set; }

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public static bool operator >(Circle c1, Circle c2)
        {
            return c1.Radius > c2.Radius;
        }

        public static bool operator <(Circle c1, Circle c2)
        {
            return c1.Radius < c2.Radius;
        }

        public static bool operator >=(Circle c1, Circle c2)
        {
            return c1.Radius >= c2.Radius;
        }

        public static bool operator <=(Circle c1, Circle c2)
        {
            return c1.Radius <= c2.Radius;
        }

        public static bool operator ==(Circle c1, Circle c2)
        {
            return c1.Radius == c2.Radius;
        }

        public static bool operator !=(Circle c1, Circle c2)
        {
            return c1.Radius != c2.Radius;
        }

        public double getSquare()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public double getLength()
        {
            return 2 * Math.PI * Radius;
        }

        public static bool isIntersection(Circle c1, Circle c2) {
            setCorrectCircles(c1, c2);
            double d = Math.Sqrt(Math.Pow(c2.X - c1.X, 2) + Math.Pow(c2.Y - c1.Y, 2));
            if(c1 == c2 && c1.X == c2.X && c1.Y == c2.Y)
            {
                Console.WriteLine("There're the same circles");
                return true;
            }
            else if (c1.Radius + c2.Radius > d || d < c1.Radius - c2.Radius)
            {
                Console.WriteLine("There aren't intersection point");
                return false;
            }
            else if (c1.Radius + c2.Radius == d || c1.Radius - c2.Radius == d)
            {
                Console.WriteLine("There are one intersection point");
                return true;
            }
            else
            {
                Console.WriteLine("There are two intersection point");
                return true;
            }
        }
        
        private static void setCorrectCircles(Circle c1, Circle c2)
        {
            if(c1.Radius < c2.Radius)
            {
                Circle tmp = c1;
                c1 = c2;
                c2 = c1;
            }
        }

        public override string ToString()
        {
            return "X : " + X + "\nY : " + Y + "\nRadius : " + Radius; 
        }

        public bool isInFirstSection()
        {
            return X >= 0 && Y >= 0;
        }
    }
}
