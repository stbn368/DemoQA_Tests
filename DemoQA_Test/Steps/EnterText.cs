using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Steps
{
    public class EnterText : Base
    {
        /// <summary>
        /// Step to locate an element together with a label and with a placeholder text, and enter text
        /// </summary>
        /// <param name="labelText"></param>
        /// <param name="placeholderText"></param>
        /// <param name="text"></param>
        public void EnterTextInputWithLabelAndPlaceholder(string labelText, string placeholderText, string text)
        {
            By elementLocator = By.XPath("//*[text()='"+ labelText +"']/following::div/input[@placeholder='"+ placeholderText +"']");
            driver.FindElement(elementLocator).SendKeys(text);
        }

        /// <summary>
        /// Step to locate an element together with a label and with a placeholder text, and enter text. It has been implemented
        /// for a specified page where the locator need to be different with the rest found in the web side
        /// </summary>
        /// <param name="labelText"></param>
        /// <param name="placeholderText"></param>
        /// <param name="text"></param>
        public void PageSpecifiedEnterTextInputWithLabelAndPlaceholder(string labelText, string placeholderText, string text)
        {
            By elementLocator = By.XPath("//*[text()='" + labelText + "']/following::div/*/*/input[@value='" + placeholderText + "']");
            driver.FindElement(elementLocator).Clear();
            driver.FindElement(elementLocator).SendKeys(text);
        }

        /// <summary>
        /// Step to locate an element together with a textareaLabel and with a placeholder text, and enter text
        /// </summary>
        /// <param name="labelTextarea"></param>
        /// <param name="placeholderText"></param>
        /// <param name="text"></param>
        public void EnterTextTexareaWithLabelAndPlaceholder(string labelTextarea, string placeholderText, string text)
        {
            By elementLocator = By.XPath("//*[text()='" + labelTextarea + "']/following::div/textarea[@placeholder='" + placeholderText + "']");
            driver.FindElement(elementLocator).SendKeys(text);
        }

        /// <summary>
        /// Step to locate an element together a textarea and enter text
        /// </summary>
        /// <param name="labelTextarea"></param>
        /// <param name="text"></param>
        public void EnterTextTexareaWithLabel(string labelTextarea, string text)
        {
            By elementLocator = By.XPath("//*[text()='" + labelTextarea + "']/following::div/textarea");
            driver.FindElement(elementLocator).SendKeys(text);
        }
    }
}
