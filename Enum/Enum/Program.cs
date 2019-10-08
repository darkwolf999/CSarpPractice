using System;

namespace EnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);

            Console.WriteLine(Enum.GetUnderlyingType(emp.GetType())); 
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType))); //same results

            Console.WriteLine(emp.ToString());
            Console.WriteLine((int)emp);

            EvaluateEnum(emp);

            DayOfWeek day = DayOfWeek.Monday;

            EvaluateEnum(day);
            

            Console.Read();
        }

        static void EvaluateEnum(System.Enum e)
        {
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name : {0}, Value: {0:D}", enumData.GetValue(i));
            }
        }

        static void AskForBonus(EmpType e)
        {
            switch(e)
            {
                case EmpType.Manager:
                    Console.WriteLine("kek");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("sas");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("lol");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("ses");
                    break;
            }
        }
    }
}
