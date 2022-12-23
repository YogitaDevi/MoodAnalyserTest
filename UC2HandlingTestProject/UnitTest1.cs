using UC2_HandleException;

namespace UC2HandlingTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void TestMethodAnalyserForHappyMood()
        {
            string message = "Im in happy mood";
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string Actual = moodAnalyser.Analyser();

            Assert.AreEqual(expected, Actual);
        }
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void TestMethodAnalayserForSadMood()
        {
            string message = "Im in sad mood";
            string expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string Actual = moodAnalyser.Analyser();

            Assert.AreEqual(expected, Actual);
        }
        [TestMethod]
        [TestCategory("Null Case")]
        public void GivenNullReturnHappyMood()
        {
            string message = "null";
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string Actual = moodAnalyser.Analyser();

            Assert.AreEqual(expected, Actual);
        }
    }
    
}