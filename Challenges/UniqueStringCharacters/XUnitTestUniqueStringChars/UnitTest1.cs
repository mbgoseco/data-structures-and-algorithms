using System;
using Xunit;
using UniqueStringCharacters;

namespace XUnitTestUniqueStringChars
{
    public class UnitTest1
    {
        [Fact]
        public void StringIsUnique()
        {
            string test = "1234567890hi<?>";

            bool result = Program.AreCharactersUnique(test);

            Assert.True(result);
        }

        [Fact]
        public void StringIsNotUnique()
        {
            string test = "Hello World!";

            bool result = Program.AreCharactersUnique(test);

            Assert.False(result);
        }

        [Fact]
        public void EmptyStringIsUnique()
        {
            string test = "";

            bool result = Program.AreCharactersUnique(test);

            Assert.True(result);
        }

        [Fact]
        public void SpacesAreCharactersToo()
        {
            string test = "  <False>  ";

            bool result = Program.AreCharactersUnique(test);

            Assert.False(result);
        }
    }
}
