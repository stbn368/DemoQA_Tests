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
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            click.ClickElementText("Text Box");
            verify.VerifyExactTextInElement("Full Name");
            verify.VerifyExactTextInElement("Email");
            verify.VerifyExactTextInElement("Current Address");
            verify.VerifyExactTextInElement("Permanent Address");
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
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            click.ClickElementText("Check Box");
            verify.VerifyCheckboxTextExit("Home");
            verify.VerifyButtonTooltipExit("Toggle");
            verify.VerifyButtonTooltipExit("Expand all");
            click.ClickButtonTooltip("Expand all");
            verify.VerifyCheckboxTextExit("Desktop");
            verify.VerifyCheckboxTextExit("Angular");
            select.ScrollToElement("Office");
            select.SelectCheckboxFollowingText("Office");
            verify.VerifyExactTextInElement("You have selected :");
            verify.VerifyCheckboxIsChecked("Public");
            verify.VerifyCheckboxIsChecked("Private");
            verify.VerifyCheckboxIsNotChecked("Angular");
            click.ClickButtonTooltip("Collapse all");
        }
        [Test, Order(2)]
        public void ElementsRadioButton()
        {
            click.ClickElement("Elements");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            click.ClickElementText("Radio Button");
            verify.VerifyExactTextInElement("Do you like the site?");
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
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            select.ScrollToElement("Buttons");
            click.ClickElementText("Buttons");
            verify.VerifyButtonTextExit("Double Click Me");
            verify.VerifyButtonTextExit("Right Click Me");
            verify.VerifyButtonTextExit("Click Me");
            click.DoubleClickButtonText("Double Click Me");
            verify.VerifyExactTextInElement("You have done a double click");
            click.RightClickButtonText("Right Click Me");
            verify.VerifyExactTextInElement("You have done a right click");
            select.ScrollToElement("Click Me");
            click.ClickButtonText("Click Me");
            verify.VerifyExactTextInElement("You have done a dynamic click");
        }

        [Test, Order(4)]
        public void ElementsWebTables()
        {
            click.ClickElement("Elements");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            select.ScrollToElement("Web Tables");
            click.ClickElementText("Web Tables");

            // Verify row already created
            verify.VerifyTextTableIndex(2, 2, "Alden");
            verify.VerifyTextTableIndex(2, 3, "Cantrell");
            verify.VerifyTextTableIndex(2, 4, "45");
            verify.VerifyTextTableIndex(2, 5, "alden@example.com");
            verify.VerifyTextTableIndex(2, 6, "12000");
            verify.VerifyTextTableIndex(2, 7, "Compliance");

            // Add a new row
            verify.VerifyButtonTextExit("Add");
            select.ScrollToElement("Add");
            click.ClickButtonText("Add");
            enterText.EnterTextInputWithLabelAndPlaceholder("First Name", "First Name", "User1");
            enterText.EnterTextInputWithLabelAndPlaceholder("Last Name", "Last Name", "LastName2");
            enterText.EnterTextInputWithLabelAndPlaceholder("Email", "name@example.com", "test1@testing.com");
            enterText.EnterTextInputWithLabelAndPlaceholder("Age", "Age", "29");
            enterText.EnterTextInputWithLabelAndPlaceholder("Salary", "Salary", "1200");
            enterText.EnterTextInputWithLabelAndPlaceholder("Department", "Department", "QA automation");
            verify.VerifyButtonTextExit("Submit");
            click.ClickButtonText("Submit");

            // Verify the new row added
            verify.VerifyTextTableIndex(4, 2, "User1");
            verify.VerifyTextTableIndex(4, 3, "LastName2");
            verify.VerifyTextTableIndex(4, 4, "29");
            verify.VerifyTextTableIndex(4, 5, "test1@testing.com");
            verify.VerifyTextTableIndex(4, 6, "1200");
            verify.VerifyTextTableIndex(4, 7, "QA automation");
        }

        [Test, Order(5)]
        public void ElementsLink()
        {
            click.ClickElement("Elements");
            verify.VerifyExactTextExist("Please select an item from left to start practice.");
            select.ScrollToElement("Links");
            click.ClickElementText("Links");

            //verify.VerifyLinkTextExist("Home");
            //click.ClickLinkText("Home");

            //// Waiting to implement navigate to new page
            
            //click.ClickElement("Elements");
            //verify.VerifyExactTextInElement("Please select an item from left to start practice.");
            //select.ScrollToElement("Links");
            //click.ClickElementText("Links");

            //verify.VerifyLinkTextExist("Home8ZXUh");

            verify.VerifyLinkTextExist("Created");
            click.ClickLinkText("Created");
            verify.VerifyExactTextExist("201");

            verify.VerifyLinkTextExist("No Content");
            click.ClickLinkText("No Content");
            verify.VerifyExactTextExist("204");

            verify.VerifyLinkTextExist("Moved");
            click.ClickLinkText("Moved");
            verify.VerifyExactTextExist("301");

            verify.VerifyLinkTextExist("Bad Request");
            click.ClickLinkText("Bad Request");
            verify.VerifyExactTextExist("400");

            verify.VerifyLinkTextExist("Unauthorized");
            click.ClickLinkText("Unauthorized");
            verify.VerifyExactTextExist("401");

            verify.VerifyLinkTextExist("Forbidden");
            click.ClickLinkText("Forbidden");
            verify.VerifyExactTextExist("403");

            verify.VerifyLinkTextExist("Not Found");
            click.ClickLinkText("Not Found");
            verify.VerifyExactTextExist("404");
        }

        [Test, Order(6)]
        public void ElementsBrokenLink()
        {
            click.ClickElement("Elements");
            verify.VerifyExactTextExist("Please select an item from left to start practice.");
            select.ScrollToElement("Broken Links - Images");
            click.ClickElementText("Broken Links - Images");

            verify.VerifyExactTextExist("Valid Link");
            verify.VerifyLinkTextExist("Click Here for Valid Link");
            select.ScrollToElement("Click Here for Valid Link");
            click.ClickLinkText("Click Here for Valid Link");
            click.ClickElement("Elements");
            verify.VerifyExactTextExist("Please select an item from left to start practice.");
            select.ScrollToElement("Broken Links - Images");
            click.ClickElementText("Broken Links - Images");

            verify.VerifyExactTextExist("Broken Link");
            verify.VerifyLinkTextExist("Click Here for Broken Link");
            click.ClickLinkText("Click Here for Broken Link");

            verify.VerifyPartialTextExist("This page returned a 500 status code");
            verify.VerifyLinkTextExist("here");
            click.ClickLinkText("here");

            verify.VerifyLinkTextExist("200");
            click.ClickLinkText("200");
            verify.VerifyPartialTextExist("This page returned a 200 status code");
            click.ClickLinkText("here");

            verify.VerifyLinkTextExist("301");
            click.ClickLinkText("301");
            verify.VerifyPartialTextExist("This page returned a 301 status code");
            click.ClickLinkText("here");

            verify.VerifyLinkTextExist("404");
            click.ClickLinkText("404");
            verify.VerifyPartialTextExist("This page returned a 404 status code");
            click.ClickLinkText("here");

            verify.VerifyLinkTextExist("500");
            click.ClickLinkText("500");
            verify.VerifyPartialTextExist("This page returned a 500 status code");
            click.ClickLinkText("here");
        }

        [Test, Order(6)]
        public void ElementsDownloaded()
        {
            click.ClickElement("Elements");
            verify.VerifyExactTextExist("Please select an item from left to start practice.");
            select.ScrollToElement("Upload and Download");
            click.ClickElementText("Upload and Download");

            verify.VerifyLinkTextExist("Download");
            click.ClickLinkText("Download");

            // Pendiente de implementar
            //string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //string downloadPath = Path.Combine(userPath, "Downloads");

            //DirectoryInfo dirInfo = new DirectoryInfo(downloadPath);

            //if (!dirInfo.Exists)
            //{
            //    dirInfo.Create();
            //}

            //int directoryFiles = dirInfo.EnumerateFiles().Count();


            //dirInfo = new DirectoryInfo(downloadPath);

            //int currentFiles = dirInfo.EnumerateFiles().Count();

            //Assert.Greater(currentFiles, directoryFiles);



            Thread.Sleep(5000);

        }

    }
}
