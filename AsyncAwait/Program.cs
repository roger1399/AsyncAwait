using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static   void Main(string[] args)
        {

            ClassA A = new ClassA();
            ClassB B = new ClassB();
            // C = new ClassC();
            //ClassD D = new ClassD();
            A.RunA();
            B.RunB();

            //String r = D.RunD("Roger").Result;
            //C.RunC();
            //Console.WriteLine("FINISHED!!!!!!" + r);
            Console.WriteLine("FINISHED!!!!!!");
            Console.WriteLine("FINISHED!!!");
            Console.ReadKey();
        } 

    }
}
