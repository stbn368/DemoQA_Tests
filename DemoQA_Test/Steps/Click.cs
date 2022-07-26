using Microsoft.Graph;
using Ocelot.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        Wait wait = new Wait();

        /// <summary>
        /// Step to locate and click elements in the home page
        /// </summary>
        /// <param name="textElement"></param>
        public void ClickElement(string textElement)
        {
            By elementLocator = By.XPath("//*[contains(text(),'" + textElement + "')]/parent::div/parent::div");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to locate and click elements in the left sidebar
        /// </summary>
        /// <param name="textElement"></param>
        public void ClickElementText(string textElement)
        {
            By elementLocator = By.XPath("//*[text()='" + textElement + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to locate and click in a button using the title parameter, that it is the tooltip shown
        /// </summary>
        /// <param name="buttonTooltipText"></param>
        public void ClickButtonTooltip(string buttonTooltipText)
        {
            By elementLocator = By.XPath("//button[@title='" + buttonTooltipText + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to locate and click on a button with a specified text
        /// </summary>
        /// <param name="buttonText"></param>
        public void ClickButtonText(string buttonText)
        {
            By elementLocator = By.XPath("//button[text()='"+ buttonText + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to locate and click on a button with an id
        /// </summary>
        /// <param name="buttonId"></param>
        public void ClickButtonId(string buttonId)
        {
            By elementLocator = By.XPath("//*[@id='" + buttonId + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to locate and click on a radio button with a specified text
        /// </summary>
        /// <param name="radioButtonText"></param>
        public void ClickRadioButtonText(string radioButtonText)
        {
            By elementLocator = By.XPath("//input[@type='radio']/following::label[text() = '" + radioButtonText + "']");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to double click on a button with a specified text
        /// </summary>
        /// <param name="buttonText"></param>
        public void DoubleClickButtonText(string buttonText)
        {
            By elementLocator = By.XPath("//button[text()='" + buttonText + "']");
            wait.ElementToBeClickable(elementLocator);
            IWebElement element = driver.FindElement(elementLocator);
            
            Actions actions = new Actions(driver);
            actions.DoubleClick(element);
            actions.Build().Perform();
        }

        /// <summary>
        /// Step to right click on a button with a specified text
        /// </summary>
        /// <param name="buttonText"></param>
        public void RightClickButtonText(string buttonText)
        {
            By elementLocator = By.XPath("//button[text()='" + buttonText + "']");
            wait.ElementToBeClickable(elementLocator);
            IWebElement element = driver.FindElement(elementLocator);

            Actions actions = new Actions(driver);
            actions.ContextClick(element);
            actions.Build().Perform();
        }

        /// <summary>
        /// Step to click in a link with text
        /// </summary>
        /// <param name="linkText"></param>
        public void ClickLinkText(string linkText)
        {
            By elementLocator = By.XPath("//a[text()='" + linkText + "' and @href]");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to locate a button together a text and click on it
        /// </summary>
        /// <param name="buttonText"></param>
        /// <param name="text"></param>
        public void ClickButtonTextTogetherText(string buttonText, string text)
        {
            By elementLocator = By.XPath("//*[text()='" + text + "']/following::button[text()='" + buttonText + "'][1]");
            wait.ElementToBeClickable(elementLocator);
            driver.FindElement(elementLocator).Click();
        }

        /// <summary>
        /// Step to accept an alert
        /// </summary>
        public void AcceptSimpleAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Step to accept an alert after a few seconds
        /// </summary>
        /// <param name="seconds"></param>
        public void AcceptSimpleAlertAfterTime(int seconds)
        {
            Thread.Sleep(seconds);
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Step to dimiss an alert
        /// </summary>
        public void DimissAlert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

    }
}
