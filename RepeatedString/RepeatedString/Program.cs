using System;
using System.Linq;

namespace RepeatedString
{
    class Solution
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            int strlength = s.Length;
            long mod = n % strlength;
            long values = s.ToArray().Where(i => i == 'a').Count();

            if (values == 0)
                return 0;

            if (strlength == n)
                return values;

            if (mod == 0)
            {
                long splits = n / (long)strlength;
                return splits * values;
            }
            else
            {
                long extra = s.Substring(0, (int)mod).ToArray().Where(i => i == 'a').LongCount();
                long splits = (n / (long)strlength);
                return (splits * values) + extra;
            }
        }

        public static void Main(string[] args)
        {
            string s = "cac"; //Console.ReadLine();

            long n = Convert.ToInt64(19);//Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}
