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
            select.ScrollToElement("Submit");
            verify.VerifyButtonTextExit("Submit");
            click.ClickButtonText("Submit");
            verify.VerifyExactTextExist("Esteban Calderón Moya");
            verify.VerifyExactTextExist("esteban@testing.com");
            verify.VerifyExactTextExist("Dirección actual");
            verify.VerifyExactTextExist("Dirección permanente");
        }
        [Test, Order(1)]
        public void ElementsChecktBox()
        {
            click.ClickElement("Elements");
            verify.VerifyExactText("Please select an item from left to start practice.");
            click.ClickElementText("Check Box");
            verify.VerifyCheckboxTextExit("Home");
            verify.VerifyButtonTooltipExit("Toggle");
            verify.VerifyButtonTooltipExit("Expand all");
            click.ClickButtonTooltip("Expand all");
            verify.VerifyCheckboxTextExit("Desktop");
            verify.VerifyCheckboxTextExit("Angular");
            select.SelectCheckboxText("Office");
            verify.VerifyExactText("You have selected :");
            verify.VerifyCheckboxIsChecked("Public");
            verify.VerifyCheckboxIsChecked("Private");
            verify.VerifyCheckboxIsNotChecked("Angular");
            click.ClickButtonTooltip("Collapse all");
        }
        [Test, Order(2)]
        public void ElementsRadioButton()
        {
            click.ClickElement("Elements");
            verify.VerifyExactText("Please select an item from left to start practice.");
            click.ClickElementText("Radio Button");
            verify.VerifyExactText("Do you like the site?");
            verify.VerifyRadioButtonTextExit("Yes");
            verify.VerifyRadioButtonTextExit("Impressive");
            verify.VerifyRadioButtonTextExit("No");
            click.ClickRadioButtonText("Yes");
            verify.VerifyExactTextExist("You have selected ");
            verify.VerifyExactTextExist("Yes");
            click.ClickRadioButtonText("Impressive");
            verify.VerifyExactTextExist("You have selected ");
            verify.VerifyExactTextExist("Impressive");
        }
        [Test, Order(3)]
        public void ElementsButtons()
        {
            click.ClickElement("Elements");
            verify.VerifyExactText("Please select an item from left to start practice.");
            select.ScrollToElement("Buttons");
            click.ClickElementText("Buttons");
            verify.VerifyButtonTextExit("Double Click Me");
            verify.VerifyButtonTextExit("Right Click Me");
            verify.VerifyButtonTextExit("Click Me");
            click.DoubleClickButtonText("Double Click Me");
            verify.VerifyExactText("You have done a double click");
            click.RightClickButtonText("Right Click Me");
            verify.VerifyExactText("You have done a right click");
            select.ScrollToElement("Click Me");
            click.ClickButtonText("Click Me");
            verify.VerifyExactText("You have done a dynamic click");


            Thread.Sleep(3000);
        }



    }
}
