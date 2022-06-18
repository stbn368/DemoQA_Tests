using OpenQA.Selenium;
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
    }
}
