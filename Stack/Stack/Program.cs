using System;

namespace Stack
{
    class Program
    {
        class Stack
        {
            char[] stack;
            public int Tos { get; set; }

            public Stack(int size)
            {
                stack = new char[size];
                Tos = 0;
            }

            public void Push(char ch)
            {
                if(Tos == stack.Length)
                {
                    Console.WriteLine("Стек переполнен");
                    return;
                }

                stack[Tos] = ch;
                Tos++;
            }

            public char Pop()
            {
                if (Tos == 0)
                {
                    Console.WriteLine("Стек пуст");
                    return (char) 0;
                }

                Tos--;
                return stack[Tos];
            }

            public bool IsFull()
            {
                return Tos == stack.Length;
            }

            public bool IsEmpty()
            {
                return Tos == 0;
            }

            public int Capacity()
            {
                return stack.Length;
            }
        }

        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);

            char ch;
            int i;

            // Поместить ряд символов в стек stk1.
            Console.WriteLine("Поместить символы А-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            if (stk1.IsFull()) Console.WriteLine("Стек stk1 заполнен.");

            // Вывести содержимое стека stk1.
            Console.Write("Содержимое стека stk1: \n");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.WriteLine(ch);
            }
            Console.WriteLine();
            if (stk1.IsEmpty()) Console.WriteLine("Стек stk1 пуст.\n");

            // Поместить дополнительные символы в стек stk1.
            Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            // А теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
            // В итоге элементы сохраняются в стеке stk2 в обратном порядке.
            Console.WriteLine("А теперь извлечь символы из стека stk1\n" +
            "и поместить их в стек stk2.");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                stk2.Push(ch);
            }
            Console.Write("Содержимое стека stk2: \n");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.WriteLine(ch);
            }
            Console.WriteLine("\n");

            // Поместить 5 символов в стек.
            Console.WriteLine("Поместить 5 символов в стек stk3.");
            for (i = 0; i < 5; i++)
                stk3.Push((char)('A' + i));
            Console.WriteLine("Емкость стека stk3: " + stk3.Capacity());
            Console.WriteLine("Количество объектов в стеке stk3: " +
            stk3.Tos);
        }
    }
}
