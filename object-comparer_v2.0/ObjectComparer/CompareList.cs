using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
   public class CompareList : ObjectComparer, ICompare
    {
        public bool Compare<T>(T lst1, T lst2)
        {
            IList first = (IList)lst1;
            IList second = (IList)lst2;

            var en = first.GetEnumerator();
            int i = 0;
            while (en.MoveNext())
            {
                if (!IsEqual(en.Current, second[i]))
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
