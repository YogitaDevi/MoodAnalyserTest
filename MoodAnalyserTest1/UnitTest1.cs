using UC1_MoodAnalyse;

namespace MoodAnalyserTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            MoodAnalyser analyse = new MoodAnalyser("I am in Sad Mood");
            string actualResult = analyse.Analyse();

            Assert.AreEqual("Sad Mood", actualResult);
        }
    }
}