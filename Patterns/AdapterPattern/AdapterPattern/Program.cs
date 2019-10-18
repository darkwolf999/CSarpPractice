using System;

//https://metanit.com/sharp/patterns/4.2.php

//Паттерн Адаптер(Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.

//Когда надо использовать Адаптер?
//Когда необходимо использовать имеющийся класс, но его интерфейс не соответствует потребностям


//Когда надо использовать уже существующий класс совместно с другими классами, интерфейсы которых не совместимы


//Участники
//Target:  представляет объекты, которые используются клиентом
//Client:  использует объекты Target для реализации своих задач
//Adaptee: представляет адаптируемый класс, который мы хотели бы использовать у клиента вместо объектов Target
//Adapter: собственно адаптер, который позволяет работать с объектами Adaptee как с объектами Target.



namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


class Client
{
    public void Request(Target target)
    {
        target.Request();
    }
}

// Класс, к которому надо адаптировать другой класс   
class Target
{
    public virtual void Request()
    { }
}

// Адаптируемый класс
class Adaptee
{
    public void SpecificRequest()
    { }
}

// Адаптер
class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();

    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}

