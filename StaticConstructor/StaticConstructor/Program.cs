using System;

namespace StaticConstructor
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currlnterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // Статический конструктор!
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor!"); // в статическом конструкторе
            currlnterestRate = 0.04;
        }

        // Статические члены для установки/получения процентной ставки,
        public static void SetlnterestRate(double newRate)
        {
            currlnterestRate = newRate;
        }
        public static double GetlnterestRate()
        {
            return currlnterestRate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            // Создать объект счета.
            SavingsAccount s1 = new SavingsAccount(50);
            // Вывести текущую процентную ставку.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            Console.WriteLine("Balance is: {0}", s1.currBalance);
            
            // Попытаться изменить процентную ставку через свойство.
            SavingsAccount.SetlnterestRate(0.08);

            Console.WriteLine();

            // Создать второй объект счета.
            SavingsAccount s2 = new SavingsAccount(100);
            // Должно быть выведено 0.08, не так ли?
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            Console.WriteLine("Balance is: {0}", s2.currBalance);
            Console.ReadLine();
        }
    }
}
