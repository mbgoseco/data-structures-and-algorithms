using System;
using Xunit;
using StacksAndQueues.Classes;
using MultiBracketValidation;

namespace XUnitTestMBV
{
    public class UnitTest1
    {
        [Fact]
        public void TrueWithMixedBrackets()
        {
            string str = "[{}{}{}{}]([][][][]){()()()()}";

            bool result = Program.MultiBracketValidation(str);

            Assert.True(result);
        }

        [Fact]
        public void TrueWithJunk()
        {
            string str = "(j)[(u)]n{k}";

            bool result = Program.MultiBracketValidation(str);

            Assert.True(result);
        }

        [Fact]
        public void TrueWithJunkInTheTrunk()
        {
            string str = "[]([]{}){()}--- -00000---JunkInTheTrunk";

            bool result = Program.MultiBracketValidation(str);

            Assert.True(result);
        }

        [Fact]
        public void FalseWithSingleChar()
        {
            string str = "}";

            bool result = Program.MultiBracketValidation(str);

            Assert.False(result);
        }

        [Fact]
        public void FalseWhenEmpty()
        {
            string str = "       ";

            bool result = Program.MultiBracketValidation(str);

            Assert.False(result);
        }

        [Fact]
        public void FalseWhenOnlyJunk()
        {
            string str = "dsjnfkjsgk;adaj";

            bool result = Program.MultiBracketValidation(str);

            Assert.False(result);
        }
    }
}
