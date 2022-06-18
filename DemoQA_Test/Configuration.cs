using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test
{
    public class Configuration
    {
        public string URL = "https://demoqa.com/";
        public int timeOut = 25;

        //public string GetElementXpaths(string elementText)
        //{
        //    string[] elementXpaths =
        //    {
        //        "//*[contains(text(),'" + elementText + "')]/parent::div/parent::div",
        //        ".//*[contains(text(),'" + elementText + "')]"

        //    };

        //    return string.Join(" | ", elementXpaths);
        //}

    }
}
