﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Test
{
    public class Configuration
    {
        // Url of the testing page
        public string URL = "https://demoqa.com/";

        // Time to wait until getting a timeout
        public int timeOut = 10;

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
