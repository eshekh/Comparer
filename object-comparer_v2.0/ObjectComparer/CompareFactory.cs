using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public abstract class CompareFactory
    {
        public abstract ICompare GetCompareObject(string ObjectType);
    }

    public class ObjectFactory : CompareFactory
    {
        public override ICompare GetCompareObject(string ObjectType)
        {
            switch (ObjectType)
            {
                case "Dictionary":
                    return new CompareDictionary();
                case "List":
                    return new CompareList();
                case "Array":
                    return new CompareArray();
                case "Primitive":
                    return new ComparePrimitive();
                case "Properties":
                    return new CompareProperties();
                default:
                    throw new ApplicationException(string.Format("Object Type '{0}' cannot be created", ObjectType));

            }
        }
    }
}
