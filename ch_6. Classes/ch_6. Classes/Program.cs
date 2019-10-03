using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch_6.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 1000000; i++)
            {
                Building house = new Building(10, 3000, 30, i);
            }

            //Building house = new Building(100000,3000,30);

            //Console.WriteLine("Жилой дом house. \n Этажей: {0} \n Площадь дома: {1} \n Количество жителей: {2} \n Площадь на одного человека: {3}",
            //                    house.Floors, house.Area, house.Occupants, house.areaPerPerson());

            //house.Floors = 100000000;
            //house.Area = 150;
            //house.Occupants = 12;

            //Console.WriteLine("Жилой дом house. \n Этажей: {0} \n Площадь дома: {1} \n Количество жителей: {2} \n Площадь на одного человека: {3}", 
            //                  house.Floors, house.Area, house.Occupants, house.areaPerPerson());

            //double q = 50000;

            //Console.WriteLine("Максимальное число человек при условии {0} квадратн. метр. на одного человека: {1}", q, house.maxOccupants(q));



            Console.ReadKey();
        }
    }
}
