using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Person
    {
        public string Name { get; set; }    //Name is relevant to Customer type object

        public void UpdateName(string newName) //Keeping this function inside the class makes it encapsulated
        {
            Name = newName;
        }
    }

    public class Customer:Person  //This class is an example of encapsulation 
    {
        public int CustomerId { get; set; } //ID is relevant to Customer type object
       
    }
    //Inheritance is about creating a base class that can be used to extend other classes
    public class Supplier : Person //Supplier is inheriting the properties of the Person class
    {
        public int SupplierId { get; set; } //ID is relevant to Customer type object
    
    }

}
