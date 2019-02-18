using System;

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

            for (int i = 1; i < words.Length; i++)
            {
                int j = i - 1;
                string temp = words[i];

                while (j >= 0)
                {
                    if (temp == words[j] && (temp != "" && words[j] != ""))
                    {
                        return temp;
                    }

                    j--;
                }
            }

            return null;
        }
    }
}
