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
            verify.VerifyExactTextExist("Student Registration Form");
            click.ClickButtonId("dateOfBirthInput");

            //The next steps need to be implemented
            //select.SelectDate("8", "February", "2000");
            //enterText.EnterTextInputWithLabelAndPlaceholder("Name", "First Name", "Name1");
            //enterText.EnterTextInputWithLabelAndPlaceholder("Name", "Last Name", "Last1");
            //enterText.EnterTextInputWithLabelAndPlaceholder("Email", "name@example.com", "testing1@test.com");
            //enterText.EnterTextInputWithLabelAndPlaceholder("Mobile", "Mobile Number", "1234567890");
            //select.SelectCheckboxFollowingText("Reading");
            //select.SelectCheckboxPrecedingText("Reading");

            //Thread.Sleep(10000);
        }
    }
}
