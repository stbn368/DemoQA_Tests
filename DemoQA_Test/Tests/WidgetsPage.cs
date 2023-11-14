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

        [Test, Order(1)]
        public void DatePickerTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");

            select.ScrollToElement("Date Picker");
            click.ClickElementText("Date Picker");

            select.openForm("datePickerMonthYearInput");
            select.SelectMonth("March");
            select.SelectYear("2025");
            select.SelectDay(16);
            verify.VerifyTextTogetherTab("Select Date", "03/16/2025");

            select.openForm("dateAndTimePickerInput");
            click.ClickElementByClass("react-datepicker__month-read-view--down-arrow");
            click.ClickElementText("July");
            click.ClickElementByClass("react-datepicker__year-read-view--down-arrow");
            click.ClickElementText("2027");
            select.SelectDay(17);
            click.ClickElementText("12:15");
            verify.VerifyTextTogetherTab("Date And Time", "July 17, 2027 12:15 PM");

            select.openForm("dateAndTimePickerInput");
            click.ClickElementText("00:00");
            verify.VerifyTextTogetherTab("Date And Time", "July 17, 2027 12:00 AM");

            //Thread.Sleep(10000);
        }

        [Test, Order(2)]
        public void ProgressBarTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");

            select.ScrollToElement("Progress Bar");
            click.ClickElementText("Progress Bar");

            verify.VerifyButtonTextExit("Start");
            click.ClickButtonText("Start");

            verify.VerifyExactTextExist("100%");

            verify.VerifyButtonTextExit("Reset");
            click.ClickButtonText("Reset");
            verify.VerifyButtonTextExit("Start");
            click.ClickButtonText("Start");

            Thread.Sleep(4000); //Pause to click on the stop button

            verify.VerifyButtonTextExit("Stop");
            click.ClickButtonText("Stop");
            verify.VerifyButtonTextExit("Start");
            click.ClickButtonText("Start");

            verify.VerifyExactTextExist("100%");
        }

        [Test, Order(3)]
        public void TabsTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");

            select.ScrollToElement("Tabs");
            click.ClickElementText("Tabs");

            verify.VerifyTabExits("What");
            verify.VerifyTabExits("Origin");
            verify.VerifyTabExits("Use");
            verify.VerifyTabExits("More");

            verify.VerifyTabIsSelected("What");
            verify.VerifyTabIsNotSelected("Origin");
            verify.VerifyTabIsNotSelected("More");

            verify.VerifyPartialTextExist("Lorem Ipsum is simply dummy text");

            select.SelectTab("Origin");
            verify.VerifyTabIsSelected("Origin");
            verify.VerifyTabIsNotSelected("What");

            verify.VerifyPartialTextExist("Contrary to popular belief");

            //Thread.Sleep(10000);
        }

        [Test, Order(4)]
        public void ToolTipsTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");

            select.ScrollToElement("Tool Tips");
            click.ClickElementText("Tool Tips");

            verify.VerifyExactTextExist("Practice Tool Tips");

            select.HoverElement("Hover me to see");
            select.HoverElement("Hover me to see");
            select.HoverElement("Contrary");
            select.HoverElement("1.10.32");

        }

        [Test, Order(5)]
        public void MenuTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");

            select.ScrollToElement("Menu");
            click.ClickElementText("Menu");

            verify.VerifyExactTextExist("Main Item 1");
            verify.VerifyExactTextExist("Main Item 2");
            verify.VerifyExactTextExist("Main Item 3");

            select.HoverDropDown("Main Item 2");
            select.HoverDropDown("SUB SUB LIST »");

            click.ClickElementText("Sub Sub Item 1");
        }

        [Test, Order(6)]
        public void SelectMenuTest()
        {
            click.ClickElement("Widgets");
            verify.VerifyExactTextInElement("Please select an item from left to start practice.");

            select.ScrollToElement("Select Menu");
            click.ClickElementText("Select Menu");

            


            Thread.Sleep(10000);
        }

    }
}
