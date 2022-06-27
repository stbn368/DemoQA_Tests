using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Steps
{
    public class Verify : Base
    {
        Configuration configuration = new Configuration();
        Wait wait = new Wait();

        /// <summary>
        /// Step to verify if an exact text is available in an element
        /// </summary>
        /// <param name="textLocator"></param>
        public void VerifyExactText(string textLocator)
        {
            By elementLocator = By.XPath("//*[text()='" + textLocator + "']");
            wait.ElementIsVisible(elementLocator);
            string e = driver.FindElement(elementLocator).Text;
            Assert.That(e, Is.EqualTo(textLocator));
        }

        /// <summary>
        /// Step to verify if an exact text is visible
        /// </summary>
        /// <param name="textLocator"></param>
        public void VerifyExactTextExist(string textLocator)
        {
            By elementLocator = By.XPath("//*[text()='" + textLocator + "']");
            wait.ElementIsVisible(elementLocator);
        }

        /// <summary>
        /// Step to verify if a checkbox with a text is visible
        /// </summary>
        /// <param name="checkboxText"></param>
        public void VerifyCheckboxTextExit(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']");
            wait.ElementIsVisible(elementLocator);
        }

        /// <summary>
        /// Step to verify if a checkbox with a text does not visible
        /// </summary>
        /// <param name="checkboxText"></param>
        /// <exception cref="Exception"></exception>
        //public void VerifyCheckboxDoesNotTextExit(string checkboxText)
        //{
        //    By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']");
        //    ElementIsVisible(elementLocator);
        //}

        /// <summary>
        /// Step to verify that a checkbox is marked
        /// </summary>
        /// <param name="checkboxText"></param>
        public void VerifyCheckboxIsChecked(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']/preceding-sibling::span/*");
            wait.ElementIsVisible(elementLocator);
            var getClassText = driver.FindElement(elementLocator).GetAttribute("class");
            if (!getClassText.Contains("uncheck"))
            {
                Assert.True(true, "The checkbox {0} is checked", checkboxText);
            }
            else
            {
                throw new Exception("The checkbox " + checkboxText + " is not checked");
            }
        }

        /// <summary>
        /// Step to verify that a checkbox is unmarked
        /// </summary>
        /// <param name="checkboxText"></param>
        /// <exception cref="Exception"></exception>
        public void VerifyCheckboxIsNotChecked(string checkboxText)
        {
            By elementLocator = By.XPath("//input[@type='checkbox']/following::*[text() = '" + checkboxText + "']/preceding-sibling::span/*");
            wait.ElementIsVisible(elementLocator);
            var getClassText = driver.FindElement(elementLocator).GetAttribute("class");
            if (getClassText.Contains("uncheck"))
            {
                Assert.True(true, "The checkbox {0} is not checked", checkboxText);
            }
            else
            {
                throw new Exception("The checkbox " + checkboxText + " is checked");
            }
        }

        /// <summary>
        /// Step to verify that a button with a tooltip text is visible
        /// </summary>
        /// <param name="buttonTooltipText"></param>
        public void VerifyButtonTooltipExit(string buttonTooltipText)
        {
            By elementLocator = By.XPath("//button[@title='" + buttonTooltipText + "']");
            wait.ElementIsVisible(elementLocator);
        }

        /// <summary>
        /// Step to verify that a radio button is visible
        /// </summary>
        /// <param name="radioButtonText"></param>
        public void VerifyRadioButtonTextExit(string radioButtonText)
        {
            By elementLocator = By.XPath("//input[@type='radio']/following::label[text() = '" + radioButtonText + "']");
            wait.ElementIsVisible(elementLocator);
        }

        /// <summary>
        /// Step to verify that a button with a text is visible
        /// </summary>
        /// <param name="buttonText"></param>
        public void VerifyButtonTextExit(string buttonText)
        {
            By elementLocator = By.XPath("//button[text() = '" + buttonText + "']");
            wait.ElementIsVisible(elementLocator);
        }

        /// <summary>
        /// Step to verify text in a row when the table is created with the <div></div> tags
        /// The step uses index to locate the row and the position of the text
        /// </summary>
        /// <param name="row"></param>
        /// <param name="index"></param>
        /// <param name="text"></param>
        public void VerifyTextTableIndex(int row, int index, string text)
        {
            By elementLocator = By.XPath("//div[@role='rowgroup'][" + row + "]/descendant::*[" + index + "]");
            wait.ElementIsVisible(elementLocator);

            var getText = driver.FindElement(elementLocator).Text;

            Assert.IsTrue(getText.Equals(text), "The text expected was " + text + " but the text found was " + getText + "");
        }


    }
}
