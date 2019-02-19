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
            Object key = "Testing!";
            Object value = "123";
            table.Add(key, value);

            Object result = table.hashTable[648].Head.Value;

            Assert.Equal("123", result);
        }

        [Fact]
        public void CanGetValueMatchingKey()
        {
            HashTable table = new HashTable();
            Object key = "WORDS";
            Object value = "winner";
            table.Add(key, value);

            Object result = table.Get(key);

            Assert.Equal("winner", result);
        }

        [Fact]
        public void NonExistingKeyReturnsNull()
        {
            HashTable table = new HashTable();

            Object result = table.Get("wrong");

            Assert.Null(result);
        }

        [Fact]
        public void CollisionResolvesBothPairs()
        {
            HashTable table = new HashTable();
            Object key = "goat";
            Object value = "baa!";
            table.Add(key, value);

            Object keyTwo = "gato";
            Object valueTwo = "meow!";
            table.Add(keyTwo, valueTwo);

            Object[] result = { table.hashTable[824].Head.Value, table.hashTable[824].Head.Next.Value };
                

            Assert.Equal("meow!baa!", result[0].ToString() + result[1].ToString());
        }

        [Fact]
        public void CanGetValueFromCollisionBucket()
        {
            HashTable table = new HashTable();
            Object key = "goat";
            Object value = "baa!";
            table.Add(key, value);

            Object keyTwo = "gato";
            Object valueTwo = "meow!";
            table.Add(keyTwo, valueTwo);

            Object result = table.Get(key);

            Assert.Equal(value, result);
        }

        [Fact]
        public void KeyHashesToInValueRange()
        {
            HashTable table = new HashTable();
            Object key = "Range of table is 0 to 100";

            int result = table.Hash(key);

            Assert.True(result <= 1000 && result >= 0);
        }
    }
}
