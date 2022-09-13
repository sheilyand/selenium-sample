﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace SeleniumSample.WebDriver
{
    public class WebDriver
    {
        public IWebDriver driver { get; set; }

        public WebDriver()
        {
            this.driver = new ChromeDriver();
        }
    }
}

