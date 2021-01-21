using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public interface ICompareProperties
    {
        bool Compare<T>(Type type, T obj1, T obj2);
    }
}
