using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class CompareDictionary : ObjectComparer, ICompare
    {
        public bool Compare<T>(T obj1, T obj2)
        {
            Dictionary<object, object> dic1 = ((IEnumerable)obj1).Cast<object>().ToList().ToDictionary(px => px.GetType().GetProperty("Key").GetValue(px), pv => pv.GetType().GetProperty("Value").GetValue(pv));
            Dictionary<object, object> dic2 = ((IEnumerable)obj2).Cast<object>().ToList().ToDictionary(px => px.GetType().GetProperty("Key").GetValue(px), pv => pv.GetType().GetProperty("Value").GetValue(pv));

            var newdic1 = dic1.ToList();
            var newdic2 = dic2.ToList();
            return IsEqual(newdic1, newdic2);
        }

        public bool Compare<T>(Type type, T obj1, T obj2)
        {
            throw new NotImplementedException();
        }
    }
}
