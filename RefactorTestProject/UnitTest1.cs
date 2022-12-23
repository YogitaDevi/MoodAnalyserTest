using UC1_Refactor;

namespace RefactorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood.");
            String actualResult = obj.analyseMood();
            Assert.AreEqual("sad", actualResult);
        }
    }
}