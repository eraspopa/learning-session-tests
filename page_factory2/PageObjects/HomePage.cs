﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace page_factory2.PageObjects
{
    using static String;
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            Header = new Header(driver);
            Footer = new Footer(driver);
            Main = new Main(driver);
        }
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public Main Main { get; set; }

     
    }
}
