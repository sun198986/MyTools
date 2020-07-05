using System;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentVip vip = new StudentVip{
                Id =123,
                Name="小孙"
            };
            
            ManagerCenter.ManagerStudent<StudentVip>(vip);
            Console.WriteLine("Hello World!");
        }
    }
}
