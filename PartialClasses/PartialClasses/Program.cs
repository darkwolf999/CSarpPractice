using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvingjhhhhhhhhhhhhhhhh", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            // Переустановка и затем получение свойства Name.
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.ReadLine();
        }
    }
}
