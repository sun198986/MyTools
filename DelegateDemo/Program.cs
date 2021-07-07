using System;

namespace DelegateDemo
{
    class Program
    {

        delegate int Transformer(int x);

        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            Transformer t = Square;
            int result = t(3);
            Console.WriteLine(result);
            Transformer t2 = new Transformer(Square);
            var result2=t2.Invoke(result);
            Console.WriteLine(result2);
            Console.WriteLine("Hello World!");
        }

        
    }
}
