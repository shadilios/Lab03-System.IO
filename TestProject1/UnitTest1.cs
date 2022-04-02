using System;
using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestChallengeOne()
        {
            Assert.Equal(27, Program.ChallengeOne("3 3 3"));
            Assert.Equal(27, Program.ChallengeOne("3 3 3 9 9 9 9 9"));
            Assert.Equal(0, Program.ChallengeOne("3 3"));
            Assert.Equal(-27, Program.ChallengeOne("-3 -3 -3"));

        }

        [Fact]
        public void TestChallengeTwo()
        {
            Assert.Equal(3, Program.ChallengeTwo(new int[] { 3, 3, 3 }));
            Assert.Equal(10, Program.ChallengeTwo(new int[] { 4, 8, 15, 16 }));
            Assert.Equal(0, Program.ChallengeTwo(new int[] { 0, 0, 0 }));

        }

        [Fact]
        public void TestChallengeFive()
        {
            Assert.Equal(-1, Program.ChallengeFive(new int[] { -5, -70, -23, -65, -23, -54, -16, -1, -43, -99, -73, -87 }));
            Assert.Equal(1, Program.ChallengeFive(new int[] { 1, 1, 1, 1, 1, 1 }));

        }

        [Fact]
        public void TestChallengeNine()
        {
            //it returns the correct array?
            string firstTest = "Hello Shadi";
            Assert.Equal(new string[] { "Hello: 5", "Shadi: 5" }, Program.ChallengeNine(firstTest));

            //it returns an array?
            string secondTest = "Hello everyone";
            Assert.Equal("System.String[]", Convert.ToString(Program.ChallengeNine(secondTest).GetType()));

            //use symbols
            string thirdTest = "C# is @we5ome!";
            Assert.Equal(new string[] { "C#: 2", "is: 2", "@we5ome!: 8" }, Program.ChallengeNine(thirdTest));


        }
    }
}
