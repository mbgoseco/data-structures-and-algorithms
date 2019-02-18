using System;
using HashTables.Classes;

namespace HashTables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable table = new HashTable();
            string key = "Supercalifragilisticexpialidocious!";
            string value = "9999";
            table.Add(key, value);

            string keyTwo = "mist";
            string valueTwo = "7";
            table.Add(keyTwo, valueTwo);

            string keyThree = "stim";
            string valueThree = "8";
            table.Add(keyThree, valueThree);

            Console.WriteLine($"{table.Contains(key)}");
            Console.WriteLine($"{table.Get(key)}");
            Console.WriteLine();

            Console.WriteLine($"{table.Contains(keyTwo)}");
            Console.WriteLine($"{table.Get(keyTwo)}");
            Console.WriteLine();

            Console.WriteLine($"{table.Contains(keyThree)}");
            Console.WriteLine($"{table.Get(keyThree)}");
            Console.WriteLine();
        }
    }
}
