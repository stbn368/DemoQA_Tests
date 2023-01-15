using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test
{
    public class Wait : Base
    {
        Configuration configuration = new Configuration();

        /// <summary>
        /// Method to check if an element can be clickable
        /// </summary>
        /// <param name="elementLocator"></param>
        public void ElementToBeClickable(By elementLocator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementLocator));
            }
            catch(Exception ex)
            {
                Console.WriteLine("TimeOut Reached", ex.ToString());
            }
            
        }

        /// <summary>
        /// Method to check if an element can be selected
        /// </summary>
        /// <param name="elementLocator"></param>
        public void ElementToBeSelected(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(elementLocator));
        }

        /// <summary>
        /// Method to check if an element exists
        /// </summary>
        /// <param name="elementLocator"></param>
        public void ElementExists(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elementLocator));
        }

        /// <summary>
        /// Method to check if an element is visible
        /// </summary>
        /// <param name="elementLocator"></param>
        public void ElementIsVisible(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
        }

        /// <summary>
        /// Method to check if an element is present in a element
        /// </summary>
        /// <param name="elementLocator"></param>
        /// <param name="textLocator"></param>
        public void ElementTextToBePresentInElement(IWebElement elementLocator, string textLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(elementLocator, textLocator));
        }
    }
}
