using SeleniumWebdriver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetUsername();
        String GetPassword();
        String GetWebsite();
    }
}
