using System;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] fs = new Shape[] { new Circle(3.5), new Square(5), new Triangle(3, 5), new Rectangle(4, 5) }; Point p = new Point(1, 2);
            foreach (Shape f in fs)
            {
                Console.WriteLine(f.ToString());
                f.DrawFigure(p);
                p.X++;
                p.Y++;
            }
            Console.ReadLine();
        }
    }

    public struct Point
    {
        private int x;
        private int y;

        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public abstract class Shape
    {
        public abstract void DrawFigure(Point p);

        public override string ToString()
        {
            return ("Figura geometryczna: ");
        }
    }

    public class Circle : Shape, ICloneable
    {
        private double r;

        public double R { get { return this.r; } set { this.r = value; } }

        public Circle() : this(0) { }

        public Circle(double r)
        {
            this.r = r;
        }

        public override void DrawFigure(Point p)
        {
            Console.WriteLine(String.Format("Rysowanie klasy Circle o środku w punkcie: {0}, {1}. O promieniu: {2}", p.X, p.Y, r));
        }

        public override string ToString()
        {
            return base.ToString() + " Circle";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Square : Shape, ICloneable
    {
        private int a;

        public int A { get { return this.a; } set { this.a = value; } }

        public Square() : this(0) { }

        public Square(int a)
        {
            this.a = a;
        }

        public override void DrawFigure(Point p)
        {
            Console.WriteLine(String.Format("Rysowanie klasy Square o środku w punkcie: {0}, {1}. O boku: {2}", p.X, p.Y, a));
        }

        public override string ToString()
        {
            return base.ToString() + " Square";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Triangle : Shape, ICloneable
    {
        private int a;
        private int h;

        public int A { get { return this.a = A; } set { this.a = value; } }
        public int H { get { return this.h = H; } set { this.h = value; } }

        public Triangle() : this(0, 0) { }

        public Triangle(int a, int h)
        {
            this.a = a;
            this.h = h;
        }

        public override void DrawFigure(Point p)
        {
            Console.WriteLine(String.Format("Rysowanie klasy Triangle o środku w punkcie: {0}, {1}. O podstawie: {2} oraz wysokości: {3}", p.X, p.Y, a, h));
        }

        public override string ToString()
        {
            return base.ToString() + " Triangle";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Rectangle : Square, ICloneable
    {
        private int b;
        private Circle c;

        public new int A
        {
            get
            {
                return base.A;
            }
            set
            {
                base.A = value;
                this.c.R = SetCircle(base.A, this.b);
            }
        }
        public int B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
                this.c.R = SetCircle(base.A, this.b);
            }
        }

        private static float SetCircle(int a, int b)
        {
            return (float)Math.Sqrt(Math.Pow(a, 2) * Math.Pow(b, 2));
        }

        public Rectangle() : this(0, 0) { }

        public Rectangle(int a, int b) : base(a)
        {
            this.b = b;
            c = new Circle(SetCircle(a, b));
        }

        public override void DrawFigure(Point p)
        {
            Console.WriteLine(String.Format("Rysowanie klasy Rectangle o środku w punkcie: {0}, {1}. O bokach: {2}, {3}. Promień okręgu opisanego: {4}", p.X, p.Y, base.A, b, c.R));
        }

        public override string ToString()
        {
            return "Figura geometryczna: Rectangle";
        }

        public new object Clone()
        {
            return new Rectangle(base.A, this.b);
        }
    }
}