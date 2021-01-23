using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class CompareArray : ObjectComparer, ICompare
    {
        public bool Compare<T>(T obj1, T obj2)
        {
            Array first = obj1 as Array;
            Array second = obj2 as Array;
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

        public bool Compare<T>(Type type, T obj1, T obj2)
        {
            throw new NotImplementedException();
        }
    }
}
