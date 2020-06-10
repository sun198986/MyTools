using System;
using System.Text.RegularExpressions;

namespace RegexUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = @"<avg rrrrrrrrrr>12312312</avg>555<avg rrrrrrrrrr1>2222</avg>";


            string pattern = @"<(\S*?)[^>]*>.*?<\/\1>";
            string input = @"<avg rrrrrrrrrr>12312312</avg>555<avg rrrrrrrrrr1>2222</avg>";

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            var test = Regex.Matches(testString, @"<(\S*?)[^>]*>.*?<\/\1>", RegexOptions.IgnoreCase);

            //Console.WriteLine(Regex.Match(testString, @"<(S*?)[^>]*>.*?<\/\1>", RegexOptions.IgnoreCase).Groups[1].Value);

            //Regex reg = new Regex(@"<avg[^>]*>",RegexOptions.IgnoreCase);
            //Console.WriteLine(reg.IsMatch(testString));
            //string modified = reg.Replace(testString, "");

            //Console.WriteLine(modified);
            Console.ReadLine();
        }
    }
}
