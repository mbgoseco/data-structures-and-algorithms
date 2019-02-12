using System;

namespace UniqueStringCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{AreCharactersUnique("ABC123abc")}");
        }

        public static bool AreCharactersUnique(string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
