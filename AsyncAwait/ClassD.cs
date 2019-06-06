using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class ClassD
    {
        public async Task<string> RunD(string test)
        {
            Task<string> task = new Task<string>(()=>DoWork(test));
            task.Start();
            return await task;
        }

        private string DoWork(string test)
        {
            Console.WriteLine("RunD Started!!!");
            Thread.Sleep(5000);
            Console.WriteLine("RunD Complete!!!");
            return test;
        }
    }
}
