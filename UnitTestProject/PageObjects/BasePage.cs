using OpenQA.Selenium;


namespace UnitTestProject.PageObjects
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        // Base Page methods
         
       
    }
}
