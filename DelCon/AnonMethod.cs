using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;

namespace DelCon
{ 

    delegate int MathDelegate(int x, int y);

    internal class AnonMethod
    {
        static void Main()
        {
            MathDelegate md = delegate (int a, int b)
            {
                return a + b;
            };
            MathDelegate md2 = delegate (int a, int b)
            {
                return a - b;

            };
             MathDelegate md3 = (a, b) => a * b;
            // Console.WriteLine($"product is {md3(5, 7)}");//
            /*<int, int, int> f1 = (a, b) => a % b;
            Console.WriteLine($"product is {f1(5, 7)}");
            //Console.ReadLine();*/
            ArrayList arr = new ArrayList();
            arr.Add(4);

            List<int> list = new List<int>(c)  ;
            //list.Add("fds");
            IEnumerator 
            Console.ReadLine();
        }   
        }
    }