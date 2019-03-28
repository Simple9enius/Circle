using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input n: ");
                int n = Int32.Parse(Console.ReadLine());
                Circle[] circles = new Circle[n];
                for (int i = 0; i < n; i++)
                {
                    double x, y, r;
                    Console.WriteLine("\nInput x for circle number " + i);
                    x = Double.Parse(Console.ReadLine());
                    Console.WriteLine("\nInput y for circle number " + i);
                    y = Double.Parse(Console.ReadLine());
                    Console.WriteLine("\nInput radius for circle number " + i);
                    r = Double.Parse(Console.ReadLine());
                    if (r < 0)
                    {
                        Console.WriteLine("Radius should be positive!");
                        return;
                    }
                    circles[i] = new Circle(x, y, r);
                }
                Console.WriteLine("\nStarted circles: ");
                printCircles(circles);

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (circles[j] > circles[j + 1])
                        {
                            Circle tmp = circles[j];
                            circles[j] = circles[j + 1];
                            circles[j + 1] = tmp;
                        }
                    }
                }
                Console.WriteLine("\nCircles after sorting: ");
                printCircles(circles);

                Console.WriteLine("Input one more circle: ");
                double x1, y1, r1;
                Console.WriteLine("\nInput x for circle");
                x1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nInput y for circle");
                y1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nInput radius for circle");
                r1 = Double.Parse(Console.ReadLine());
                if (r1 < 0)
                {
                    Console.WriteLine("Radius should be positive!");
                    return;
                }
                Circle circle = new Circle(x1, y1, r1);
                int countIntersection = 0;
                for (int i = 0; i < n; i++)
                {
                    if (Circle.isIntersection(circle, circles[i]))
                    {
                        Console.WriteLine("\nYour circle has intersectin with circle number " + i);
                        countIntersection++;
                    }
                }
                Console.WriteLine("\nSummary count intersection " + countIntersection);

                for (int i = 0; i < n; i++)
                {
                    if (circles[i].isInFirstSection())
                    {
                        Console.WriteLine("Length of circle number " + i + "= " + circles[i].getLength());
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine("Something wrong! Check your input!");
            }
            Console.ReadLine();
        }

        private static void printCircles(Circle[] circles)
        {
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine("\nCircle number " + i + "\n" + circles[i]);
            }
        }

    }
}
