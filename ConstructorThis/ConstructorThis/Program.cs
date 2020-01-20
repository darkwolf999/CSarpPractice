using System;

namespace ConstructorThis
{
    class XYCoord
    {
        public int x, y;


        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("В конструкторе XYCoord()");
        }
        public XYCoord(XYCoord obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("В конструкторе XYCoord(obj)");
        }
        public XYCoord(int i, int j)
        {
            Console.WriteLine("В конструкторе XYCoord(int, int)");
            x = i;
            y = j;
        }
    }



    class Motorcycle
    {
        public int driverlntensity;
        public string driverName;
        // Связывание конструкторов в цепочку,
        public Motorcycle()
        {
            Console.WriteLine("In default constructor");
            // Внутри стандартного конструктора
        }
        public Motorcycle(int intensity) : this(intensity, "")
        {
            Console.WriteLine("In constructor taking an int");
            // Внутри конструктора, принимающего int
        }
        public Motorcycle(string name)
        : this(0, name)
        {
            Console.WriteLine("In constructor taking a string");
            // Внутри конструктора, принимающего string
        }
        // Это 'главный' конструктор, выполняющий всю реальную работу,
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master constructor ");
            // Внутри главного конструктора
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverlntensity = intensity;
            driverName = name;
        }

        public void SetDriverName(string name)
        {
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 1; i <= driverlntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            XYCoord t1 = new XYCoord();
            XYCoord t2 = new XYCoord(8, 9);
            XYCoord t3 = new XYCoord(t2);

            Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);
            Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
            Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);




            Console.WriteLine("*****Fun with class Types *****\n");
            // Создать объект Motorcycle.
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName); //вывод имени гонщика
            Console.ReadLine();

        }
    }
}
