using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
   public class LoginPage
    {
        #region WebElement
        private By LoginTextBox = By.Id("Bugzilla_login");
        private By PasswordTextBox = By.Id("Bugzilla_login");
        private By LoginBtn = By.Id("log_in");
        private By HomeLink = By.LinkText("Home");

        #endregion
        #region Actions
        public EnterBugDetails Login(string username, string password)
        {
            ObjectRepository.driver.FindElement(LoginTextBox).SendKeys(username);
            ObjectRepository.driver.FindElement(PasswordTextBox).SendKeys(password);
            ObjectRepository.driver.FindElement(LoginBtn).Click();
            return new EnterBugDetails();
        }
        #endregion
        #region Navigation
        public void NavigateToHome()
        {
            ObjectRepository.driver.FindElement(HomeLink).Click();
        }

        #endregion
    }

}
