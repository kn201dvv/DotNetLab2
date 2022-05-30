using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab2
{
    public static class ArrayEx
    {
        public static int Count<T>(this T[] arr, T a) where T :
       IComparable<T>
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(a) == 0)
                    count++;
            }
            return count;
        }
        public static IEnumerable<T> Unique<T>(this T[] arr)
        {
            return arr.Distinct<T>();
        }
    }

}
