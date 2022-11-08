using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Encapsulation
    {
        private int pin;
        public int PIN
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }
    }
}
