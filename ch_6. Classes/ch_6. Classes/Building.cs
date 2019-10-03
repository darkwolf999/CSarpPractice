using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_6.Classes
{
    class Building
    {
        public int iterator;
        private double floors;
        private double area;
        private double occupants;

        public Building()
        {
            floors = 0;
            area = 0;
            occupants = 0;
        }
        public Building(double Floors, double Area, double Occupants, int i)
        {
            if (Floors <= 25 && Floors > 0)
            {
                floors = Floors;
            }
            else
            {
                Console.WriteLine("Ты не Сечин");
                floors = 5;
            }
            
            area = Area;
            occupants = Occupants;
            iterator = i;
        }

        ~Building()
        {
            Console.WriteLine(iterator + "объект удален");
        }

        public double Floors
        {
            get { return floors; }
            set
            {
                if (value <= 25 && value > 0)
                {
                    floors = value;
                }
                else
                {
                    Console.WriteLine("Ты не Сечин");
                    floors = 5;
                };
            }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public double Occupants
        {
            get { return occupants; }
            set { occupants = value; }
        }

        public double areaPerPerson()
        {
            return area / occupants;
        }
        public double maxOccupants(double minArea)
        {
            return area / minArea;
        }
    }
}
