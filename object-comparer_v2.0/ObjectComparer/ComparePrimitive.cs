using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class ComparePrimitive : ObjectComparer, IComparePrimitive
    {
        public bool Compare<T>(T obj1, T obj2)
        {
            return obj1.Equals(obj2);
        }
    }
}
