using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public static class StringExtentions
    {
        public static int Count(this string str, char a)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == a)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
