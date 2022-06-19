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
        Select select = new Select();
        EnterText enterText = new EnterText();

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
            enterText.EnterTextInputWithLabelAndPlaceholder("Full Name", "Full Name", "Esteban Calderón Moya");
            enterText.EnterTextInputWithLabelAndPlaceholder("Email", "name@example.com", "esteban@testing.com");
            enterText.EnterTextTexareaWithLabelAndPlaceholder("Current Address", "Current Address", "Dirección actual");
            enterText.EnterTextTexareaWithLabel("Permanent Address", "Dirección permanente");
            select.ScrollAll();
            click.ClickButtonText("Submit");
            verify.VerifyExactTextExist("Esteban Calderón Moya");
            verify.VerifyExactTextExist("esteban@testing.com");
            verify.VerifyExactTextExist("Dirección actual");
            verify.VerifyExactTextExist("Dirección permanente");

            //Thread.Sleep(3000);
        }
        [Test, Order(1)]
        public void ElementsChecktBox()
        {
            click.ClickElement("Elements");
            verify.VerifyExactText("Please select an item from left to start practice.");
            click.ClickElementText("Check Box");
            verify.VerifyCheckboxTextExit("Home");
            select.SelectCheckboxText("Home");
            verify.VerifyExactText("You have selected :");
            verify.VerifyExactText("home");
            verify.VerifyButtonTooltipExit("Toggle");
            verify.VerifyButtonTooltipExit("Expand all");
            click.ClickButtonTooltip("Toggle");
            click.ClickButtonTooltip("Expand all");
            verify.VerifyCheckboxTextExit("Desktop");

            //Thread.Sleep(10000);
        }



    }
}
