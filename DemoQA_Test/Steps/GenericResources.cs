using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Steps
{
    public class GenericResources : Base 
    {
        public static string GetElementByXpath(string textLocator)
        {
            string[] xpathLocator =
            {
                "//*[contains(text(),'" + textLocator + "')]/parent::div/parent::div",
                "//*[text()='" + textLocator + "']",
                "//button[@title='" + textLocator + "']",
                "//button[text()='" + textLocator + "']",
                "//*[@id='" + textLocator + "']",
                "//input[@type='radio']/following::label[text() = '" + textLocator + "']",
                "//a[text()='" + textLocator + "' and @href]",
                "//*[@class='" + textLocator + "']"
            };

            return string.Join(" | ", xpathLocator);
        }
    }
}
