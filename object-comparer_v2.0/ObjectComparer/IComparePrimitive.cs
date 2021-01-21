using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public interface IComparePrimitive
    {
         bool Compare<T>(T obj1, T obj2);
    }
}
