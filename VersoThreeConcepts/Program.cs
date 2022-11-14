using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtMethodLibrary;

namespace ConDelegateApp
{
    internal class VersionThreeConcepts
    {
        class Person
        {
            int age = 22;
            string name;
        }
        static void Main()
        {
            List<int> list = new List<int>();
            ArrayList arr = new ArrayList();
            arr.Add(12);
            string str = "10";
            int x = 10;
            Console.WriteLine($"Addition is {x.Add(5, 6)}");
            Console.WriteLine($"multiply is {x.Multiply(10)}");



        }
    }
}