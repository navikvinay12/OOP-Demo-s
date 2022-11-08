using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class MethodOverloading
    {
        public void addNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
        }
        public void addNumbers(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
        }
        public void addNumbers(int a, float b)
        {
            float c = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
        }
    }
}
