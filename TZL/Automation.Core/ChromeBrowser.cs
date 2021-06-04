using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Core
{
    class ChromeBrowser
    {
     
    private static ChromeBrowser _instance;

    public static ChromeBrowser Instance
    {
            get
            {
                if (_instance == null)
                {
                    _instance = Activator.CreateInstance<ChromeBrowser>();
                }

               return _instance;
            }
     
    }


        public IWebDriver GetDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("disable-infobars");

            options.AddArguments("--disable-web-security");

            options.AddArguments("--allow-running-insecure-content");

            return new ChromeDriver(options);
        }
        
    }
}
