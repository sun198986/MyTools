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
            Func<string,string> t = DoSomethingResult;
            var s= t("123");

            DisplayValue(s1=>s1+"333", "222");

            Task.Run(() =>
            {
                Console.WriteLine("123");
            });
            
            Parallel.Invoke(DoSomething,DoSomething2,DoSomething3,DoSomething4);
            return ListDemo;
        }

        private string DisplayValue(Func<string,string> strFunc,string para)
        {
            string v = strFunc(para);
            return v;
        }

        private string DisplayValue1(Action<string, string> strAction, string para)
        {
            strAction(para,para+1);
            return para;
        }


        private string DoSomethingResult(string hello)
        {
            return $"返回值";
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