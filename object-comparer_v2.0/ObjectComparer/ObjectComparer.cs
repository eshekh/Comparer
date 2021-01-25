using System;
using System.Collections;
using System.Reflection;

namespace ObjectComparer
{
    public class ObjectComparer
    {
        public bool IsEqual<T>(T obj1, T obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;

            if (!obj1.GetType().Equals(obj2.GetType()))
            {
                return false;
            }

            CompareFactory compareFactory = new ObjectFactory();

            Type type = obj1.GetType();
            var compareObject = compareFactory.GetCompareObject(type);
            if (compareObject.GetType().Name == "CompareProperties")
            {
                return compareObject.Compare(type, obj1, obj2);
            }
            return compareObject.Compare(obj1, obj2);

        }
    }
}
