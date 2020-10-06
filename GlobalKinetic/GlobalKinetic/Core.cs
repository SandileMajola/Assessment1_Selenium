using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Text;

namespace GlobalKinetic
{
    public class Core
    {
        public IWebDriver _driver;

        //Change this to run on another browser
        public Browser Driver = Browser.Chrome;

        public Core()
        {
            if (Driver == Browser.Chrome)
            {
                _driver = new ChromeDriver(@"C:\chromedriver");
            }
            else if (Driver == Browser.Firefox)
            {
                _driver = new FirefoxDriver();
            }
            else
            {
                _driver = new ChromeDriver();
            }

            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }



    }
}