using System;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var task =Task.Run(() => Console.WriteLine("Foo"));
            task.Wait();
        }

        private void DoSomething()
        {
            Console.WriteLine("Foo");
        }
    }
}
