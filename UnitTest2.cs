using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest2
    {
        //MoodAnalyser moodAnalyser;
        //string message = " I am in happy Mood";
        [TestInitialize]
        public void SetUp()
        {
            //moodAnalyser = new MoodAnalyser(message);
        }
        [TestMethod]
        public void TestMethodForHappyMood()

        {
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()

        {
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}