﻿using OpenQA.Selenium;
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


        public void ElementToBeClickable(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementLocator));
        }

        public void ElementToBeSelected(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(elementLocator));
        }
        public void ElementExists(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elementLocator));
        }
        public void ElementIsVisible(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
        }
        public void ElementTextToBePresentInElement(IWebElement elementLocator, string textLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(configuration.timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(elementLocator, textLocator));
        }
        public void VerifyExactText(string textLocator)
        {
            By elementLocator = By.XPath("//*[contains(text(),'" + textLocator + "')]");
            ElementIsVisible(elementLocator);
            string e = driver.FindElement(elementLocator).Text;
            Assert.That(e, Is.EqualTo(textLocator));
        }
    }
}
