using System;

namespace InitializationObjectSyntax
{
    class Program
    {

        class Rectangle
        {
            private Point topLeft = new Point();
            private Point bottomRight = new Point();

            public Point TopLeft
            {
                get { return topLeft; }
                set { topLeft = value; }
            }
            public Point BottomRight
            {
                get { return bottomRight; }
                set { bottomRight = value; }
            }
            public void DisplayStats()
            {
                Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]", topLeft.X, topLeft.Y, topLeft.Color, bottomRight.X, bottomRight.Y, bottomRight.Color);
            }
        }




        enum PointColor
        { LightBlue, BloodRed, Gold }
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public PointColor Color { get; set; }


            public Point() : this(PointColor.BloodRed) { }
            public Point(PointColor ptColor)
            {
                Color = ptColor;
            }
            public Point(int xVal, int yVal)
            {
                X = xVal;
                Y = yVal;
                Color = PointColor.Gold;
            }

            public void DisplayStats()
            {
                Console.WriteLine("[{0}, {1}]", X, Y);
                Console.WriteLine("Point is {0}", Color);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            // Создать объект Point, устанавливая каждое свойство вручную.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Создать объект Point посредством специального конструктора.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Создать объект Point, используя синтаксис инициализации объектов.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();





            // Создать и инициализировать объект Rectangle.
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            myRect.DisplayStats();

            // Традиционный подход.
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            Point p2 = new Point();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;
            r.DisplayStats();

            Console.ReadLine();
        }
    }
}
