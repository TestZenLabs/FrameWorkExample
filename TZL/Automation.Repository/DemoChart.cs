using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Core;
using OpenQA.Selenium;

namespace Automation.Repository
{
    public class DemoChart : BasePage
    {
        readonly IWebDriver _driver = null;

        #region Constructor

        public DemoChart(IWebDriver driver)
        {
            _driver = driver;
        }

        #endregion

        #region Object Repository

        private IWebElement SearchTestItems => _driver.css("input[placeholder='Search items...']");

        private IList<IWebElement> HotDealsLink => _driver.Allcss(".primary-title");

        private IWebElement Sale => _driver.LinkText("Sale");

        #endregion

        #region TestCase Methods

        public void SearchItems(string value1, string value2)
        {
            LogMessage("Entering a Value into Search Items Text Box", ()
                => Input(SearchTestItems, value1));

            LogMessage("Entering a Value into Search Items Text Box", ()
             => ClearAndInput(SearchTestItems, value2));
        }

        public void HotDeals()
        {
            LogMessage("Mouse Hover On Hot Deals Text", () => MouseHover(HotDealsLink[1], _driver));

            LogMessage("Click On Sale Text", () => Click(Sale));
        }


        #endregion

    }
}
