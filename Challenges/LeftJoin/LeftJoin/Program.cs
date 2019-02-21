using System;
using System.Collections.Generic;
using HashTables.Classes;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable synTable = new HashTable();
            HashTable antTable = new HashTable();

            synTable.Add("kind", "nice");
            synTable.Add("pit", "hole");
            synTable.Add("strong", "mighty");
            synTable.Add("smart", "intelligent");
            synTable.Add("quiet", "silence");

            antTable.Add("strong", "weak");
            antTable.Add("sharp", "smooth");
            antTable.Add("quiet", "loud");
            antTable.Add("pit", "pedestal");
            antTable.Add("arid", "tropical");

            List<string[]> result = LeftJoin(synTable, antTable);

            foreach (string[] item in result)
            {
                foreach (string word in item)
                {
                    Console.Write($" {word} ");
                }
                Console.WriteLine();
            }
        }

        public static List<string[]> LeftJoin(HashTable synTable, HashTable antTable)
        {
            List<string[]> list = new List<string[]>();

            for (int i = 0; i < synTable.hashTable.Length; i++)
            {

                if (synTable.hashTable[i] != null)
                {
                    synTable.hashTable[i].Current = synTable.hashTable[i].Head;

                    while (synTable.hashTable[i].Current.Next != null)
                    {
                        string[] listItem = {synTable.hashTable[i].Current.Key.ToString(),
                                    synTable.hashTable[i].Current.Value.ToString(),
                                    null};
                        if (antTable.Contains(synTable.hashTable[i].Current.Key))
                        {
                            listItem[2] = antTable.Get(synTable.hashTable[i].Current.Key).ToString();
                        }

                        list.Add(listItem);
                        synTable.hashTable[i].Current = synTable.hashTable[i].Current.Next;
                    }

                    if (synTable.hashTable[i].Current != null)
                    {
                        string[] listItem = {synTable.hashTable[i].Current.Key.ToString(),
                                    synTable.hashTable[i].Current.Value.ToString(),
                                    "NULL"};
                        if (antTable.Contains(synTable.hashTable[i].Current.Key))
                        {
                            listItem[2] = antTable.Get(synTable.hashTable[i].Current.Key).ToString();
                        }

                        list.Add(listItem);
                    }
                }
            }
            return list;
        }
    }
}
