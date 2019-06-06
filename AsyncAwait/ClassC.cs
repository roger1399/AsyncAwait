using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class ClassC
    {
        // how to create an awaitable method
        public async void RunC()
        {

            // no point doing this way inside a loop  since await will block and make it synchronous
            //int counter = 0;
            //while (counter < 10)
            //{
            //    await DoWorkAsync();
            //    counter++;
            //}

            var tasks = new List<Task<bool>>();
            int counter = 0;
            while (counter < 10)
            {
                tasks.Add(DoWorkAsync());
                counter++;
            }

            await Task.WhenAll(tasks);

            //OR this approach

            //int[] collection = new int[10] { 1, 2, 1, 12, 1, 2, 1, 2, 1, 1 };

            //Parallel.ForEach(collection, (x) =>
            //{
            //    DoWorkAsync();
            //});
        }

        // how to create an awaitable method
        private Task<bool> DoWorkAsync()
        {
            return Task.Run(() => DoWork());

        }


        private bool DoWork()
        {
            Console.WriteLine("RunC Started!!!");
            Thread.Sleep(1000);
            Console.WriteLine("RunC Complete!!!");
            return true;

        }
    }
}
