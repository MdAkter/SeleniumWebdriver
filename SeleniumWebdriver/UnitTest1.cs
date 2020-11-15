using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5001/");
            driver.Close();
            driver.Quit();

            
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
            Console.WriteLine(BrowserType.Chrome);

            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser : {0}", config.GetBrowser());
            Console.WriteLine("Username : {0}", config.GetUsername());
            Console.WriteLine("Password : {0}", config.GetPassword());
        }
    }
}
