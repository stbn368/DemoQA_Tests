using DemoQA_Test.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Tests
{
    public class AlertPage : Base
    {
        Click click = new Click();
        Verify verify = new Verify();
        Select select = new Select();
        EnterText enterText = new EnterText();

        [Test, Order(0)]
        public void NewTabWindows()
        {
            click.ClickElement("Alerts, Frame & Windows");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            click.ClickElementText("Browser Windows");
            verify.VerifyButtonTextExit("New Tab");
            click.ClickButtonText("New Tab");
            select.SwitchNewTab();
            verify.VerifyExactTextExist("This is a sample page");
            select.CloseCurrentTab();
            select.SwitchDefaultTab();
            verify.VerifyButtonTextExit("New Window");
            click.ClickButtonText("New Window");
            select.SwitchNewWindows();
            verify.VerifyExactTextExist("This is a sample page");
            select.CloseCurrentTab();
            select.SwitchDefaultTab();
            
            //The next steps need to be implemented
            //verify.VerifyButtonTextExit("New Window Message");
            //click.ClickButtonText("New Window Message");
            //select.SwitchNewWindows();
            //verify.VerifyExactTextExist("Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.");
            //select.CloseCurrentTab();

        }

        [Test, Order(1)]
        public void AlertWindows()
        {
            click.ClickElement("Alerts, Frame & Windows");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            select.ScrollToElement("Alerts");
            click.ClickElementText("Alerts");

            //Scenario 1: simple alert
            select.ScrollToElement("Click Button to see alert ");
            verify.VerifyExactTextExist("Click Button to see alert ");
            click.ClickButtonTextTogetherText("Click me", "Click Button to see alert ");          
            click.AcceptSimpleAlert();

            //Scenario 2: simple alert shown after 5 seconds
            select.ScrollToElement("On button click, alert will appear after 5 seconds ");
            verify.VerifyExactTextExist("On button click, alert will appear after 5 seconds ");
            //click.ClickButtonTextTogetherText("Click me", "On button click, alert will appear after 5 seconds ");
            //click.AcceptSimpleAlertAfterTime(7);

            //Scenario 3: confirm and dimiss alert
            select.ScrollToElement("On button click, confirm box will appear");
            verify.VerifyExactTextExist("On button click, confirm box will appear");
            click.ClickButtonTextTogetherText("Click me", "On button click, confirm box will appear");

            click.AcceptSimpleAlert();
            //verify.VerifyExactTextExist("");

            click.ClickButtonTextTogetherText("Click me", "On button click, confirm box will appear");
            click.DimissAlert();
            //verify.VerifyExactTextExist("");

            //Scenario 4: send text in the popup alert
            select.ScrollToElement("On button click, prompt box will appear");
            verify.VerifyExactTextExist("On button click, prompt box will appear");
            click.ClickButtonTextTogetherText("Click me", "On button click, prompt box will appear");
            driver.SwitchTo().Alert().SendKeys("testing alert");
            click.AcceptSimpleAlert();
        }
    }
}
