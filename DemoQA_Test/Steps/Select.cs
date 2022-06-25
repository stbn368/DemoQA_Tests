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
        Wait wait = new Wait();

        /// <summary>
        /// Step to select a checkbox with a text
        /// </summary>
        /// <param name="checkboxText"></param>
        public void SelectCheckboxText(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to navigate until the down of the page
        /// </summary>
        public void ScrollDown()
        {
            driver.ExecuteJavaScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        /// <summary>
        /// Step to navigate until a element
        /// </summary>
        /// <param name="elementText"></param>
        public void ScrollToElement(string elementText)
        {
            By elementLocator = By.XPath("//*[text()='" + elementText + "']");
            IWebElement element = driver.FindElement(elementLocator);
            driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
            //((JavascriptExecutor)driver).executeScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
