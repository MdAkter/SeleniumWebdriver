using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    public class EnterBugDetails

    {
        #region WebElement
        By SeverityDropDown = By.Id("bug_severity");
        #endregion
        #region action
        public void SelectFromSeverity(string value)
        {

        }
        #endregion
    }
}
