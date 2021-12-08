using System;
using System.Diagnostics;

namespace Test
{
    public class Test1
    {
        public static void staircase(int n) {
            var watch = Stopwatch.StartNew();
            var count = n;            
            for(int i = 1; i <= n; i++) {
                count--;
                amountOfTabs(count);
                Console.WriteLine(amountOfTabs(count) + amountOfTags(i));
            }
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");
        }

        static string amountOfTags(int n) {
            string t = "";
            for(int i = 1; i <= n; i++) {
                t += "#";
            }
            return t;
        }

        static string amountOfTabs(int n) {
            string t = "";
            for(int i = 0; i < n; i++) {
                t += " ";
            }
            return t;
        }
    }
}