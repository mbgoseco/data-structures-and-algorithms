using System;
using Xunit;
using RepeatedWord;
using HashTables.Classes;

namespace XUnitTestRepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindRepeatInParagraph()
        {
            string paragraph = "A team of researchers looked at 31 marine populations and found that the populations of 78% of marine mammals and 75% of sea turtles rebounded after receiving protections under the law.";

            var result = Program.RepeatedWord(paragraph);

            Assert.Equal("populations", result);
        }

        [Fact]
        public void ParagraphWithNoRepeatsReturnsNull()
        {
            string paragraph = "This is Michael Goseco. I am penning in order to prove that we can write a paragraph without repeating any word. Google helped me by showing the synonyms of many terms. Myself, being an optimistic wordsmith has tried my level best now. Thanks for reading till end.";

            var result = Program.RepeatedWord(paragraph);

            Assert.Null(result);
        }

        [Fact]
        public void EmptyStringReturnsNull()
        {
            string emptyString = "";

            var result = Program.RepeatedWord(emptyString);

            Assert.Null(result);
        }
    }
}
