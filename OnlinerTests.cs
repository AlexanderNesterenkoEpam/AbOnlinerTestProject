using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestFixture]
    public class OnlinerTests
    {
        DriverCreator dr;

        [SetUp]
        public void SetUp()
        {
            dr = new DriverCreator();
        }

        /// <summary>
        /// The first test - test case #1
        /// </summary>
        [Test]
        public void AutoTitleTest()
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
