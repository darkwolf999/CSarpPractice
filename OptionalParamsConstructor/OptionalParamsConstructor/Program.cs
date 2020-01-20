using System;

namespace OptionalParamsConstructor
{

    class Motorcycle
    {
        public int intensity;
        public String driverName;

        public Motorcycle(int intensity = 0, String name = "")
        {
            this.intensity = intensity;
            driverName = name;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // driverName = driverlntensity = 0
            Motorcycle ml = new Motorcycle();
            Console.WriteLine("Name = {0}, Intensity = {1}",
            ml.driverName, ml.intensity);
            // driverName = "Tiny", driverlntensity = 0
            Motorcycle m2 = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name = {0}, Intensity = {1}",
            m2.driverName, m2.intensity);
            // driverName = driverlntensity = 7
            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine("Name = {0}, Intensity = {1}",
            m3.driverName, m3.intensity);
        }
    }
}
