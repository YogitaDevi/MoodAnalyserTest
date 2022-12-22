using TC1._1_MoodAnalyse;

namespace TC1._1TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyseClass analyse = new MoodAnalyseClass("I am in Sad Mood");
            string actualResult = analyse.Analyse();

            Assert.AreEqual("Sad Mood", actualResult);
        }
    }
}