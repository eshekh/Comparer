using System;
using System.Collections;
using System.Reflection;

namespace ObjectComparer
{
    public static class Comparer
    {
        public static bool AreSimilar<T>(T obj1, T obj2)
        {
            ///// Add your implementation logic here. Feel free to add classes and types as required for your solution.
            var objectComparer = new ObjectComparer();
            return objectComparer.IsEqual(obj1, obj2);
        }
    }
}
