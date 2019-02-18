using System;
using Xunit;
using HashTables.Classes;

namespace XUnitTestHashTables
{
    public class UnitTest1
    {
        [Fact]
        public void ValueGetsAssignedToDataStructure()
        {
            HashTable table = new HashTable();
            string key = "Testing!";
            string value = "123";
            table.Add(key, value);

            string result = table.hashTable[48].Head.Value;

            Assert.Equal("123", result);
        }

        [Fact]
        public void CanGetValueMatchingKey()
        {
            HashTable table = new HashTable();
            string key = "WORDS";
            string value = "winner";
            table.Add(key, value);

            string result = table.Get(key);

            Assert.Equal("winner", result);
        }

        [Fact]
        public void NonExistingKeyReturnsNull()
        {
            HashTable table = new HashTable();

            string result = table.Get("wrong");

            Assert.Null(result);
        }

        [Fact]
        public void CollisionResolvesBothPairs()
        {
            HashTable table = new HashTable();
            string key = "goat";
            string value = "baa!";
            table.Add(key, value);

            string keyTwo = "gato";
            string valueTwo = "meow!";
            table.Add(keyTwo, valueTwo);

            string[] result = { table.hashTable[24].Head.Value, table.hashTable[24].Head.Next.Value };
                

            Assert.Equal("meow!baa!", result[0] + result[1]);
        }

        [Fact]
        public void CanGetValueFromCollisionBucket()
        {
            HashTable table = new HashTable();
            string key = "goat";
            string value = "baa!";
            table.Add(key, value);

            string keyTwo = "gato";
            string valueTwo = "meow!";
            table.Add(keyTwo, valueTwo);

            string result = table.Get(key);

            Assert.Equal(value, result);
        }

        [Fact]
        public void KeyHashesToInValueRange()
        {
            HashTable table = new HashTable();
            string key = "Range of table is 0 to 100";

            int result = table.Hash(key);

            Assert.True(result <= 100 && result >= 0);
        }
    }
}
