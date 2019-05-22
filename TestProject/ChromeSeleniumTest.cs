using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    [TestClass]
    public class ChromeSeleniumTest
    {
        [TestMethod]
        public void LoadDriverChrome()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\mr4eyesn\Desktop\SoftwareTesting_HW6_Projects\TestProject\TestProject\bin\Debug\");
            driver.Navigate().GoToUrl("https://www.seattleu.edu");

        }
    }
}
