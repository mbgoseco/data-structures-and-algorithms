using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    public class HashNode
    {
        public Object Key { get; set; }
        public Object Value { get; set; }
        public HashNode Next { get; set; }

        public HashNode(Object key, Object value)
        {
            Key = key;
            Value = value;
        }
    }
}
