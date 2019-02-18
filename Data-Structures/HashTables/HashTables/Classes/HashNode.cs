using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    public class HashNode
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public HashNode Next { get; set; }

        public HashNode(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
