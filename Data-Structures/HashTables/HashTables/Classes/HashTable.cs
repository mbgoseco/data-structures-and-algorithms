using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    public class HashTable
    {
        HashLinkedList[] hashTable = new HashLinkedList[100];

        public void Add(string key, string value)
        {
            int index = Hash(key);

            if (hashTable[index] == null)
            {
                HashLinkedList list = new HashLinkedList();
                HashNode node = new HashNode(key, value);
                node.Next = list.Head;
                list.Head = node;
                hashTable[index] = list;
            }
            else
            {
                HashNode node = new HashNode(key, value);
                node.Next = hashTable[index].Head;
                hashTable[index].Head = node;
            }
        }

        public string Get(string key)
        {
            int index = Hash(key);

            hashTable[index].Current = hashTable[index].Head;

            if (hashTable[index].Head == null)
            {
                return "No value found matching that key";
            }

            while (hashTable[index].Current.Next != null)
            {
                if (hashTable[index].Current.Key == key)
                {
                    return hashTable[index].Current.Value;
                }
                else
                {
                    hashTable[index].Current = hashTable[index].Current.Next;
                }
            }

            if (hashTable[index].Current.Key == key)
            {
                return hashTable[index].Current.Value;
            }

            return "No value found matching that key";
        }

        public bool Contains(string key)
        {
            int index = Hash(key);

            hashTable[index].Current = hashTable[index].Head;

            if (hashTable[index].Head == null)
            {
                return false;
            }

            while (hashTable[index].Current.Next != null)
            {
                if (hashTable[index].Current.Key == key)
                {
                    return true;
                }
                else
                {
                    hashTable[index].Current = hashTable[index].Current.Next;
                }
            }

            if (hashTable[index].Current.Key == key)
            {
                return true;
            }

            return false;
        }

        public int Hash(string key)
        {
            int hashSum = 0;
            Encoding enc = Encoding.Unicode;
            char[] chars = key.ToCharArray();
            hashSum = (enc.GetByteCount(chars) * 103) % 100;
            return hashSum;
        }
    }
}
