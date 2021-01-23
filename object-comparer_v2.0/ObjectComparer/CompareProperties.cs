using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class CompareProperties : ObjectComparer, ICompare
    {
        public bool Compare<T>(Type type, T obj1, T obj2)        {
            foreach (PropertyInfo pi in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
            {
                var val = pi.GetValue(obj1);
                var tval = pi.GetValue(obj2);
                if (!IsEqual(val, tval))
                    return false;
            }
            return true;
        }

        public bool Compare<T>(T arr1, T arr2)
        {
            throw new NotImplementedException();
        }
    }
}
