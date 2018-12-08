using System;
using System.Linq;
namespace WiseTechGlobalTask1
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int x = solution(new int[] {3,4,3,0,2,2,3,0,0 });
            Console.WriteLine(x);
            int x1 = solution(new int[] {4,2,0 });
            Console.WriteLine(x1);
            int x2 = solution(new int[] { 4,4,3,3,1,0 });
            Console.WriteLine(x2);

        }
        public static  int solution(int[] ranks)
        {
            var count = 0;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] postive = ranks.Select(i => i).Where(x => x > 0).OrderBy(j => j).ToArray();
            for (int i = 0; i < ranks.Length; i++)
            {
                if (ranks.Select(m => m).Where(x => (ranks[i]+1) == x).ToList().Count>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
