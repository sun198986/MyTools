using System;

namespace AttributeDemo
{
    public class CustomAttribute:Attribute
    {
        public CustomAttribute(int id)
        {
            Console.WriteLine(id);
        }

        public CustomAttribute(string name)
        {
            Console.WriteLine(name);
        }

        public void Show(){
            System.Console.WriteLine(nameof(CustomAttribute));
        }
    }

    public class DiscriptionAttribute:Attribute
    {
        public DiscriptionAttribute()
        {
            System.Console.WriteLine($"{nameof(DiscriptionAttribute)}被构造");
        }    
        
        public string Description{get;set;}

        public void Show(){
            System.Console.WriteLine(nameof(CustomAttribute));  
            System.Console.WriteLine(Description);
        }
         
    }
}