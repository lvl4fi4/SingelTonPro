using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class SingleTon
    {
        private static SingleTon Instance = null;
        private SingleTon() { }
        public static SingleTon getInstance()
        {
            if (Instance == null)
                Instance = new SingleTon();

            return Instance;
        }
        public  void print(string arg)
        {
            Console.WriteLine(arg);
        }

    }
}
