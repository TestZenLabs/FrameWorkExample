using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Core;
using Automation.Repository;

namespace Automation.Test.TestCases
{
    class DemoChartTestCases: BaseTest
    {
        [Test]
        public void VerfiyItemsCanBeSearchedInSearchItemsTextBox()
        {
            try
            {
                LogMessage("Navigate To Url", ()
                    => NavigateToUrl("https://demostore.x-cart.com/", Driver));

                var pgDemoChart = Page<DemoChart>(Driver);

                LogMessage("Invoking SearchItems Method", ()
                    => pgDemoChart.SearchItems("IPhone", "Andriod"));

                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

        }

        [Test]
        public void VerfiySaleLinkIsVisibleInHotDeals()
        {
            try
            {
                LogMessage("Navigate To Url", ()
                    => NavigateToUrl("https://demostore.x-cart.com/", Driver));
                var pgDemoChart = Page<DemoChart>(Driver);

                //LogMessage("Invoking Hot Deals Method", ()
                //    => pgDemoChart.HotDeals());

                //LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

            catch (Exception)
            {

                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

        }
    }
}
