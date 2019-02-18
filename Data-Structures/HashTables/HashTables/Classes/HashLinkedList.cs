using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    public class HashLinkedList
    {
        public HashNode Head { get; set; }
        public HashNode Current { get; set; }

        public void Insert(string key, string value)
        {
            try
            {
                HashNode node = new HashNode(key, value);
                node.Next = Head;
                Head = node;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
