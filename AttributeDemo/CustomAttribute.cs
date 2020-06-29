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
    }
}