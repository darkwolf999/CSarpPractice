using System;
using System.Collections.Generic;
using System.Text;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() { }

        public void Display()
        {
            Console.WriteLine($"name = {name}, age = {age}");
        }
    }
}
