using System;
using HashTables.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string yugeString = "How much wood could a, woodchuck chuck if, 'some' woodchuck; could chuck, wood? - William Shatner";

            Console.WriteLine($"First repeated word is: {RepeatedWord(yugeString)}");
        }

        public static string RepeatedWord(string yugeString)
        {
            char[] delimiters = { ' ', ',', '.', '!', '?', ';', ':', '"', '\'', '\\', '/', '(', ')' };
            string[] words = yugeString.Split(delimiters);
            HashTable table = new HashTable();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    if (table.Contains(words[i]))
                    {
                        return words[i];
                    }
                    else
                    {
                        table.Add(words[i], words[i]);
                    }
                }
            }
           
            return null;
        }
    }
}
