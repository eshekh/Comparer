using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class ComparePrimitive : ObjectComparer, ICompare
    {
        public bool Compare<T>(T obj1, T obj2)
        {
            return obj1.Equals(obj2);
        }

        public bool Compare<T>(Type type, T obj1, T obj2)
        {
            throw new NotImplementedException();
        }
    }
}
