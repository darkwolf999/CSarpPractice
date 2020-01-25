using System;

namespace PropertyInMethods
{
    class Program
    {
        class Employee
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
        //
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
