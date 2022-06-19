using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Steps
{
    public class Select : Base
    {
        Verify verify = new Verify();
        public void SelectCheckboxText(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']");
            verify.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }
        public void ScrollAll()
        {
            driver.ExecuteJavaScript("window.scrollTo(0, document.body.scrollHeight);");
        }
    }
}
