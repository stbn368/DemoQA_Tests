using DemoQA_Test.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test.Tests
{
    public class FormsPage : Base
    {
        Click click = new Click();
        Verify verify = new Verify();
        Select select = new Select();
        EnterText enterText = new EnterText();

        [Test, Order(0)]
        public void Forms()
        {
            click.ClickElement("Forms");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            click.ClickElementText("Practice Form");





            Thread.Sleep(5000);
        }
    }
}
