using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class ClassB
    {
        // this is the approach to make a method that is not awaitable synchronous 
        public async void RunB()
        {
            Task<bool> task = new Task<bool>(DoWork);
            task.Start();
            await task;
        }

        private bool DoWork()
        {
            Console.WriteLine("RunB Started!!!");
            Thread.Sleep(1000);
            Console.WriteLine("RunB Complete!!!");
            return true;
        }

    }
}
