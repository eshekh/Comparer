using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public interface CompareFactory
    {
        ICompare GetCompareObject(Type ObjectType);
    }

    public class ObjectFactory : CompareFactory
    {
        public ICompare GetCompareObject(Type type)
        {
            if (type.IsPrimitive || typeof(string).Equals(type))
            {
                return new ComparePrimitive();
            }
            if (type.IsArray)
            {
                return new CompareArray();
            }
            if (type.Name.Contains("List"))
            {
                return new CompareList();
            }
            if (type.Name.Contains("Dictionary"))
            {
                return new CompareDictionary();
            }
            else
            {
                return new CompareProperties();
            }
        }
    }
}
