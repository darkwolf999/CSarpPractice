using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    partial class Employee
    {
        // Поля данных.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        public string Name
        {
            get => empName;
            set
            {
                if (value.Length > 15) Console.WriteLine("Error! Name length exceeds 15 characters!");
                else empName = value;
            }
        }
        public int ID
        {
            get => empID;
            set
            {
                if (value > 999) Console.WriteLine("Error! ID too long");
                else empID = value;
            }
        }
        public float Pay
        {
            get => currPay;
            set
            {
                if (value > 99999999) Console.WriteLine("Error! Pay too large");
                else currPay = value;
            }
        }
        public int Age
        {
            get => empAge;
            set
            {
                if (value > 100) Console.WriteLine("Error! too old");
                else empAge = value;
            }
        }

        // Конструкторы.
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
    }
}
