using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{

    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            Test t3 = new Test();
            Test t4 = new Test();
            Test t5 = new Test();

            SingleTon s1 = SingleTon.getInstance();
            s1.print("hellllllo");
            SingleTon s2= SingleTon.getInstance();
            s2.print("wprld");
            
        }

    }
}
