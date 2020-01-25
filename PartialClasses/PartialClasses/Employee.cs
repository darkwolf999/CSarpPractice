using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    partial class Employee
    {
        // Методы.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
