using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelCon
{
    public class CustomGeneric<T, G>
    {
        T num1;
        G num2;



        public CustomGeneric(T num1, G num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }



        public void show()
        {
            Console.WriteLine($"Values are : {num1} {num2}");
        }



        public T returnValue()
        {
            return this.num1;
        }



        public G returnValue1()
        {
            return this.num2;
        }




    }



    class Program1
    {



        public static void Display<T, G>(T v1, G v2)
        {
            Console.WriteLine(v1);
            Console.WriteLine(v2);



        }
        static void Main()
        {



            CustomGeneric<int, int> c = new CustomGeneric<int, int>(12, 654);
            c.show();
            Console.WriteLine(c.returnValue());
            Console.WriteLine(c.returnValue1());




            Display(12, "bbb");




            Console.Read();



        }

    }




}


