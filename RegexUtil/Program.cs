using System;
using System.Text.RegularExpressions;

namespace RegexUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = @"</avg rrrrrrrrrr>12312312";

            Console.WriteLine(Regex.Match(testString, @"</avg[^>]*>",RegexOptions.IgnoreCase).Value);

            Regex reg = new Regex(@"<avg[^>]*>",RegexOptions.IgnoreCase);
            Console.WriteLine(reg.IsMatch(testString));
            string modified = reg.Replace(testString, "");

            Console.WriteLine(modified);
            Console.ReadLine();
        }
    }
}
