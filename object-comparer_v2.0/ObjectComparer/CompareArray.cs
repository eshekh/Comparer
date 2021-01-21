using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class CompareArray : ObjectComparer, ICompareArray
    {
        public bool Compare<T>(T arr1, T arr2)
        {
            Array first = arr1 as Array;
            Array second = arr2 as Array;
            Array.Sort(first);
            Array.Sort(second);

            var en = first.GetEnumerator();
            int i = 0;
            while (en.MoveNext())
            {
                if (!IsEqual(en.Current, second.GetValue(i)))
                    return false;
                i++;
            }
            return true;
        }
    }
}
