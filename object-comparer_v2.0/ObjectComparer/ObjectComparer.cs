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

            Type type = obj1.GetType();
            if (type.IsPrimitive || typeof(string).Equals(type))
            {
                var comparePrimitive = new ComparePrimitive();
                return comparePrimitive.Compare(obj1, obj2);
            }
            if (type.IsArray)
            {
                var compareArray = new CompareArray();
                return compareArray.Compare(obj1, obj2);
            }
            if (type.Name.Contains("List"))
            {
                var compareList = new CompareList();
                return compareList.Compare(obj1, obj2);
            }
            else
            {
                var compareProperties = new CompareProperties();
                return compareProperties.Compare(type, obj1, obj2);
            }
        }       
    }
}
