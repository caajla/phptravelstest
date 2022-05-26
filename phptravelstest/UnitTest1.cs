using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace phptravelstest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);

        }
        [TestMethod]
        public void TestMethod1()
        {

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            GoogleSearch.SearchParameter("phptravels");

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
