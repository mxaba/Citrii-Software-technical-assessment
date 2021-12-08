using System;
using System.Diagnostics;

namespace Test
{
    public class Test1Improved
    {
        public static void improvedTest1(int n){
            var watch = Stopwatch.StartNew();
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var tag = new String('#', i);
                Console.WriteLine(spaces + tag);
            }
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");
        }
    }
}