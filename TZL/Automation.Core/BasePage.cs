using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Automation.Core
{
    public class BasePage
    {
        protected void LogMessage(string message, Action method)
        {
            TestContext.Write($"step:{message}");

            try
            {
                method();
                TestContext.WriteLine(" - Passed");
            }

            catch(Exception)
            {
                TestContext.WriteLine(" - Failed");
                throw;
            }
        }

        #region EnterText

        protected static void Input(IWebElement element, string data)
        {
            element.SendKeys(data);
        }

        protected static void ClearAndInput(IWebElement element, string data)
        {
            element.Clear();
            element.SendKeys(data);
        }

        #endregion

        #region ClickFunctions

        protected static void Click(IWebElement element)
        {
            element.Click();
        }

        protected static void MoveToElementAndClick(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);

            action.MoveToElement(element);

            element.Click();
        }


        #endregion

        #region MouseHover

        protected static void MouseHover(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);

            action.MoveToElement(element).Build().Perform();
        }

        #endregion

        #region Assert Functions

        protected static void AssertIsTrue(bool value)
        {
            Assert.IsTrue(value);
        }

        protected static void AssertAreEqual(Object actual,Object Expected)
        {
            Assert.AreEqual(actual, Expected);
        }

        #endregion
    }
}
