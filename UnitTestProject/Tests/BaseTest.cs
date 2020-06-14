using UnitTestProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject.Tests
{
   
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

       [TestInitialize]
        public void TestSetUp() 
        { 
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
