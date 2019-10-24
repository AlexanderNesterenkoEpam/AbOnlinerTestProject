using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        DriverCreator dr;

        [SetUp]
        public void SetUp()
        {
            dr = new DriverCreator();
        }

        /// <summary>
        /// Summary Test Case 1
        /// </summary>
        [Test]
        public void TestAutoTitleTest()
        {
            const string ExpectedTitle = "Автобарахолка";

            var driver = dr.GetDriver();

            driver.Navigate().GoToUrl("https://ab.onliner.by");

            driver.Manage().Window.Maximize();

            string titleText = driver.FindElement(By.XPath("//h1[contains(@class, 'm-title')]")).Text;

            Assert.AreEqual(ExpectedTitle, titleText);
        }


        [TearDown]
        public void TearDown()
        {
            dr.QuitDriver();
        }
    }
}
