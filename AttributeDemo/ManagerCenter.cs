using System;
using System.Reflection;

namespace AttributeDemo
{
    public class ManagerCenter
    {
        public static void ManagerStudent<T>(T student) where T:Student
        {
            System.Console.WriteLine($"{student.Id}_{student.Name}");
            student.Study();
            
            Type type = student.GetType();
            if(type.IsDefined(typeof(DiscriptionAttribute),true))
            {
               DiscriptionAttribute attribute= (DiscriptionAttribute) type.GetCustomAttribute(typeof(DiscriptionAttribute),true);
               attribute.Show();
            }
        }
    }
}