using System;
using System.Threading;

namespace OperatorOverloading
{

    public class ThreeD
    {
        int x, y, z;

        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static ThreeD operator +(ThreeD ob1, ThreeD ob2)
        {
            return new ThreeD(ob1.x + ob2.x, ob1.y + ob2.y, ob1.z + ob2.z);
        }
        public static ThreeD operator +(ThreeD ob, int i)
        {
            return new ThreeD(ob.x + i, ob.y + i, ob.z + i);
        }
        public static ThreeD operator +(int i, ThreeD ob)
        {
            return new ThreeD(ob.x + i, ob.y + i, ob.z + i);
        }
        public static ThreeD operator ++(ThreeD ob)
        {
            return new ThreeD(ob.x + 1, ob.y + 1, ob.z + 1);
        }
        public static ThreeD operator -(ThreeD ob1, ThreeD ob2)
        {
            return new ThreeD(ob1.x - ob2.x, ob1.y - ob2.y, ob1.z - ob2.z);
        }
        public static ThreeD operator -(ThreeD ob, int i)
        {
            return new ThreeD(ob.x - i, ob.y - i, ob.z - i);
        }
        public static ThreeD operator -(ThreeD ob)
        {
            return new ThreeD(-ob.x, -ob.y, -ob.z);
        }
        public static ThreeD operator --(ThreeD ob)
        {
            return new ThreeD(ob.x - 1, ob.y - 1, ob.z - 1);
        }
        public static bool operator >(ThreeD ob1, ThreeD ob2)
        {
            if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) >
                Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.z * ob2.z))
                return true;
            else
                return false;
        }
        public static bool operator <(ThreeD ob1, ThreeD ob2)
        {
            if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) <
                Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.z * ob2.z))
                return true;
            else
                return false;
        }
        public static bool operator ==(ThreeD ob1, ThreeD ob2)
        {
            return (ob1.x == ob2.x && ob1.y == ob2.y && ob1.z == ob2.z) ? true : false;
        }
        public static bool operator !=(ThreeD ob1, ThreeD ob2)
        {
            return (ob1.x != ob2.x && ob1.y != ob2.y && ob1.z != ob2.z) ? true : false;
        }
        public static bool operator true(ThreeD ob)
        {
            if ((ob.x > 0) || (ob.y > 0) || (ob.z > 0))
                return true;
            else
                return false;
        }
        public static bool operator false(ThreeD ob)
        {
            if ((ob.x == 0) && (ob.y == 0) && (ob.z == 0))
                return true;
            else
                return false;
        }
        // Перегрузить логический оператор | для укороченного вычисления.
        public static ThreeD operator |(ThreeD op1, ThreeD op2)
        {
            if (((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
                ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))
                return new ThreeD(1, 1, 1);
            else
                return new ThreeD(0, 0, 0);
        }
        // Перегрузить логический оператор & для укороченного вычисления.
        public static ThreeD operator &(ThreeD op1, ThreeD op2)
        {
            if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
                ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
                return new ThreeD(1, 1, 1);
            else
                return new ThreeD(0, 0, 0);
        }
        // Перегрузить логический оператор !.
        public static bool operator !(ThreeD op)
        {
            if(op) 
                return false;
            else 
                return true;
        }

        //public static implicit operator int(ThreeD ob)
        //{
        //    return ob.x * ob.y * ob.z;
        //}
        public static explicit operator int(ThreeD ob)
        {
            return ob.x * ob.y * ob.z;
        }

        public static implicit operator ThreeD(int i)
        {
            return new ThreeD(i, i, i);
        }

        public void Show()
        {
            Console.WriteLine("x: " + x +
                              "\ty: " + y +
                              "\tz: " + z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreeD ob1 = new ThreeD(1, 2, 3);
            ob1.Show();

            ThreeD ob2 = new ThreeD(10, 10, 10);
            ob2.Show();

            ThreeD ob3 = ob1 + ob2;
            ob3.Show();

            ob3 = ob3 + 5;
            ob3.Show();

            ob3 = 5 + ob3;
            ob3.Show();

            ob3 = ob2 - ob1;
            ob3.Show();

            ob3 = -ob3;
            ob3.Show();

            ob3 = -ob3;
            ob3.Show();

            ob3++;
            ob3.Show();

            ob3--;
            ob3.Show();

            Console.WriteLine(ob1 > ob2);
            Console.WriteLine(ob1 < ob2);
            Console.WriteLine(ob1 == ob2);
            Console.WriteLine(ob1 != ob2);

            while (ob3)
            {
                ob3.Show();
                ob3--;
                //Thread.Sleep(100);
            }
            
            Console.WriteLine();

            ob3 = ob1 & ob2; 
            ob3.Show();

            ob3 = ob1 | ob2; 
            ob3.Show();

            ob3 = ob1 && ob2; 
            ob3.Show();

            ob3 = ob1 || ob2; //??? 
            ob3.Show();//
            if (ob1 || ob2) Console.WriteLine("истинно");
            else Console.WriteLine("ложно");

            Console.WriteLine(!ob3);

            int i = (int)ob2;
            Console.WriteLine(i);

            ob3 = i;
            ob2.Show();
        }
    }
}
