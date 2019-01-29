using System;
using Xunit;
using FizzBuzzTree;
using HappyTrees.Classes;

namespace XUnitTestFBT
{
    public class UnitTest1
    {
        [Fact]
        public void NodeReturnsFizz()
        {
            Program.ArrayList.Clear();
            Node node = new Node(12);

            object[] result = Program.FizzBuzzTree(node);

            Assert.Equal("Fizz", result[0]);
        }

        [Fact]
        public void NodeReturnsBuzz()
        {
            Program.ArrayList.Clear();
            Node node = new Node(25);

            object[] result = Program.FizzBuzzTree(node);

            Assert.Equal("Buzz", result[0]);
        }

        [Fact]
        public void NodeReturnsFizzBuzz()
        {
            Program.ArrayList.Clear();
            Node node = new Node(60);

            object[] result = Program.FizzBuzzTree(node);

            Assert.Equal("FizzBuzz", result[0]);
        }

        [Fact]
        public void NodeReturnsSeven()
        {
            Program.ArrayList.Clear();
            Node node = new Node(7);

            object[] result = Program.FizzBuzzTree(node);

            Assert.Equal(7, result[0]);
        }
    }
}
