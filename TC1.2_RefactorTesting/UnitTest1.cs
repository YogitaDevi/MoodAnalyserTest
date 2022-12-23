using TC1._2_Refactor;
namespace TC1._2_RefactorTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in happy mood");
            String actualResult = obj.analyseMood();
            Assert.AreEqual("happy", actualResult);
        }
    }
}