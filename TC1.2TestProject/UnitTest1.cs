using TC1._2_MoodAnalyse;

namespace TC1._2TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyserClass analyse = new MoodAnalyserClass("I am in Any Mood");
            string actualResult = analyse.Analyse();

            Assert.AreEqual("Sad Mood", actualResult);
        }
    }
}