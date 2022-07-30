using DemoQA_Test.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Tests
{
    public class WidgetsPage : Base
    {
        Click click = new Click();
        Verify verify = new Verify();
        Select select = new Select();
        EnterText enterText = new EnterText();

        [Test, Order(0)]
        public void AccordianTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            select.ScrollToElement("Accordian");
            click.ClickElementText("Accordian");
            verify.VerifyExactTextExist("What is Lorem Ipsum?");
            verify.VerifyExactTextExist("Where does it come from?");
            verify.VerifyExactTextExist("Why do we use it?");

            verify.VerifyOpenAccordianTab("What is Lorem Ipsum?");
            verify.VerifyCloseAccordianTab("Where does it come from?");

            select.ScrollToElement("Where does it come from?");
            select.OpenAccordianTab("Where does it come from?");
            select.CloseAccordianTab("Where does it come from?");

            select.ScrollToElement("Why do we use it?");
            select.OpenAccordianTab("Why do we use it?");
            select.CloseAccordianTab("Why do we use it?");

        }
    }
}
