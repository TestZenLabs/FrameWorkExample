using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Core
{
    
    public class BaseTest
    {
        public IWebDriver Driver;

        #region Page

        public T Page<T>(IWebDriver driver) where T: BasePage
        {
            Type pageType = typeof(T);

            if (pageType!=null)
            {
                T ob = (T)Activator.CreateInstance(pageType, new object[] { driver });

                return ob;
            }
            else
            {
                return null;
            }

          
        }

        #endregion

        protected void LogMessage(string message, Action method)
        {
            TestContext.Write($"step:{message}");

            try
            {
                method();
                TestContext.WriteLine(" - Passed");
            }

            catch (Exception)
            {
                TestContext.WriteLine(" - Failed");
                throw;
            }
        }

        [SetUp]
        public void StartUp()
        {
            Driver = ChromeBrowser.Instance.GetDriver();
        }

        public void NavigateToUrl(string url, IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.Manage().Cookies.DeleteAllCookies();

            driver.Url = url;
        }

        public void CloseBrowser(IWebDriver driver)
        {
            driver.Quit();

        }
    }
}
