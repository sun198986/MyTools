using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {

        protected string He;

        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<Task<List<string>>> tasks = new List<Task<List<string>>>();
                //开始时间
                DateTime dtF = DateTime.Now;

                //事务1
                var task = Task<List<string>>.Factory.StartNew(() =>
                {
                    var list = new List<string>();
                    Thread.Sleep(2000);
                    list.Add(Guid.NewGuid().ToString());
                    return list;
                });
                tasks.Add(task);

                //事务2
                var task1 = Task<List<string>>.Factory.StartNew(() =>
                {
                    var list = new List<string>();
                    Thread.Sleep(2000);
                    list.Add(Guid.NewGuid().ToString());
                    return list;
                });
                tasks.Add(task1);

                //事务3
                var task2 = Task<List<string>>.Factory.StartNew(() =>
                {
                    var list = new List<string>();
                    Thread.Sleep(2000);
                    list.Add(Guid.NewGuid().ToString());
                    return list;
                });
                tasks.Add(task2);

                //获取三个事务的返回值
                List<string> res = new List<string>();
                foreach (var item in tasks)
                {
                    res.AddRange(item.Result);
                }

                //结束时间
                DateTime dtT = DateTime.Now;
                //计算总用时
                var dtSp = dtT - dtF;
                Console.WriteLine($"结果：{string.Join(",", res)}   共计用时:{dtSp.TotalSeconds}秒");
            }

        }

        private Task DoSomething()
        {
            return Task.Run(() => He="hello");
        }
    }
}
