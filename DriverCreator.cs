using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace UnitTestProject1
{
    public class DriverCreator
    {
        ChromeDriver driver;

        public ChromeDriver GetDriver()
        {
            double timeOutSec = 15;
            new DriverManager().SetUpDriver(new ChromeConfig());
            var service = ChromeDriverService.CreateDefaultService();
            var option = new ChromeOptions();
            option.AddArgument("disable-infobars");
            option.AddArgument("--no-sandbox");
            driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeOutSec));

            return driver; 
        }

        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
