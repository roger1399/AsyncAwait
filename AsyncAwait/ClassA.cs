using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class ClassA
    {
        // this is the approach to make a method that is not awaitable synchronous 
        public async Task<bool> RunA()
        {
            Task<bool> task = new Task<bool>(DoWork);
            task.Start();

            return await task;

        }

        private bool DoWork()
        {
            Console.WriteLine("RunA Started!!!");
            Thread.Sleep(1000);
            Console.WriteLine("RunA Complete!!!");
            return true;

        }

    }
}
