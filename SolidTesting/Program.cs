using System;

namespace SolidTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            SolObject myFriend = new SolObject();
            SolObject myFiend = new SolObject("Bob", "Johnes");

            Console.WriteLine("My Friend's name is " + myFriend.Surname() + ", " + myFriend.FirstName() + " " + myFriend.Surname());
            Console.WriteLine("My Friend's name is " + myFiend.Surname() + ", " + myFiend.FirstName() + " " + myFiend.Surname());
            Console.ReadLine();
        }
    }
}
