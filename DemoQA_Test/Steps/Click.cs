using Ocelot.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Steps
{
    public class Click : Base
    {
        Verify verify = new Verify();
        Configuration configuration = new Configuration();

        public void ClickElement(string textElement)
        {
            By elementLocator = By.XPath("//*[contains(text(),'" + textElement + "')]/parent::div/parent::div");
            verify.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }
        public void ClickElementText(string textElement)
        {
            By elementLocator = By.XPath("//*[contains(text(),'" + textElement + "')]");
            verify.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();

        }


    }
}
