using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Master new1 = new Master();
            Slave new2 = new Slave();
            new1.m1(new2);
        }
    }
    class Master {
        public void m1(Slave arg){
            arg.m2();
        }
    }
    class Slave {
        public void m2() { 
            Console.WriteLine("This is second method"); 
        }
    }
}
