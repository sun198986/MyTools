using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class Demo
    {

        protected List<string> ListDemo;

        public List<string> GetList()
        {
            Parallel.Invoke(DoSomething,DoSomething2,DoSomething3,DoSomething4);
            return ListDemo;
        }

        private void DoSomething()
        {
            ListDemo.Add("hello1");
        }

        private void DoSomething2()
        {
            ListDemo.Add("hello2");
        }

        private void DoSomething3()
        {
            ListDemo.Add("hello3");
        }

        private void DoSomething4()
        {
            ListDemo.Add("hello4");
        }
    }
}