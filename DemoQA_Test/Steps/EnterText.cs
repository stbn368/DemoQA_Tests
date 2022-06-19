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
        public void EnterTextInputWithLabelAndPlaceholder(string labelText, string placeholderText, string text)
        {
            By elementLocator = By.XPath("//*[text()='"+ labelText +"']/following::div/input[@placeholder='"+ placeholderText +"']");
            driver.FindElement(elementLocator).SendKeys(text);
        }
        public void EnterTextTexareaWithLabelAndPlaceholder(string labelTextarea, string placeholderText, string text)
        {
            By elementLocator = By.XPath("//*[text()='" + labelTextarea + "']/following::div/textarea[@placeholder='" + placeholderText + "']");
            driver.FindElement(elementLocator).SendKeys(text);
        }
        public void EnterTextTexareaWithLabel(string labelTextarea, string text)
        {
            By elementLocator = By.XPath("//*[text()='" + labelTextarea + "']/following::div/textarea");
            driver.FindElement(elementLocator).SendKeys(text);
        }
    }
}
