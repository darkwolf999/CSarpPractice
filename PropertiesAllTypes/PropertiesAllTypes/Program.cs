using System;

namespace PropertiesAllTypes
{
    class Building
    {
        private double floors; //Закрытое поле
        private double occupants; //Закрытое поле
        private int buildYear; //Закрытое поле
        public double Area { get; set; } //Автосвойство 
        //public double Area { get; } = 1000 //Можно делать автосвойства только для чтения. Поле неявно определяется как readonly.
        //public double Area { set; } //НЕЛЬЗЯ делать автосвойства только для записи

        //public double Area { private set; get; }// Зато можно ограничить чтение или запись извне
        //public double Area { set; private get; }//
        


        public Building()
        {
            floors = 0;
            Area = 0;
            occupants = 0;
            buildYear = 1900;
        }
        public Building(double Floors, double Area, double Occupants, int BuildYear)
        {
            this.Floors = Floors;
            this.Area = Area;
            occupants = Occupants;
            buildYear = BuildYear;
        }
        ~Building()
        {
            Console.WriteLine("объект удален");
        }
        public double Floors //Свойство. Может быть как только для чтения, так и только для записи. В данном случае присутствует и то, и то
        {
            get 
            { 
                return floors;
            }
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
        public double Occupants //Сокращенная запись свойства
        {
            get => occupants;
            set => occupants = value;
        }
        public double BuildYear //Сокращенная запись свойства только для чтения.
        {
            get => buildYear;
        }

        public double areaPerPerson()
        {
            return Area / occupants;
        }
        public double maxOccupants(double minArea)
        {
            return Area / minArea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(100000,3000,30, 1995);

            Console.WriteLine("Жилой дом house. \n Этажей: {0} \n Площадь дома: {1} \n Количество жителей: {2} \n Площадь на одного человека: {3}",
                                house.Floors, house.Area, house.Occupants, house.areaPerPerson());

            house.Floors = 100000000;
            house.Area = 150;
            house.Occupants = 12;



            Console.WriteLine();



            Console.WriteLine("Жилой дом house. \n Этажей: {0} \n Площадь дома: {1} \n Количество жителей: {2} \n Площадь на одного человека: {3}", 
                              house.Floors, house.Area, house.Occupants, house.areaPerPerson());

            double q = 50;

            Console.WriteLine("Максимальное число человек при условии {0} квадратн. метр. на одного человека: {1}", q, house.maxOccupants(q));
        }
    }
}
