using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test
{
    public class Base
    {
        protected static IWebDriver driver;

        Configuration configuration = new Configuration();

        // Configuration at the beginning of every test
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(configuration.URL);
            driver.Manage().Window.Maximize();
        }

        // Configuration at the end of every test
        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }

    }
}
