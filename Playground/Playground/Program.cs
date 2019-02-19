using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject();
            Console.WriteLine(myObject.MyMethod());

            myObject.number1 = 10;
            myObject.number2 = 5;

            //Console.WriteLine("Number 1 is: " + myObject.number1);
            //Console.WriteLine("Number 2 is: " + myObject.number2);
            Console.WriteLine("The Calculation is: " + myObject.Calculator(10,5));
            Console.ReadLine();
        }
    }

    class MyObject
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

        public int Calculator(int number, int number2)
        {
            return number1 + number2;
        }
        public string MyMethod()
        {

            return "some value";
        }
    }
}
