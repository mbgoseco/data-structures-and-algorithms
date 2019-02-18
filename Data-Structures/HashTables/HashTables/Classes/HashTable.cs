using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    public class HashTable
    {
        HashLinkedList[] hashTable = new HashLinkedList[100];

        /// <summary>
        /// Takes in a key/value pair, creates a hash value out of the key, and inserts the pair as a node into a linked list in the hash table at the index matching the hash value.
        /// </summary>
        /// <param name="key">Key string</param>
        /// <param name="value">Value string</param>
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

        /// <summary>
        /// Takes in a key string, creates a hash value from it, goes to the index of the hashtable matching the hash value, and traverses the linked list for a matching key. Returns the value paired to that key if found.
        /// </summary>
        /// <param name="key">Key string</param>
        /// <returns>Value paired to key or "not found" message</returns>
        public string Get(string key)
        {

            int index = Hash(key);

            if (hashTable[index] == null)
            {
                return "No value found matching that key";
            }

            hashTable[index].Current = hashTable[index].Head;

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

        /// <summary>
        /// Takes in a key string, creates a hash value from it, goes to the index of the hashtable matching the hash value, and traverses the linked list for a matching key. Returns true if a matching key is  found, false it not.
        /// </summary>
        /// <param name="key">Key string</param>
        /// <returns>True or False</returns>
        public bool Contains(string key)
        {
            int index = Hash(key);

            if (hashTable[index] == null)
            {
                return false;
            }

            hashTable[index].Current = hashTable[index].Head;

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

        /// <summary>
        /// Converts a given key to an integer value based on the unicode sum of its characters, passed into a mathematical formula, which is then used as an index to assign the key/value pair in the hash table. The hash algorithm is designed to crate adequate dispersal of pairs across the array to avoid collision.
        /// </summary>
        /// <param name="key">Key string</param>
        /// <returns>Integer hash value</returns>
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
