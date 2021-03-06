﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            //INavigation page= ObjectRepository.driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            //ObjectRepository.driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine("Title of the page : {0}", WindowHelper.GetTitle());
        }
    }
}
