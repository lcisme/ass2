using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_buoi1.Session1
{
    class Male : Human,IXMen,IStudent
    {
        public Male()
        {

        }
        public Male(int food)
        {

        }
        public override void ShowInfor()
        {
            
        }
        public override void Running()
        {
            base.Running();
            Console.WriteLine(this.name);
        }

        public void Eat()
        {

        }
        public void Eat(int food)
        {

        }

        public void Study()
        {
        }

        public void Graduation()
        {
            
        }
    }
}
