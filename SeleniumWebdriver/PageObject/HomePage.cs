using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    class HomePage
    {
        #region WebElement

        private By QuickSearchTextBox = By.Id("quicksearch_main");
        private By QucksearchBtn = By.Id("find");
        private By FileABugLink = By.Id("File a Bug");

        #endregion
        #region actions
        public void Quicksearch(String text)
        {
            ObjectRepository.driver.FindElement(QuickSearchTextBox).SendKeys(text);
            ObjectRepository.driver.FindElement(QucksearchBtn).Click();

        }
        #endregion
        #region Navigation
        public LoginPage NavigateToLogin()
        {
            ObjectRepository.driver.FindElement(FileABugLink).Click();
            return new LoginPage();
        
        }
        #endregion
    }
}
