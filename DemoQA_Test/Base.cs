using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoQA_Test
{
    public class Base
    {
        //Before the DriverManager() implementation
        protected static IWebDriver driver;

        //protected static IWebDriver driver = driverImplementation();

        Configuration configuration = new Configuration();
        
        /*public static void driverImplementation()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();
        }*/

        // Configuration at the beginning of every test
        [SetUp]
        public void Setup()
        {
            //Before the DriverManager() implementation
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(configuration.URL);
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
