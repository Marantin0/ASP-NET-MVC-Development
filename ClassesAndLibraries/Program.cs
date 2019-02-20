using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndLibraries
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new MyLibrary.Customer();

            MyLibrary.ICalculate function = new MyLibrary.MultiplyCalculate();
            MyLibrary.ICalculate function2 = new MyLibrary.AddCalculate();
            MyLibrary.ICalculate function3 = new MyLibrary.SubtractCalculate();

            var result = function.PerformCal(10, 10);
            Console.WriteLine(result);

            var result2 = function2.PerformCal(5, 10);
            Console.WriteLine(result2);

            var result3 = function3.PerformCal(23, 10);
            Console.WriteLine(result3);

            MyLibrary.MyObject myObject = new MyLibrary.MyObject(); //Uses object from MyLibrary library
            MySecondLibrary.MyObject myObject2 = new MySecondLibrary.MyObject(10, 10);  //Uses object from MySecondLibrary library

            com.squareconnection.mylibrary.MyObject myObject3 = new com.squareconnection.mylibrary.MyObject();  //using a seperate library that can be shared with other devs when necessary

            //Console.WriteLine("Object 1 property is: " + myObject.number3);
            //Console.WriteLine("Object 2 property is: " + myObject2.number3);
            //Console.WriteLine("Calculator property is: " + myObject.Calculator(11, 12));

            Console.ReadLine();
        }
    }

    
}
