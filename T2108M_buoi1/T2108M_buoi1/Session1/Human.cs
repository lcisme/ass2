using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_buoi1.Session1
{
    abstract class Human
    {
        public string name;
        int age;

        public abstract void ShowInfor();
        public virtual void Running()
        {
            Console.WriteLine("Running ...");
        }
    }
}
