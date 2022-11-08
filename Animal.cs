using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am an Animal");
        }
    }
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is "+name);
        }
    }
}
