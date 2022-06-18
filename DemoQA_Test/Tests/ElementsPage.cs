using DemoQA_Test.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Tests
{
    public class ElementsPage : Base
    {
        Click click = new Click();
        Verify verify = new Verify();

        [Test, Order(0)]
        public void ElementsTextBox()
        {
            click.ClickElement("Elements");
            verify.VerifyExactText("Please select an item from left to start practice.");
            click.ClickElementText("Text Box");
            verify.VerifyExactText("Full Name");
            verify.VerifyExactText("Email");
            verify.VerifyExactText("Current Address");
            verify.VerifyExactText("Permanent Address");

            Thread.Sleep(3000);
        }
        [Test, Order(1)]
        public void ElementsChecktBox()
        {
            click.ClickElement("Elements");
            verify.VerifyExactText("Please select an item from left to start practice.");
            click.ClickElementText("Check Box");

            Thread.Sleep(3000);
        }



    }
}
