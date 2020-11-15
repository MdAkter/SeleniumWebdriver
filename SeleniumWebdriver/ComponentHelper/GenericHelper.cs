using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class GenericHelper
    {

        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }                                       
        }            
            public static IWebElement GetElement(By Locator)
            {
                if (IsElementPresent(Locator))
                    return ObjectRepository.driver.FindElement(Locator);
                else
                    throw new NoSuchElementException("Element not found : " + Locator.ToString());
            }
    }
} 
