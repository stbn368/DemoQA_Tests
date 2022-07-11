using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        /// Step to select a checkbox with a following text
        /// </summary>
        /// <param name="checkboxText"></param>
        public void SelectCheckboxFollowingText(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to select a checkbox with an preceding text
        /// </summary>
        /// <param name="checkboxText"></param>
        public void SelectCheckboxPrecedingText(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']/preceding-sibling::input");
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

        //Step incompleted, I need to work on it
        public void SelectDate(string day, string month, string year)
        {
            By monthLocator = By.XPath("//select[@class='react-datepicker__month-select']");
            wait.ElementIsVisible(monthLocator);
            IWebElement monthDropdown = driver.FindElement(monthLocator);
            SelectElement montElement = new SelectElement(monthDropdown);
            montElement.SelectByText(month);

            By yearLocator = By.XPath("//select[@class='react-datepicker__year-select']");
            wait.ElementIsVisible(yearLocator);
            IWebElement yearDropdown = driver.FindElement(yearLocator);
            SelectElement yearElement = new SelectElement(yearDropdown);
            montElement.SelectByValue(year);

            By dayLocator = By.XPath("//div[text()='" + day + "']");
            ReadOnlyCollection<IWebElement> allDaysLocated = driver.FindElements(dayLocator);
            allDaysLocated.First().Click();

        }

        /// <summary>
        /// Step to switch to a new window
        /// </summary>
        public void SwitchNewWindows()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        /// <summary>
        /// Step to switch to a new tab
        /// </summary>
        public void SwitchNewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        /// <summary>
        /// Step to switch to the default tab
        /// </summary>
        public void SwitchDefaultTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        /// <summary>
        /// Step to close the selected tab or window
        /// </summary>
        public void CloseCurrentTab()
        {
            driver.Close();
        }
    }
}
