using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public interface ICompare
    {
        bool Compare<T>( T obj1, T obj2);
        bool Compare<T>(Type type, T obj1, T obj2);
    }
}
