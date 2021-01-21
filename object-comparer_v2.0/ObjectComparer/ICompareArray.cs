using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public interface ICompareArray
    {
        bool Compare<T>(T arr1, T arr2);
    }
}
