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
        public void AlertsWindows()
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
    }
}
