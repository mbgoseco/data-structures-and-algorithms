using System;
using Xunit;
using HashTables.Classes;
using LeftJoin;
using System.Collections.Generic;

namespace XUnitTestLeftJoin
{
    public class UnitTest1
    {
        [Fact]
        public void CanJoinValuesOfMatchingKeys()
        {
            HashTable tableOne = new HashTable();
            HashTable tableTwo = new HashTable();

            tableOne.Add("1", "one");
            tableOne.Add("2", "two");
            tableOne.Add("3", "three");
            tableOne.Add("4", "four");
            tableOne.Add("5", "five");

            tableTwo.Add("1", "1");
            tableTwo.Add("0", "zero");
            tableTwo.Add("2", "2");
            tableTwo.Add("6", "six");
            tableTwo.Add("3", "3");

            List<string[]> result = Program.LeftJoin(tableOne, tableTwo);
            List<string[]> expected = new List<string[]>
            {
                new string[]{"5","five","NULL" },
                new string[]{"4","four","NULL" },
                new string[]{"3","three","3" },
                new string[]{"2","two","2" },
                new string[]{"1","one","1" },
            };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void EmptyRightHashmapGivesNulls()
        {
            HashTable tableOne = new HashTable();
            HashTable tableTwo = new HashTable();

            tableOne.Add("1", "one");
            tableOne.Add("2", "two");
            tableOne.Add("3", "three");
            tableOne.Add("4", "four");
            tableOne.Add("5", "five");

            List<string[]> result = Program.LeftJoin(tableOne, tableTwo);
            List<string[]> expected = new List<string[]>
            {
                new string[]{"5","five","NULL" },
                new string[]{"4","four","NULL" },
                new string[]{"3","three","NULL" },
                new string[]{"2","two","NULL" },
                new string[]{"1","one","NULL" },
            };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void AllKeysReturnValues()
        {
            HashTable tableOne = new HashTable();
            HashTable tableTwo = new HashTable();

            tableOne.Add("1", "one");
            tableOne.Add("2", "two");
            tableOne.Add("3", "three");
            tableOne.Add("4", "four");
            tableOne.Add("5", "five");

            tableTwo.Add("1", "1");
            tableTwo.Add("4", "4");
            tableTwo.Add("2", "2");
            tableTwo.Add("5", "5");
            tableTwo.Add("3", "3");

            List<string[]> result = Program.LeftJoin(tableOne, tableTwo);
            List<string[]> expected = new List<string[]>
            {
                new string[]{"5","five","5" },
                new string[]{"4","four","4" },
                new string[]{"3","three","3" },
                new string[]{"2","two","2" },
                new string[]{"1","one","1" },
            };

            Assert.Equal(expected, result);
        }
    }
}
