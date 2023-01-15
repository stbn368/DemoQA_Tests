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

        /// <summary>
        /// Step to switch to the iframe with id
        /// </summary>
        /// <param name="frameId"></param>
        public void SwitchToFrame(string frameId)
        {
            driver.SwitchTo().Frame(frameId);
        }

        /// <summary>
        /// Step to switch to the parent iframe
        /// </summary>
        public void SwitchDefaultFrame()
        {
            driver.SwitchTo().ParentFrame();
        }

        /// <summary>
        /// Step to switch to the iframe with index
        /// </summary>
        /// <param name="frameIndex"></param>
        public void SwitchFrameIndex(int frameIndex)
        {
            driver.SwitchTo().Frame(frameIndex);
        }

        /// <summary>
        /// Step to open the accodian tab and check if it has been opened
        /// </summary>
        /// <param name="accordianText"></param>
        public void OpenAccordianTab(string accordianText)
        {
            By locatorAccordianTab = By.XPath("//*[text()='" + accordianText + "']");
            wait.ElementToBeClickable(locatorAccordianTab);
            driver.FindElement(locatorAccordianTab).Click();

            //verify accordion tab is opened
            By locatorAccordionTabOpened = By.XPath("//*[text()='" + accordianText + "']/following-sibling::div");
            wait.ElementExists(locatorAccordionTabOpened);

            By locatorClassAccordionTabOpened = By.XPath("//*[text()='" + accordianText + "']/following-sibling::div[@class='collapse show']");
            wait.ElementExists(locatorClassAccordionTabOpened);
            var classValue = driver.FindElement(locatorAccordionTabOpened).GetAttribute("class");

            Assert.AreEqual("collapse show", classValue, "Step Fail. The accordian tab is not opened");

        }

        /// <summary>
        /// Step to close the accodian tab and check if it has been closed
        /// </summary>
        /// <param name="accordianText"></param>
        public void CloseAccordianTab(string accordianText)
        {
            By locatorAccordianTab = By.XPath("//*[text()='" + accordianText + "']");
            wait.ElementToBeClickable(locatorAccordianTab);
            driver.FindElement(locatorAccordianTab).Click();

            //verify accordion tab is closed
            By locatorAccordionTabOpened = By.XPath("//*[text()='" + accordianText + "']/following-sibling::div");
            wait.ElementExists(locatorAccordionTabOpened);

            By locatorClassAccordionTabOpened = By.XPath("//*[text()='" + accordianText + "']/following-sibling::div[@class='collapse']");
            wait.ElementExists(locatorClassAccordionTabOpened);
            var classValue = driver.FindElement(locatorAccordionTabOpened).GetAttribute("class");

            Assert.AreEqual("collapse", classValue, "Step Fail. The accordian tab is not closed");
        }

        /// <summary>
        /// Method to check if the form is open to interact
        /// </summary>
        /// <returns>If the checked class is available, the form is open</returns>
        public bool CheckDateFormOpen()
        {
            bool verificator = false;

            By elementLocator = By.Id("datePickerMonthYearInput");
            wait.ElementToBeClickable(elementLocator);

            var getClass = driver.FindElement(elementLocator).GetAttribute("class");

            if (getClass.Equals(""))
            {
                driver.FindElement(elementLocator).Click();
                verificator = true;
            }
            else
            {
                verificator = true;
            }

            return verificator;
        }

        /// <summary>
        /// Step to selec a day in the form
        /// </summary>
        /// <param name="day"></param>
        /// <exception cref="ElementNotInteractableException"></exception>
        public void SelectDay(int day)
        {
            if (!CheckDateFormOpen())
            {
                throw new ElementNotInteractableException("The date form couldn't be opened");
            }

            By elementLocator = By.XPath("//div[@class='react-datepicker__month']//div[text()=" + day + "]");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElements(elementLocator).First().Click();
        }

        /// <summary>
        /// Step to select a month
        /// </summary>
        /// <param name="month"></param>
        /// <exception cref="ElementNotInteractableException"></exception>
        public void SelectMonth(string month)
        {
            if (!CheckDateFormOpen())
            {
                throw new ElementNotInteractableException("The date form couldn't be opened");
            }

            By elementLocator = By.XPath("//div[@class='react-datepicker__month-dropdown-container react-datepicker__month-dropdown-container--select']/select");
            wait.ElementToBeClickable(elementLocator);

            SelectElement dropDown = new SelectElement(driver.FindElement(elementLocator));
            dropDown.SelectByText(month);
        }

        /// <summary>
        /// Step to select a year
        /// </summary>
        /// <param name="year"></param>
        /// <exception cref="ElementNotInteractableException"></exception>
        public void SelectYear(string year)
        {
            if (!CheckDateFormOpen())
            {
                throw new ElementNotInteractableException("The date form couldn't be opened");
            }

            By elementLocator = By.XPath("//div[@class='react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--select']/select");
            wait.ElementToBeClickable(elementLocator);

            SelectElement dropDown = new SelectElement(driver.FindElement(elementLocator));
            dropDown.SelectByText(year);
        }


    }
}
