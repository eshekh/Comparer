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
            if (type.IsPrimitive || typeof(string).Equals(type))
            {
                var comparePrimitive = compareFactory.GetCompareObject("Primitive");
                return comparePrimitive.Compare(obj1, obj2);
            }
            if (type.IsArray)
            {
                var compareArray = compareFactory.GetCompareObject("Array");
                return compareArray.Compare(obj1, obj2);
            }
            if (type.Name.Contains("List"))
            {
                var compareList = compareFactory.GetCompareObject("List");
                return compareList.Compare(obj1, obj2);
            }
            if (type.Name.Contains("Dictionary"))
            {
                var compareDictioanry = compareFactory.GetCompareObject("Dictionary");
                return compareDictioanry.Compare(obj1, obj2);
            }
            else
            {                
                var compareProperties = compareFactory.GetCompareObject("Properties");
                return compareProperties.Compare(type, obj1, obj2);
            }
        }       
    }
}
